using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnCollision : MonoBehaviour
{
   private void OnCollisionEnter2D(Collision2D collision) {
     Debug.Log("plyer took damage");
    if (collision.gameObject.CompareTag("Player")) {
        collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(1);
    }
   }
}
