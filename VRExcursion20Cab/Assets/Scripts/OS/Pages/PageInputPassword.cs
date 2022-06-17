using System.Collections;
using System.Collections.Generic;

using TMPro;

using UnityEngine;
using UnityEngine.Events;

public class PageInputPassword : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField password;

    [SerializeField]
    private TMP_InputField reenterPassword;

    [SerializeField]
    private UnityEvent onInputCorrectPassword;

    public void TryNext()
    {
        
        if(password.text == reenterPassword.text)
        {
            onInputCorrectPassword.Invoke();
        }
    }
}
