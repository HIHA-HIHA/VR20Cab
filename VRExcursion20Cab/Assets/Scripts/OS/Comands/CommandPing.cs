using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class CommandPing : Command
{
    public override void Run(OS os, string args)
    {
        os.PrintText($"root@debian: ~# {args}");
        string[] arguments = args.Split(" ");
        if (arguments.Length < 2)
        {
            os.PrintText("ping: usage error: Destination address required");
        }
        else
        {
            if(os.NetworkCard.Router.GetNetworkCard(arguments[1]) != null)
            {
                os.PrintText($"PING {arguments[1]} 56(84) bytes of data.");
                os.PrintText($"64 bytes from {arguments[1]}: icmp_seq=1 ttl=64 time={Random.Range(0, 0.5f)}");
                os.PrintText($"64 bytes from {arguments[1]}: icmp_seq=1 ttl=64 time={Random.Range(0, 0.5f)}");
                os.PrintText($"64 bytes from {arguments[1]}: icmp_seq=1 ttl=64 time={Random.Range(0, 0.5f)}");
            }
        }

    }
}
