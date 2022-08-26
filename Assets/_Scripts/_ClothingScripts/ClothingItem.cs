using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ClothingType { 
    Hood = 0,
    Torso = 1,
    Pelvis = 2,
    COUNT = 3
}

public class ClothingItem 
{

    public ClothingType type;

    public int amount;

    public bool isShopItem;

    public Sprite sprite;

    public SpriteRenderer bodyPart;

    public int salePrice;

    public int sellPrice;

    public Sprite GetSprite()
    {
        return sprite;
    }
    public void SetSprite()
    {
        bodyPart.sprite = sprite;
    }

    
}
