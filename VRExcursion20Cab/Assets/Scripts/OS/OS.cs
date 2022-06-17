using System.Collections;
using System.Collections.Generic;

using TMPro;

using UnityEngine;

public class OS : MonoBehaviour
{

    private User user;

    [SerializeField]
    private List<Command> commands;

    [SerializeField]
    private GameObject osUI;

    [SerializeField]
    private TMP_Text historyCommandText;

    [SerializeField]
    private MenuInstall menuInstall;

    [SerializeField]
    private NetworkCard networkCard;

    [SerializeField]
    private bool osInstalled;


    public TMP_Text HistoryCommandText { get => historyCommandText; }
    public bool OSInstalled { get => osInstalled; set => osInstalled = value; }
    public NetworkCard NetworkCard { get => networkCard; set => networkCard = value; }
    public List<Command> Commands { get => commands;}

    public void Run()
    {
        if (!menuInstall.installing)
        {
            if (OSInstalled)
            {
                osUI.SetActive(true);
            }
            else
            {
                menuInstall.Run();
            }
        }
    }

    public void SetUser(User user)
    {
        this.user = user;
    }

    public void PrintText(string text)
    {
        HistoryCommandText.text += "\n" + text;
    }

    public void TurnStateOS()
    {
        OSInstalled = true;
    }
}
