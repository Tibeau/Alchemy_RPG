using UnityEngine;

[CreateAssetMenu(fileName = "NewWeaponProjectile", menuName = "Weapon Logic / Weapon projectile")]
public class WeaponProjectile : ScriptableObject
{
    public GameObject bulletPrefab;
    public AnimationClip shootAnimation;
    public ElementalType elementalType;
    public float totalDamage;
    public float fireForce;
    public Color color;
}