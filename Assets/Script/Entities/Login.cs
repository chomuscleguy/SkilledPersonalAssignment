using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Windows;

public class Login : MonoBehaviour
{
    public static string key;

    [SerializeField] private UIManager uiManager;
    private void Start()
    {
        uiManager = GetComponent<UIManager>();
    }
    public void _Login()
    {
        string name = uiManager.GetName();
        string id = uiManager.GetInputID();
        string password = uiManager.GetInputPW();

        key = name + id;

        // id�� Ű�� �ϴ� �����Ͱ� �����ϴ��� Ȯ��
        if (PlayerPrefs.HasKey(key))
        {
            string savedPassword = PlayerPrefs.GetString(key);

            // ����� password�� �Է��� password ��
            if (savedPassword == password)
            {
                Debug.Log("�α��� ����!");
                SceneManager.LoadScene("Main Scene");
            }
            else
            {
                Debug.Log("�߸��� ��й�ȣ�Դϴ�.");
                uiManager.LoginWarningBoxtrue();
            }
        }
        else
        {
            Debug.Log("�������� �ʴ� id�Դϴ�.");
            uiManager.LoginWarningBoxtrue();
        }
    }
}