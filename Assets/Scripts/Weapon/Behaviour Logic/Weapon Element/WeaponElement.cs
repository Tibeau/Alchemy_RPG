using UnityEngine;

[CreateAssetMenu(fileName = "NewWeaponElement", menuName = "Weapon Logic / Weapon Element")]
public class WeaponElement : ScriptableObject
{
    public ElementalType elementalType;
    public float damage;

    public Color color;
    // Other properties related to the elemental effect
}

public enum ElementalType
{
    None,
    Fire,
    Ice,
    Electric,
    // Add more elemental types as needed
}