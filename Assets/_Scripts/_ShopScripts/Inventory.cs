using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public static Inventory Instance { get; private set; }
    // Start is called before the first frame update
    private List<ClothingItem> clothingItems;


    public void Awake()
    {
        Instance = this;
    }
    public Inventory()
    {
        clothingItems = new List<ClothingItem>();

        AddItem(new ClothingItem { type = ClothingType.Hood, 
            sprite = ItemAssets.Instance.hoodSprites[0], 
            isShopItem = false, 
            bodyPart = PlayerBehaviour.Instance.hood, 
            salePrice = 0,
            amount = 1 });
       
        AddItem(new ClothingItem { type = ClothingType.Torso, 
            sprite = ItemAssets.Instance.torsoSprites[0], 
            isShopItem = false, 
            bodyPart = PlayerBehaviour.Instance.torso,
            salePrice = 0,
            amount = 1 });

        AddItem(new ClothingItem { type = ClothingType.Pelvis, 
            sprite = ItemAssets.Instance.pelvisSprites[0], 
            isShopItem = false, 
            bodyPart = PlayerBehaviour.Instance.pelvis,
            salePrice = 0,
            amount = 1 });
    }

    public void EquipItem(ClothingItem item)
    {
        item.bodyPart.sprite = item.sprite;
    }

    public List<ClothingItem> GetItemList()
    {
        return clothingItems;
    }
    public void AddItem(ClothingItem item)
    {
        clothingItems.Add(item);
    }

    public void RemoveItem(ClothingItem item)
    {
        clothingItems.Remove(item);
    }

}
