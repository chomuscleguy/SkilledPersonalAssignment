using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class WithdrawalManager : MonoBehaviour
{
    private GameMananger gameManager;
    [SerializeField] private GameObject _10000Amount;
    [SerializeField] private GameObject _100000Amount;
    [SerializeField] private GameObject _1000000Amount;
    [SerializeField] private GameObject InputAmount;
    [SerializeField] private GameObject WarningMessage;
    [SerializeField] private TMP_InputField InputTxt;

    private int amount;
    private void Start()
    {
        gameManager = GameMananger.Instance;
    }
    public void WithdrawalAmount()
    {

        int cashValue = int.Parse(gameManager.GetCashValue());
        int balanceValue = int.Parse(gameManager.GetBalanceValue());



        if (balanceValue < amount)
        {
            Debug.Log("잔액이 부족합니다.");
            amount = 0;
        }
        else
        {
            gameManager.SetCashValue(cashValue + amount);
            gameManager.SetBalanceValue(balanceValue - amount);
            amount = 0;
        }
    }

    public void Amount1()
    {
        //버튼 클릭시 amount가 정해짐
        amount = 10000;
        WithdrawalAmount();
    }

    public void Amount2()
    {
        amount = 100000;
        WithdrawalAmount();
    }

    public void Amount3()
    {
        amount = 1000000;
        WithdrawalAmount();
    }

    public void Amount4()
    {
        bool isNum = int.TryParse(InputTxt.text, out _);
        if (isNum == true)
        {
            amount = int.Parse(InputTxt.text);
            WithdrawalAmount();
        }
        else
        {
            WarningMessage.SetActive(true);
        }
    }

    public void WarningBox()
    {
        WarningMessage.SetActive(false);
    }
    
}
