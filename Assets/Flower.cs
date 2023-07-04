using UnityEngine;
using System;

public class Flower : MonoBehaviour, ICollectible
{
    public static event HandleGemCollected OnFlowerCollected;
    public delegate void HandleGemCollected(ItemData item);
    public ItemData flowerData;
    public void Collect()
    {
        Destroy(gameObject);
        OnFlowerCollected?.Invoke(flowerData);
    }
}
