using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Collections.LowLevel.Unsafe;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    private GameManager gameManager;
    private SignUp signUp;
    private Login login;

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

    private void Start()
    {
        signUp = GetComponent<SignUp>();
        login = GetComponent<Login>();
    }

    public void Cancle()
    {
        SignUpUI.SetActive(false);
        Empty();
    }
    public void SignUpPopUptrue()
    {
        SignUpUI.SetActive(true);
    }
    public void SignUpPopUpfalse()
    {
        SignUpUI.SetActive(false);
    }
    public void CompleteSignUpBoxtrue()
    {
        CompleteSignUp.SetActive(true);
    }
    public void CompleteSignUpBoxfasle()
    {
        CompleteSignUp.SetActive(false);
    }

    public void LoginWarningBoxtrue()
    {
        InputWarningMessage.SetActive(true);
    }
    public void LoginWarningBoxfalse()
    {
        InputWarningMessage.SetActive(false);
    }

    public void SignUpWarningBoxfalse()
    {
        SignUpWarningMessage.SetActive(false);
    }
    public void SignUpWarningBoxtrue()
    {
        SignUpWarningMessage.SetActive(true);
    }

    public void Empty()
    {
        SignUpID.text = "";
        SignUpPW.text = "";
        ConfirmPW.text = "";
        Name.text = "";
    }

    #region NameMethod
    public string GetName()
    {
        return Name.text;
    }
    #endregion

    #region IDMethod
    public string GetID()
    {
        return SignUpID.text;
    }

    #endregion

    #region PasswordMethod
    public string GetPW()
    {
        return SignUpPW.text;
    }

    #endregion

    #region ConfirmMethod
    public string GetConfirm()
    {
        return ConfirmPW.text;
    }

    #endregion

    #region CheckVaildMethod
    public string GetCheckVaild()
    {
        return CheckVaild.text;
    }

    public void SetCheckVaild(string text)
    {
        CheckVaild.text = text;
    }
    #endregion

    #region InputIDMethod
    public string GetInputID()
    {
        return InputID.text;
    }

    #endregion

    #region InputPasswordMethod
    public string GetInputPW()
    {
        return InputPW.text;
    }

    #endregion
}


