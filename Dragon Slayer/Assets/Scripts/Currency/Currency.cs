using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Currency : MonoBehaviour
{
    public Text CreditBalanceIndicator;

    int pointsToAdd = 30;

    int CreditBalance;

    void Update()
    {
        // Noch Nicht fertig Offensichtlich

        CreditBalanceIndicator.text = CreditBalance.ToString();
    }
}
