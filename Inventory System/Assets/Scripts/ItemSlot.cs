using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour {

    public Item item;
    public Item itemHolder;
    public Image image;
    public Inventory inventory;

    void Awake()
    {
        inventory = GameObject.Find("Inventory").GetComponent<Inventory>();
    }

    void Update()
    {
        if(item != null)
        {
            image.sprite = item.itemImage;
            image.enabled = true;
        }
    }

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
