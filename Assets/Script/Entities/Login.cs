using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    public UserData userData;

    [SerializeField] private TMP_InputField InputID;
    [SerializeField] private TMP_InputField InputPW;
    [SerializeField] private GameObject InputWarningMessage;

    public void _Login()
    {
        string id = InputID.text;
        string password = InputPW.text;
        if (id == userData.id && password == userData.password)
        {
            SceneManager.LoadScene("Main Scene");
        }
        else
        {
            InputWarningMessage.SetActive(true);
        }
    }
}
