using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User
{
    private string username;

    private string fullname;

    private string password;

    private string rootPassword;

    private string rootName = "root";

    public string Username { get => username; set => username = value; }
    public string Password { get => password; set => password = value; }
    public string RootPassword { get => rootPassword; set => rootPassword = value; }
    public string RootName { get => rootName; set => rootName = value; }
    public string Fullname { get => fullname; set => fullname = value; }
}
