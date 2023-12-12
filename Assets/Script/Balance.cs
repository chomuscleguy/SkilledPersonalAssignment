using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balance : MonoBehaviour
{
    private int balance = 50000;
    private int deposit = 0;
    private int cash = 0;
    private int withdrawal = 0;

    private void Withdrawal()
    {
        cash += withdrawal;
        balance -= withdrawal;
    }

    private void Deposit()
    {
        cash -= deposit;
        balance += deposit;
    }
}
