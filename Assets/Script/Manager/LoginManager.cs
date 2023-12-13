using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Collections.LowLevel.Unsafe;
using UnityEditor.Experimental.GraphView;
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
    [SerializeField] private GameObject SignUpWarningMessage;
    [SerializeField] private GameObject CompleteSignUp;
    [SerializeField] private TextMeshProUGUI CheckVaild;
    [SerializeField] private TMP_InputField InputID;
    [SerializeField] private TMP_InputField InputPW;
    [SerializeField] private TMP_InputField SignUpID;
    [SerializeField] private TMP_InputField SignUpPW;
    [SerializeField] private TMP_InputField ConfirmPW;
    [SerializeField] private TMP_InputField Name; 

    public void Cancle()
    {
        SignUpUI.SetActive(false);
        Empty();
    }
    public void SignUpPopUp()
    {
        SignUpUI.SetActive(true);
    }
    public void Login()
    {
        if (InputID.text.Length < 3 || InputPW.text.Length < 5)
        {
            InputWarningMessage.SetActive(true);
        }
        else
        {
            SceneManager.LoadScene("Main Scene");
        }
    }

    public void LoginWarningBox()
    {
        InputWarningMessage.SetActive(false);
    }
    public void SignUpWarningBox()
    {
        SignUpWarningMessage.SetActive(false);
    }

    public void CompleteSignUpBox()
    {
        CompleteSignUp.SetActive(false);
    }

    public void Empty()
    {
        SignUpID.text = "";
        SignUpPW.text = "";
        ConfirmPW.text = "";
        Name.text = "";
    }
    public void SignUp()
{
        if (Name.text.Length >= 2 && Name.text.Length <=5)
        {
            if (SignUpID.text.Length >= 3)
            {
                if (SignUpPW.text.Length >= 5)
                {

                    if (SignUpPW.text == ConfirmPW.text)
                    {
                        //사인업 만들어야함
                        SignUpUI.SetActive(false);
                        CompleteSignUp.SetActive(true);
                        Empty();
                    }
                    else
                    {
                        CheckVaild.text = "Passwords must match";
                        SignUpWarningMessage.SetActive(true);
                    }
                }
                else
                {
                    CheckVaild.text = "Please chceck PW";
                    SignUpWarningMessage.SetActive(true);
                }
            }
            else
            {
                CheckVaild.text = "Please chceck ID";
                SignUpWarningMessage.SetActive(true);
            }
        }
        else
        {
            CheckVaild.text = "Please chceck Name";
            SignUpWarningMessage.SetActive(true);
        }
    }
}


