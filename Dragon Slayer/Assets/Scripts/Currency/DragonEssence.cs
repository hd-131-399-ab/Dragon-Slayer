using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragonEssence : MonoBehaviour
{
    public Text CreditBalanceIndicator;

    int CreditBalance;

    void Update()
    {
        // Noch nicht fertig offensichtlich

        CreditBalanceIndicator.text = CreditBalance.ToString();
    }
}
