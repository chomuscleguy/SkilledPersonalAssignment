using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class Deposit : MonoBehaviour
{
    private GameManager gameManager;
    [SerializeField] private GameObject SufficientWarningMessage;
    [SerializeField] private TMP_InputField InputTxt;

    public UserData userData;
    private void Start()
    {
        gameManager = GameManager.Instance;
    }
    public void DepositAmount(int amount)
    {
        if (userData.cash < amount)
        {
            SufficientWarningMessage.SetActive(true);
        }
        else
        {
            userData.cash -= amount;
            userData.balacne += amount;
            gameManager.SetCash(userData.cash);
            gameManager.SetBalance(userData.balacne);
        }
    }

    public void DepositInput()
    {
        if (InputTxt.text != "")
        {
            DepositAmount(int.Parse(InputTxt.text));
        }
    }

    public void Empty()
    {
        InputTxt.text = "";
    }
}
