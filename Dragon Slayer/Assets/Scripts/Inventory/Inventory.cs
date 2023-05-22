using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
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

    private ItemBehaviour _ItemBehaviour;
    private GameObject Item;

    private void Start()
    {
        SelectionImage.enabled = false;

        Items = new GameObject[2];
        Items[0] = null;
        Items[1] = null;
    }

    private void Update()
    {
        //KeyCode key = KeyCode.Alpha0;

        //switch (key)
        //{
        //    case KeyCode.Alpha0:
        //        //EquipItem(Items[10]);
        //        break;
        //    case KeyCode.Alpha1:
        //        EquipItem(Items[0]);
        //        break;
        //    case KeyCode.Alpha2:
        //        EquipItem(Items[1]);
        //        break;
        //    case KeyCode.Alpha3:
        //        break;
        //    case KeyCode.Alpha4:
        //        break;
        //    case KeyCode.Alpha5:
        //        break;
        //    case KeyCode.Alpha6:
        //        break;
        //    case KeyCode.Alpha7:
        //        break;
        //    case KeyCode.Alpha8:
        //        break;
        //    case KeyCode.Alpha9:
        //        break;
        //}

        if (Input.GetKey(KeyCode.Alpha1))
        {
            EquipItem(Items[0]);
            MoveSelectionImageToSlot(0);
        }
        else if (Input.GetKey(KeyCode.Alpha2))
        {
            EquipItem(Items[1]);
            MoveSelectionImageToSlot(1);
        }
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
        //else if (Input.GetKey(KeyCode.D))
        //{
        //    collision.gameObject.SetActive(false);
        //    Item = collision.gameObject;
        //}
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
        if (item != null)
        {
            EquipedItem = item;

            ItemBehaviour itemBehaviour = item.GetComponent<ItemBehaviour>();
        }
    }

    public void UpdateGUI()
    {
        ItemBehaviour itemBehaviour;

        if (Items[0] != null)
        {
            itemBehaviour = Items[0].GetComponent<ItemBehaviour>();

            print(itemBehaviour.ID);
            Slot1.sprite = Images[itemBehaviour.ID];
        }


        if (Items[1] != null)
        {
            itemBehaviour = Items[1].GetComponent<ItemBehaviour>();

            print(itemBehaviour.ID);
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
}
