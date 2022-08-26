using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine;

public class UI_Inventory : MonoBehaviour
{
    private Inventory inventory;
    
    public Transform itemSlotTemplate;

    private List<GameObject> inventorySlots = new List<GameObject>();

    public Text ClothingTypeText;

    private int currentOption = 0;

    private void Start()
    {
       
    }

    private void Update()
    {
        if(currentOption == (int)ClothingType.Hood)
        {
            ClothingTypeText.text = "HOOD";
        }
        else if(currentOption == (int)ClothingType.Pelvis)
        {
            ClothingTypeText.text = "PELVIS";
        }
        else if(currentOption == (int)ClothingType.Torso)
        {
            ClothingTypeText.text = "TORSO";
        }
    }

    public void SetInventory(Inventory inventory)
    {
        this.inventory = inventory;
    }

    public void NextType()
    {
        currentOption++;
        if(currentOption >= (int)ClothingType.COUNT)
        {
            currentOption = 0;
        }
        RefreshInventoryItems((ClothingType)currentOption);
    }

    public void PreviousType()
    {
        currentOption--;
        if(currentOption <= -1)
        {
            currentOption = (int)ClothingType.COUNT - 1;
        }
        RefreshInventoryItems((ClothingType)currentOption);
    }


    private void RefreshInventoryItems(ClothingType type)
    {
        foreach (GameObject transform in inventorySlots)
        {
            Destroy(transform);
        }
            foreach (ClothingItem item in inventory.GetItemList())
            {
                if (item.type == type)
                {
                    RectTransform itemSlotRectTransform = Instantiate(itemSlotTemplate, transform).GetComponent<RectTransform>();
                    inventorySlots.Add(itemSlotRectTransform.gameObject);

                    Image image = itemSlotRectTransform.Find("itemImage").GetComponent<Image>();

                    var itemSlot = itemSlotRectTransform.GetComponent<ItemSlot>();

                    itemSlot.item = item;
                    image.sprite = item.GetSprite();
                }
            }
        
    }
    // Start is called before the first frame update
}
