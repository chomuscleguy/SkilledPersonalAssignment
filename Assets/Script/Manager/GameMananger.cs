using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class GameMananger : MonoBehaviour
{
    public static GameMananger Instance;

    [SerializeField] private TextMeshProUGUI Cash;
    [SerializeField] private TextMeshProUGUI Balance;
    [SerializeField] private TextMeshProUGUI Name;
    [SerializeField] private GameObject WithdrawalUI;
    [SerializeField] private GameObject MainUI;
    [SerializeField] private GameObject DepositUI;

    private DepositManager depositManager;
    private WithdrawalManager withdrawalManager;
    private void Awake()
    {
        depositManager = FindObjectOfType<DepositManager>();
        withdrawalManager = FindObjectOfType<WithdrawalManager>();

        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        SetCashValue(100000);
        SetBalanceValue(50000);
    }

    #region CashMethod
    public string GetCashValue()
    {
        return Cash.text;
    }

    public void SetCashValue(int newValue)
    {
        Cash.text = newValue.ToString();
    }
    #endregion

    #region BalanceMethod
    public string GetBalanceValue()
    {
        return Balance.text;
    }

    public void SetBalanceValue(int newValue)
    {
        Balance.text = newValue.ToString();
    }
    #endregion


    public void Deposit(int amount)
    {
        int currentCash = int.Parse(Cash.text);
        int newCash = currentCash + amount;

        Cash.text = newCash.ToString();
    }



    public void Withdrawal()
    {
        WithdrawalUI.SetActive(true);
        MainUI.SetActive(false);
    }
    public void Exit()
    {
        DepositUI.SetActive(false);
        WithdrawalUI.SetActive(false);
        MainUI.SetActive(true);
        depositManager.Empty();
        withdrawalManager.Empty();

    }
    public void deposit()
    {
        DepositUI.SetActive(true);
        MainUI.SetActive(false);
    }
}
