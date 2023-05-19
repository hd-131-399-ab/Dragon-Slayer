using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public List<Sprite> Images;
    public int[] Items;

    public int EquipedItem;

    public Image Slot1;
    public Image Slot2;
    public Image SelectionImage;

    private void Start()
    {
        SelectionImage.enabled = false;

        Items = new int[2];
        Items[0] = -1;
        Items[1] = -1;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1) && Items[0] != -1)
        {
            Equip(Items[0]);
            MoveSelectionImageToSlot(Slot1);
        }
        else if (Input.GetKey(KeyCode.Alpha2) && Items[1] != -1)
        {
            Equip(Items[1]);
            MoveSelectionImageToSlot(Slot2);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKey(KeyCode.E))
        {
            AddToInventory(collision.gameObject.GetComponent<ItemBehaviour>());
            Destroy(collision.gameObject);
        }
    }

    public void AddToInventory(ItemBehaviour itemBehaviour)
    {
        if (Items[0] == -1)
        {
            Items[0] = itemBehaviour.ID;
            Equip(Items[0]);
        }
        
        if (Items[1] == -1 && Items[0] != -1)
        {
            Items[1] = itemBehaviour.ID;
            Equip(Items[1]);
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

    public void Equip(int id)
    {
        EquipedItem = id;

        SelectionImage.enabled = true;

        //Add Bowsystem to player
    }

    public void MoveSelectionImageToSlot(Image slot)
    {
        if (slot == Slot1)
        {
            SelectionImage.enabled = true;
            SelectionImage.transform.position = new Vector2(25, -30);
        }
        else
        {
            SelectionImage.enabled = true;
            SelectionImage.transform.position = new Vector2(100, -30);
        }
    }
}
