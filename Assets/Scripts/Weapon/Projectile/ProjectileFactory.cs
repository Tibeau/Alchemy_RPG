using UnityEngine;

public class ProjectileFactory : MonoBehaviour
{
       public void CreateBullet(WeaponProjectile projectileData, Vector3 spawnPosition, Quaternion spawnRotation)
    {
        GameObject projectile = Instantiate(projectileData.bulletPrefab, spawnPosition, spawnRotation);
        Rigidbody2D projectileRigidbody = projectile.GetComponent<Rigidbody2D>();
        SpriteRenderer projectileRenderer = projectile.GetComponent<SpriteRenderer>();
        
        if (projectileRigidbody != null)
        {
            Vector2 fireDirection = projectile.transform.up;
            projectileRigidbody.velocity = fireDirection * projectileData.fireForce;
            projectileRenderer.color = projectileData.color;
        }

        // You can also apply any other properties to the bullet here based on bulletData
    }
}
