using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginManager : MonoBehaviour
{
    private GameManager gameManager;

    [SerializeField] private GameObject LoginButton;
    [SerializeField] private GameObject SignUpButton;
    [SerializeField] private GameObject ButtonInSignUp;
    [SerializeField] private GameObject CancleButton;
    [SerializeField] private GameObject SignUpUI;
    [SerializeField] private GameObject InputWarningMessage;
    [SerializeField] private TMP_InputField InputID;
    [SerializeField] private TMP_InputField InputPW;
    [SerializeField] private TMP_InputField SignUpID;
    [SerializeField] private TMP_InputField SignUpPW;

    public void Cancle()
    {
        SignUpUI.SetActive(false);
    }
    public void SignUpPopUp()
    {
        SignUpUI.SetActive(true);
    }
    public void SignUp()
    {
        SignUpUI.SetActive(false);
    }

    public void Login()
    {
        if(InputID.text.Length < 3 || InputPW.text.Length < 5) 
        {
            InputWarningMessage.SetActive(true);
        }
        else
        {
            SceneManager.LoadScene("Main Scene");
        }  
    }

    public void WarningBox()
    {
        InputWarningMessage.SetActive(false);
    }
}

