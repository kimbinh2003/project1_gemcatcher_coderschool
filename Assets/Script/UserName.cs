using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UserName : MonoBehaviour
{
    public TextMeshProUGUI output;     // Hiển thị tên sau khi nhập
    public TMP_InputField userName;    // Trường để nhập tên
    public GameObject userNameButton;
    public GameObject outputButton;

    private const string UserNameKey = "UserName"; // Key for PlayerPrefs

    private void Start()
    {
        // Load the saved user name, if it exists
        if (PlayerPrefs.HasKey(UserNameKey))
        {
            output.text = PlayerPrefs.GetString(UserNameKey);
        }
        else
        {
            output.text = "User Name";
        }

        // Đăng ký sự kiện khi nhấn vào outputButton
        outputButton.GetComponent<Button>().onClick.AddListener(outputDisplay);

        // Đăng ký sự kiện khi nhấn Enter trong TMP_InputField
        userName.onEndEdit.AddListener(delegate { SaveUserName(); });
    }

    public void outputDisplay()
    {
        output.gameObject.SetActive(false);  
        userNameButton.SetActive(true);     
        userName.Select();   
    }

    public void userNameDisplay()
    {
        userNameButton.SetActive(false);     
        outputButton.SetActive(true);         
        output.gameObject.SetActive(true);    
    }

    public void SaveUserName()
    {
        if (!string.IsNullOrEmpty(userName.text))
        {
            output.text = userName.text;    
            PlayerPrefs.SetString(UserNameKey, userName.text); 
            PlayerPrefs.Save(); 
        }
        else
        {
            output.text = "User Name"; 
        }

        userNameDisplay();  
    }
}
