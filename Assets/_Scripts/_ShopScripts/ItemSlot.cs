using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;

public class ItemSlot : MonoBehaviour, IPointerClickHandler
{
    public ClothingItem item;

    public Image iconImage;

    public Text amountText;

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        iconImage.sprite = item.GetSprite();
        if (item.isShopItem)
            amountText.text = "$" + item.salePrice.ToString();
        else
            amountText.text = "$" + item.sellPrice.ToString();
    }
    void Update()
    {
       
    }
    public void OnPointerClick (PointerEventData eventData)
    {
        
        if (item.isShopItem && PlayerBehaviour.Instance.playerStats.moneyCount >= item.salePrice)
        {
            Shop.Instance.inventory.AddItem(item);
            PlayerBehaviour.Instance.playerStats.moneyCount -= item.salePrice;
            item.isShopItem = false;
        }
        else
        {
            item.SetSprite();
        }
       
        if (eventData.button == PointerEventData.InputButton.Right && item.isShopItem == false)
        {
            Shop.Instance.inventory.RemoveItem(item);
            PlayerBehaviour.Instance.playerStats.moneyCount += item.sellPrice;
            item.isShopItem = true;
        }
    }
    
    // Start is called before the first frame update
}
