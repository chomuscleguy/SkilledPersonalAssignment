using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class DepositManager : MonoBehaviour
{
    private GameMananger gameManager;
    [SerializeField] private GameObject _10000Amount;
    [SerializeField] private GameObject _100000Amount;
    [SerializeField] private GameObject _1000000Amount;
    [SerializeField] private GameObject InputAmount;
    [SerializeField] private GameObject WarningMessage;
    [SerializeField] private GameObject SufficientWarningMessage;
    [SerializeField] private TMP_InputField InputTxt;

    private int amount;
    private void Start()
    {
        gameManager = GameMananger.Instance;

    }
    public void DepositAmount()
    {
        int cashValue = int.Parse(gameManager.GetCashValue());
        int balanceValue = int.Parse(gameManager.GetBalanceValue());

        if (cashValue < amount)
        {
            SufficientWarningMessage.SetActive(true);
            amount = 0;
        }
        else
        {
            gameManager.SetCashValue(cashValue - amount);
            gameManager.SetBalanceValue(balanceValue + amount);
            amount = 0;
        }
    }

    public void Amount1()
    {
        //버튼 클릭시 amount가 정해짐
        amount = 10000;
        DepositAmount();
    }

    public void Amount2()
    {
        amount = 100000;
        DepositAmount();
    }

    public void Amount3()
    {
        amount = 1000000;
        DepositAmount();
    }

    public void Amount4()
    {
        bool isNum = int.TryParse(InputTxt.text, out _);
        
        if (isNum == true)
        {
            amount = int.Parse(InputTxt.text);
            if (amount > 0)
            {
                DepositAmount();
            }
            else
            {
                WarningMessage.SetActive(true);
            }
        }
        else
        {
            WarningMessage.SetActive(true);
        }
    }

    public void WarningBox()
    {
        WarningMessage.SetActive(false);
        Empty();
    }

    public void SufficientWarningBox()
    {
        SufficientWarningMessage.SetActive(false);
        Empty();
    }

    public void Empty()
    {
        InputTxt.text = "";
    }
}
