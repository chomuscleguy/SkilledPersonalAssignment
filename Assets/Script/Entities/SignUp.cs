using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class SignUp : MonoBehaviour
{
    
    [SerializeField] private UIManager uiManager;

    private void Start()
    {
        uiManager = GetComponent<UIManager>();
    }

    public void _SignUp()
    {
        string name = uiManager.GetName();
        string id = uiManager.GetID();
        string password = uiManager.GetPW();
        string confirm = uiManager.GetConfirm();

        string key = name + id;

        if (name.Length >= 2 && name.Length <= 5)
        {

            if (id.Length >= 3)
            {
                if (PlayerPrefs.HasKey(key))
                {
                    uiManager.SetCheckVaild("User ID is already in use");
                    uiManager.SignUpWarningBoxtrue();
                }
                else
                {
                    if (password.Length >= 5)
                    {
                        if (password == confirm)
                        {
                            PlayerPrefs.SetString(key, password);
                            PlayerPrefs.Save();
                            Debug.Log("회원가입 완료!");
                            uiManager.SignUpPopUpfalse();
                            uiManager.CompleteSignUpBoxtrue();
                            uiManager.Empty();
                        }
                        else
                        {
                            uiManager.SetCheckVaild("Passwords must match");
                            uiManager.SignUpWarningBoxtrue();
                        }
                    }
                    else
                    {
                        uiManager.SetCheckVaild("Please chceck PW");
                        uiManager.SignUpWarningBoxtrue();
                    }
                } 
            }
            else
            {
                Debug.Log("웨않되");
                uiManager.SetCheckVaild("Please chceck ID");
                uiManager.SignUpWarningBoxtrue();
            }
        }
        else
        {
            uiManager.SetCheckVaild("Please chceck Name");
            uiManager.SignUpWarningBoxtrue();
        }
    }
    public void Reset()
    {
        PlayerPrefs.DeleteAll();
    }
}
