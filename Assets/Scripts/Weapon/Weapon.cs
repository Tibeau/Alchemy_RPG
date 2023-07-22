using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public Camera sceneCamera;

    private WeaponPartManager weaponPartManager;
    private ProjectileFactory bulletFactory;

    private void Start()
    {
        weaponPartManager = GetComponent<WeaponPartManager>();
        bulletFactory = GetComponent<ProjectileFactory>();
    }

    void Update()
    {
        ProcessInputs();
    }

    void FixedUpdate()
    {
        Aim();
    }

    void ProcessInputs()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
        }
    }

    void Aim()
    {
        Vector2 mouseWorldPosition = sceneCamera.ScreenToWorldPoint(Input.mousePosition);
        Vector2 aimDirection = mouseWorldPosition - (Vector2)transform.position;
        float aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;
        transform.rotation = Quaternion.Euler(0f, 0f, aimAngle);
    }

    public void Fire()
    {
        WeaponProjectile projectileData = weaponPartManager.GetCombinedBulletData();
        bulletFactory.CreateBullet(projectileData, firePoint.position, firePoint.rotation);
    }
}