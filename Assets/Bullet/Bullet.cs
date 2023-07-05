using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D rb;
    public float damage;

    void OnTriggerEnter2D(Collider2D other) 
    {
        switch(other.gameObject.tag)
        {
            case "Wall":
            Destroy(gameObject);
            break;
            case "Enemy":
            other.gameObject.GetComponent<Enemy>().TakeDamage(damage);
            Destroy(gameObject);
            break;
        }
    }
}
