using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MenuInstall : MonoBehaviour
{
    [SerializeField]
    private GameObject rootPages;

    [SerializeField]
    private List<GameObject> pages;

    [SerializeField]
    private TMP_InputField passwordField;

    [SerializeField]
    private TMP_InputField usernameField;

    [SerializeField]
    private TMP_InputField rootPasswordField;

    [SerializeField]
    private TMP_InputField fullnameField;

    [SerializeField]
    private GameObject activePage;

    private int activePageId;

    [SerializeField]
    private OS os;

    public bool installing = false;

    public void Run()
    {
        rootPages.SetActive(true);
        installing = true;
    }

    public void Next()
    {
        activePageId++;
        if (activePageId >= pages.Count)
        {
            activePage.SetActive(false);
            installing = false;
            os.OSInstalled = true;
            os.Run();

            return;
        }

        activePage.SetActive(false); 
        pages[activePageId].SetActive(true);
        activePage = pages[activePageId];
    }

    public void CreateUser()
    {
        User user = new User();
        user.Username = usernameField.text;
        user.Password = passwordField.text;
        user.RootPassword = rootPasswordField.text;
        user.Fullname = fullnameField.text;
        os.SetUser(user);
        
    }

}
