using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{
    public int[] Items;
    public Item EquipedItem;

    private void Start()
    {
        Items = new int[2];
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1) && Items[0] != 0)
        {
            Equip(GetItemByID(Items[0]));
        }
        else if (Input.GetKey(KeyCode.Alpha2) && Items[1] != 0)
        {
            Equip(GetItemByID(Items[1]));
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKey(KeyCode.E))
        {
            AddToInventory(collision.gameObject.GetComponent<Item>());
            Destroy(collision.gameObject);
        }
    }

    public void AddToInventory(Item item)
    {
        if (Items[0] == 0)
        {
            Items[0] = item.ID;
            Equip(item);
        }
        else if (Items[1] == 0)
        {
            Items[1] = item.ID;
            Equip(item);
        }

        //Austauschen: Droppen => Überschreiben
    }

    public void Equip(Item item)
    {
        EquipedItem = item;
    }

    public Item GetItemByID(int iD)
    {
        switch (iD)
        {
            //case 0:
            //    return new Item(0, "organspendeausweis");

            //case 1:
            //    return new Item(1, "bow");

            default:
                return null;
        }
    }
}
