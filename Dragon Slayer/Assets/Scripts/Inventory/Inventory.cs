using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.PlayerSettings;

public class Inventory : MonoBehaviour
{
    public List<Sprite> Images;
    public GameObject[] Items;

    public GameObject EquipedItem;

    public Image Slot1;
    public Image Slot2;
    public Image SelectionImage;

    private GameObject Item;
    private ItemBehaviour _ItemBehaviour;

    private void Start()
    {
        SelectionImage.enabled = false;

        EquipedItem = null;

        Items = new GameObject[2];
        Items[0] = null;
        Items[1] = null;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            MoveSelectionImageToSlot(0);
            EquipItem(Items[0]);
            MoveSelectionImageToSlot(0);
        }
        else if (Input.GetKey(KeyCode.Alpha2))
        {
            MoveSelectionImageToSlot(1);
            EquipItem(Items[1]);
            MoveSelectionImageToSlot(1);
        }
        //else if (Input.GetKey(KeyCode.R))
        //{
        //    DropItem(EquipedItem);

        //    EquipedItem = null;
        //    SelectionImage.enabled = false;
        //    UpdateGUI();
        //}
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKey(KeyCode.E))
        {
            collision.gameObject.SetActive(false);
            Item = collision.gameObject;

            _ItemBehaviour = Item.GetComponent<ItemBehaviour>();

            AddToInventory();
        }
    }

    public void AddToInventory()
    {
        for (int i = 0; i < Items.Length; i++)
        {
            if (Items[i] == null)
            {
                Items[i] = Item;
                EquipItem(Item);
                UpdateGUI();
                MoveSelectionImageToSlot(i);
                break;
            }
        }
    }

    public void EquipItem(GameObject item)
    {
        EquipedItem = item;

        //item.GetComponent<ItemBehaviour>().LoadItemBehaviour();
    }

    public void UpdateGUI()
    {
        ItemBehaviour itemBehaviour;

        if (Items[0] != null)
        {
            itemBehaviour = Items[0].GetComponent<ItemBehaviour>();

            Slot1.sprite = Images[itemBehaviour.ID];
        }

        if (Items[1] != null)
        {
            itemBehaviour = Items[1].GetComponent<ItemBehaviour>();

            Slot2.sprite = Images[itemBehaviour.ID];
        }
    }

    public void MoveSelectionImageToSlot(int slot)
    {
        if (slot == 0)
        {
            SelectionImage.enabled = true;
            SelectionImage.rectTransform.anchoredPosition = new Vector2(25, -25);
        }
        else
        {
            SelectionImage.enabled = true;
            SelectionImage.rectTransform.anchoredPosition = new Vector2(95, -25);
        }
    }

    public void DropItem(GameObject item)
    {
        item.SetActive(true);
        item.gameObject.transform.position = gameObject.transform.position;
    }
}
