using UnityEngine;
public class WeaponPartManager : MonoBehaviour
{
    [SerializeField] private WeaponType currentWeaponType;
    [SerializeField] private WeaponElement currentWeaponElement;
    [SerializeField] private WeaponUpgrades currentWeaponUpgrade;
    [SerializeField] private float fireForce = 5f;


     public void SetFrontPart(WeaponType newWeaponType)
    {
        currentWeaponType = newWeaponType;
    }
 public void SetMiddlePart(WeaponElement newWeaponElement)
    {
        currentWeaponElement = newWeaponElement;
    }

    public void SetExtraPart(WeaponUpgrades newWeaponUpgrade)
    {
        currentWeaponUpgrade = newWeaponUpgrade;
    }

    public WeaponProjectile GetCombinedBulletData()
    {
        WeaponProjectile projectileData = ScriptableObject.CreateInstance<WeaponProjectile>();
        projectileData.bulletPrefab = currentWeaponType.bulletPrefab;
        projectileData.shootAnimation = currentWeaponType.shootAnimation;
        projectileData.elementalType = currentWeaponElement.elementalType;
        projectileData.totalDamage = currentWeaponElement.damage + currentWeaponUpgrade.additionalDamage;
        projectileData.fireForce = fireForce + currentWeaponUpgrade.additionalFireForce;
        projectileData.color = currentWeaponElement.color;
        return projectileData;
    }
}