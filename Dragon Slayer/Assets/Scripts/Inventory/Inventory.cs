using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public List<Image> Images;

    public List<Item> Items;

    private void Start()
    {
        
    }

    private void UpdateGUI()
    {
        int count = Images.Count;

        for (int i = 0; i < count; i++)
        {
            Images[i].enabled = false;

            Images[i].GetComponentInChildren<Text>().text = "";
        }
    }
}
