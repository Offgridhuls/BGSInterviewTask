using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    private Animator animator;

    public Inventory inventory;

    public static Shop Instance { get; private set;
    }
    private ShopInventory shopInventory;

    [SerializeField] private UI_Inventory inventoryUI;

    [SerializeField] private UI_Shop shopUI;

    private bool isOpen;

    void Awake()
    {
        Instance = this;
        isOpen = false;
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        shopInventory = new ShopInventory();
        inventory = new Inventory();

        inventoryUI.SetInventory(inventory);
        shopUI.SetInventory(shopInventory);
    }
    public void ToggleShopGUI()
    {
        isOpen = !isOpen;
        animator.SetBool("isOpen", isOpen);
    }

    public void CloseShopGUI()
    {
        isOpen = false;
        animator.SetBool("isOpen", isOpen);
    }

   
}
