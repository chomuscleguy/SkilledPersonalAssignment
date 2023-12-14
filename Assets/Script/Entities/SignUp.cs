using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using TMPro;
using UnityEngine;

public class SignUp : MonoBehaviour
{

    public UserData userData;

    [SerializeField] private TMP_InputField SignUpID;
    [SerializeField] private TMP_InputField SignUpPW;
    [SerializeField] private TMP_InputField ConfirmPW;
    [SerializeField] private TMP_InputField Name;
    [SerializeField] private TextMeshProUGUI CheckVaild;
    [SerializeField] private GameObject SignUpWarningMessage;
    [SerializeField] private GameObject CompleteSignUp;

    public void _SignUp()
    {
        string id = SignUpID.text;
        string password = SignUpPW.text;
        string name = Name.text;
        string cofirm = ConfirmPW.text;
        if (SignUpID.text.Length >= 3)
        {
            if (id == userData.id)
            {
                CheckVaild.text = "User ID is already in use";
                SignUpWarningMessage.SetActive(true);
            }
            else
            {
                if (password.Length >= 5)
                {
                    if (password == cofirm)
                    {
                        RegisterUser(id, password, name);
                        Debug.Log("회원가입 완료!");
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
        }
        else
        {
            Debug.Log("웨않되");
            CheckVaild.text = "Please chceck ID";
            SignUpWarningMessage.SetActive(true);
        }
    }
    public void Empty()
    {
        SignUpID.text = "";
        SignUpPW.text = "";
        ConfirmPW.text = "";
        Name.text = "";
    }
    
    
    public void RegisterUser(string id, string password, string name)
    {
        userData.id = id;
        userData.password = password;
        userData.username = name;
    }
}
