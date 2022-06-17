using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Command_ls : Command
{
    public override void Run(OS os, string args)
    {
        os.PrintText("root@debian: ~# ls");
        os.PrintText("readme.txt");
    }
}
