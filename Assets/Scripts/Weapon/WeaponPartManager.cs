using UnityEngine;
public class WeaponPartManager : MonoBehaviour
{
    [SerializeField] private WeaponCombination currentWeaponCombination;

     public void SetFrontPart(WeaponType newWeaponType)
    {
        currentWeaponCombination.WeaponType = newWeaponType;
    }
     public void SetMiddlePart(WeaponElement newWeaponElement)
    {
         currentWeaponCombination.WeaponElement = newWeaponElement;
    }

    public void SetExtraPart(WeaponUpgrades newWeaponUpgrade)
    {
         currentWeaponCombination.WeaponUpgrade = newWeaponUpgrade;
    }

    public WeaponProjectile GetCombinedBulletData()
    {
        WeaponProjectile projectileData = ScriptableObject.CreateInstance<WeaponProjectile>();
        projectileData.bulletPrefab =  currentWeaponCombination.WeaponType.bulletPrefab;
        projectileData.shootAnimation =  currentWeaponCombination.WeaponType.shootAnimation;
        projectileData.elementalType =  currentWeaponCombination.WeaponElement.elementalType;
        projectileData.totalDamage =  currentWeaponCombination.WeaponElement.damage +  currentWeaponCombination.WeaponUpgrade.additionalDamage;
        projectileData.fireForce =  currentWeaponCombination.fireForce +  currentWeaponCombination.WeaponUpgrade.additionalFireForce;
        projectileData.color =  currentWeaponCombination.WeaponElement.color;
        return projectileData;
    }
}