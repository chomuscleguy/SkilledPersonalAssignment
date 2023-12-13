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

        // id을 키로 하는 데이터가 존재하는지 확인
        if (PlayerPrefs.HasKey(key))
        {
            string savedPassword = PlayerPrefs.GetString(key);

            // 저장된 password와 입력한 password 비교
            if (savedPassword == password)
            {
                Debug.Log("로그인 성공!");
                // 로그인 성공 시 추가적인 작업 수행
            }
            else
            {
                Debug.Log("잘못된 비밀번호입니다.");
            }
        }
        else
        {
            Debug.Log("존재하지 않는 id입니다.");
        }
    }
}
