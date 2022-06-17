using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Command_cat : Command
{
    public override void Run(OS os, string args)
    {
        os.PrintText($"root@debian: ~# {args}");
        string[] arguments = args.Split(" ");
        if (arguments.Length < 2)
        {
            os.PrintText("cat: No such file or directory");
        }
        else
        {
            if (arguments[1] == "readme.txt")
            {
                 os.PrintText("Server IP: 192.168.0.6");
            }
        }

    }
}
