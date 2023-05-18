using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MerchantShop : MonoBehaviour
{
    public GameObject shopPanel;

    private void Start()
    {
        shopPanel.active = false;
    }

    void Update()
    {

    }

    public void OpenShop()
    {
        shopPanel.active = true;
    }
}
