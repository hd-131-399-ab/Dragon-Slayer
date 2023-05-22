using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.PlayerSettings;

public class Inventory : MonoBehaviour
{
    public List<Sprite> Images;
    public int[] Items;

    public int EquipedItem;

    public Image Slot1;
    public Image Slot2;
    public Image SelectionImage;

    private ItemBehaviour _ItemBehaviour;

    private void Start()
    {
        SelectionImage.enabled = false;

        Items = new int[2];
        Items[0] = -1;
        Items[1] = -1;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            EquipItem();
            MoveSelectionImageToSlot(1);
        }
        else if (Input.GetKey(KeyCode.Alpha2))
        {
            EquipItem();
            MoveSelectionImageToSlot(2);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKey(KeyCode.E))
        {
            _ItemBehaviour = collision.gameObject.GetComponent<ItemBehaviour>();

            AddToInventory(_ItemBehaviour);
            Destroy(collision.gameObject);
        }
    }

    public void AddToInventory(ItemBehaviour itemBehaviour)
    {
        if (itemBehaviour == null)
        {
            print("joa");
        }

        if (Items[0] == -1)
        {
            Items[0] = itemBehaviour.ID;
            EquipItem();
            MoveSelectionImageToSlot(1);
        }        
        else if (Items[1] == -1 && Items[0] != -1)
        {
            Items[1] = itemBehaviour.ID;
            EquipItem();
            MoveSelectionImageToSlot(2);
        }

        //Austauschen: Droppen => Überschreiben
        UpdateGUI();
    }

    public void UpdateGUI()
    {
        if (Items[0] != -1)
        {
            Slot1.sprite = Images[Items[0]];
        }

        if (Items[1] != -1)
        {
            Slot2.sprite = Images[Items[1]];
        }
    }

    public void EquipItem()
    {
        EquipedItem = _ItemBehaviour.ID;

        _ItemBehaviour.LoadItemBehaviour();
    }

    public void MoveSelectionImageToSlot(int slot)
    {
        if (slot == 1)
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
}
