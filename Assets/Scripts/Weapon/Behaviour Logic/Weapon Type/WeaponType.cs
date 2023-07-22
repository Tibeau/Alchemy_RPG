using UnityEngine;

[CreateAssetMenu(fileName = "NewWeaponType", menuName = "Weapon Logic / Weapon Type")]
public class WeaponType : ScriptableObject
{
    public GameObject bulletPrefab;
    public AnimationClip shootAnimation;
}