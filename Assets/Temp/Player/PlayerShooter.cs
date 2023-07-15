using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour
{

    // private Vector2 mousePosition;
    // public Rigidbody2D rb;
    // public Camera sceneCamera;
    public Weapon weapon;


    void Update()
    {
        ProcessInputs();
    }

    // void FixedUpdate()
    // {
        // Aim();
    // }


    void ProcessInputs()
    {
        // mousePosition = sceneCamera.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            weapon.Fire();
        }
    }

    // void Aim()
    // {
    //     Vector2 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //     Vector2 aimDirection = mouseWorldPosition - (Vector2)transform.position;
    //     float aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;
    //     transform.rotation = Quaternion.Euler(0f, 0f, aimAngle);
    // }
}
