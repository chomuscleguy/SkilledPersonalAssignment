using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    private Login login;

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
        login = GetComponent<Login>();
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

    public void Init()
    {
        // 초기 세팅
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

    #region NameMethod
    public string GetName()
    {
        return Name.text;
    }

    public void SetName(string newName)
    {
        Name.text = newName;
    }
    #endregion


    public void Withdrawal()
    {
        WithdrawalUI.SetActive(true);
        MainUI.SetActive(false);
    }

    public void deposit()
    {
        DepositUI.SetActive(true);
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

    public void Text()
    {
        SceneManager.LoadScene("Start Scene");
    }
}
