using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Login : MonoBehaviour
{
    [SerializeField] private UIManager uiManager;
    private void Start()
    {
        uiManager = GetComponent<UIManager>();
    }
    public void _Login()
    {
        string name = uiManager.GetName();
        string id = uiManager.GetID();
        string password = uiManager.GetPW();

        string key = "UserData" + id;

        // id�� Ű�� �ϴ� �����Ͱ� �����ϴ��� Ȯ��
        if (PlayerPrefs.HasKey(key))
        {
            string savedPassword = PlayerPrefs.GetString(key);

            // ����� password�� �Է��� password ��
            if (savedPassword == password)
            {
                Debug.Log("�α��� ����!");
                // �α��� ���� �� �߰����� �۾� ����
            }
            else
            {
                Debug.Log("�߸��� ��й�ȣ�Դϴ�.");
            }
        }
        else
        {
            Debug.Log("�������� �ʴ� id�Դϴ�.");
        }
    }
}
