using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private TextMeshProUGUI Cash;
    [SerializeField] private TextMeshProUGUI Balance;
    [SerializeField] private TextMeshProUGUI Name;

    public UserData userData;

    private void Awake()
    {

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
        SetCash(userData.cash);
        SetBalance(userData.balacne);
        SetName(userData.username);
    }

    string FormatNumber(int num)
    {
        return string.Format("{0:N0}", num);
    }

    public void SetCash(int newValue)
    {
        Cash.text = FormatNumber(newValue);
    }

    public void SetBalance(int newValue)
    {
        Balance.text = FormatNumber(newValue);
    }

    public void SetName(string newName)
    {
        Name.text = newName;
    }
}
