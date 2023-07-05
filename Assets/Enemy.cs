using System;
using UnityEngine;
public class Enemy : MonoBehaviour
{
    public static event Action<Enemy> OnEnemyDamaged;
    public static event Action<Enemy> OnEnemyDeath;
    public float health, maxHealth;
    public float moveSpeed;
    public Rigidbody2D rb;
    public GameObject player;
    private Transform target;
    private Vector2 moveDirection;

    private void Start()
    {
        health = maxHealth;
        target = player.transform;
    }

    private void Update() {
        if(target) {
            Vector3 direction = (target.position - transform.position).normalized;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            rb.rotation = angle;
            moveDirection = direction;
        }
    }

    private void FixedUpdate() {
        if (target) {
            rb.velocity = new Vector2(moveDirection.x, moveDirection.y) * moveSpeed;
        }
    }


    public void TakeDamage(float amount)
    {
        health -= amount;

        OnEnemyDamaged?.Invoke(this);

        if (health <= 0)
        {
            health = 0;
            Destroy(gameObject);
            OnEnemyDeath?.Invoke(this);
        }
    }
}

