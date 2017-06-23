using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour {

    //Item manipulation variables
    public Item item;
    public Item itemHolder;
    public Image image;
    public Inventory inventory;

    //Find the actual inventory Canvas
    void Awake()
    {
        inventory = GameObject.Find("Inventory").GetComponent<Inventory>();
    }

    //Enable image if there is an item
    void Update()
    {
        if(item != null)
        {
            image.sprite = item.itemImage;
            image.enabled = true;
        }
    }

    //Pick up and drop items within the inventory
    void OnClick()
    {
        if(item == null)
        {
            if(inventory.activeItem != null)
            {
                item = inventory.activeItem;
                inventory.activeItem = null;
                image.sprite = item.itemImage;
                image.enabled = true;
            }
        }
        else
        {
            if(inventory.activeItem == null)
            {
                inventory.activeItem = item;
                item = null;
                image.sprite = null;
                image.enabled = false;
            }
            else
            {
                itemHolder = item;
                item = inventory.activeItem;
                inventory.activeItem = itemHolder;
                itemHolder = null;
                image.sprite = item.itemImage;
                image.enabled = true;
            }
        }
    }
}
