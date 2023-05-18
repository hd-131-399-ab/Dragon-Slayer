using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public int ID;
    public string Name;

    public Item(int iD, string name)
    {
        ID = iD;
        Name = name;
    }
}
