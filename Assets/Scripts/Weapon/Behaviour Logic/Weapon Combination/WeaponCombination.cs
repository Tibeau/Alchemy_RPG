using UnityEngine;

[CreateAssetMenu(fileName = "NewWeaponCombination", menuName = "Weapon Logic / Weapon Combination")]

public class WeaponCombination : ScriptableObject
{
    public WeaponType WeaponType;
    public WeaponElement WeaponElement;
    public WeaponUpgrades WeaponUpgrade;
    public float fireForce = 5f;
}
