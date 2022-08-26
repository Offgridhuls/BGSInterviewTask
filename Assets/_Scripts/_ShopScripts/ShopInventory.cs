using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopInventory : MonoBehaviour
{
    private List<ClothingItem> clothingItems;

    public ShopInventory()
    {
        clothingItems = new List<ClothingItem>();

        //HOODS
        AddItem(new ClothingItem { type = ClothingType.Hood, sprite = ItemAssets.Instance.hoodSprites[1], isShopItem = true, salePrice = 300, sellPrice = 150, bodyPart = PlayerBehaviour.Instance.hood, amount = 1 });
        AddItem(new ClothingItem { type = ClothingType.Hood, sprite = ItemAssets.Instance.hoodSprites[2], isShopItem = true, salePrice = 400, sellPrice = 200, bodyPart = PlayerBehaviour.Instance.hood, amount = 1 });
        AddItem(new ClothingItem { type = ClothingType.Hood, sprite = ItemAssets.Instance.hoodSprites[3], isShopItem = true, salePrice = 400, sellPrice = 200, bodyPart = PlayerBehaviour.Instance.hood, amount = 1 });
        AddItem(new ClothingItem { type = ClothingType.Hood, sprite = ItemAssets.Instance.hoodSprites[4], isShopItem = true, salePrice = 400, sellPrice = 200, bodyPart = PlayerBehaviour.Instance.hood, amount = 1 });
        AddItem(new ClothingItem { type = ClothingType.Hood, sprite = ItemAssets.Instance.hoodSprites[5], isShopItem = true, salePrice = 400, sellPrice = 200, bodyPart = PlayerBehaviour.Instance.hood, amount = 1 });
       

        //TORSO 
        AddItem(new ClothingItem { type = ClothingType.Torso, sprite = ItemAssets.Instance.torsoSprites[1], isShopItem = true, salePrice = 500, sellPrice =250, bodyPart = PlayerBehaviour.Instance.torso, amount = 1 });
        AddItem(new ClothingItem { type = ClothingType.Torso, sprite = ItemAssets.Instance.torsoSprites[2], isShopItem = true, salePrice = 600, sellPrice = 300, bodyPart = PlayerBehaviour.Instance.torso, amount = 1 });
        AddItem(new ClothingItem { type = ClothingType.Torso, sprite = ItemAssets.Instance.torsoSprites[3], isShopItem = true, salePrice = 600, sellPrice = 300, bodyPart = PlayerBehaviour.Instance.torso, amount = 1 });
        AddItem(new ClothingItem { type = ClothingType.Torso, sprite = ItemAssets.Instance.torsoSprites[4], isShopItem = true, salePrice = 600, sellPrice = 300, bodyPart = PlayerBehaviour.Instance.torso, amount = 1 });
        AddItem(new ClothingItem { type = ClothingType.Torso, sprite = ItemAssets.Instance.torsoSprites[5], isShopItem = true, salePrice = 600, sellPrice = 300, bodyPart = PlayerBehaviour.Instance.torso, amount = 1 });
       

        //PELVIS
        AddItem(new ClothingItem { type = ClothingType.Pelvis, sprite = ItemAssets.Instance.pelvisSprites[1], isShopItem = true, salePrice = 200, sellPrice = 100, bodyPart = PlayerBehaviour.Instance.pelvis, amount = 1 });
        AddItem(new ClothingItem { type = ClothingType.Pelvis, sprite = ItemAssets.Instance.pelvisSprites[2], isShopItem = true, salePrice = 100, sellPrice = 50, bodyPart = PlayerBehaviour.Instance.pelvis, amount = 1 });
        AddItem(new ClothingItem { type = ClothingType.Pelvis, sprite = ItemAssets.Instance.pelvisSprites[3], isShopItem = true, salePrice = 100, sellPrice = 50, bodyPart = PlayerBehaviour.Instance.pelvis, amount = 1 });
        AddItem(new ClothingItem { type = ClothingType.Pelvis, sprite = ItemAssets.Instance.pelvisSprites[4], isShopItem = true, salePrice = 100, sellPrice = 50, bodyPart = PlayerBehaviour.Instance.pelvis, amount = 1 });
        AddItem(new ClothingItem { type = ClothingType.Pelvis, sprite = ItemAssets.Instance.pelvisSprites[5], isShopItem = true, salePrice = 100, sellPrice = 50, bodyPart = PlayerBehaviour.Instance.pelvis, amount = 1 });
        

        //AddItem(new ClothingItem { type = ClothingType.Hood, sprite = Clothing amount = 1 });
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
}
