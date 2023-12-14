using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Burst.CompilerServices;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class Withdrawal : MonoBehaviour
{
    private GameManager gameManager;
    [SerializeField] private GameObject SufficientWarningMessage;
    [SerializeField] private TMP_InputField InputTxt;

    public UserData userData;

    private void Start()
    {
        gameManager = GameManager.Instance;
    }
    public void WithdrawalAmount(int amount)
    {
        if (userData.balacne < amount)
        {
            SufficientWarningMessage.SetActive(true);
        }
        else
        {
            userData.cash += amount;
            userData.balacne -= amount;
            gameManager.SetCash(userData.cash);
            gameManager.SetBalance(userData.balacne);
        }
    }

    public void WithdrawalInput()
    {
        if (InputTxt.text != "")
        {
            WithdrawalAmount(int.Parse(InputTxt.text));
        }
    }


    public void Empty()
    {
        InputTxt.text = "";
    }
}
