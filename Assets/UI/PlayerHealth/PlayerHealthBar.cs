using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public GameObject hearthPrefab;
    public float health, maxHealth;
    List<PlayerHealthHeart> hearts = new List<PlayerHealthHeart>();

    public void Start()
    {
        DrawHearths();
    }

    public void DrawHearths()
    {
        ClearHearts();

        float maxHealthRemainder = maxHealth % 2;
        int heartsToMake = (int)((maxHealth / 2) + maxHealthRemainder);
        for (int i = 0; i < heartsToMake; i++)
        {
            CreateEmptyHeart();
        }

        for (int i = 0; i < hearts.Count; i++)
        {
            int heartStatusRemainder = (int)Mathf.Clamp(health - (i * 2), 0, 2);
            hearts[i].SetHeartImage((HeartStatus)heartStatusRemainder);
        }
    }

    public void CreateEmptyHeart()
    {
        GameObject newHeart = Instantiate(hearthPrefab);
        newHeart.transform.SetParent(transform);

        PlayerHealthHeart hearthComponent = newHeart.GetComponent<PlayerHealthHeart>();
        hearthComponent.SetHeartImage(HeartStatus.Empty);
        hearts.Add(hearthComponent);
    }

    public void ClearHearts()
    {
        foreach (Transform target in transform)
        {
            Destroy(target.gameObject);
        }
        hearts = new List<PlayerHealthHeart>();
    }
}
