using System.Collections;
using System.Collections.Generic;

using TMPro;

using UnityEngine;

public class Console : MonoBehaviour
{
    [SerializeField]
    private TMP_Text history;

    [SerializeField]
    private TMP_InputField inputCommand;

    [SerializeField]
    private GameObject osUI;

    [SerializeField]
    private OS os;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            osUI.SetActive(false);
        }

        if (osUI.activeSelf && Input.GetKeyDown(KeyCode.Return) && inputCommand.text != string.Empty)
        {
            RunCommand();
        }
    }

    public void RunCommand()
    {
        foreach (var command in os.Commands)
        {
            if (inputCommand.text == command.Name || inputCommand.text.Split(" ")[0] == command.Name)
            {
                command.Run(os, inputCommand.text);
            }
        }
        inputCommand.text = string.Empty;
    }
}
