using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandIfconfig : Command
{
    public override void Run(OS os, string args)
    {
        
        os.PrintText("root@debian: ~# ifconfig");
        os.PrintText("lo:    Link encap:Local Loopback");
        os.PrintText("       inet addr:127.0.0.1 Mask:255.0.0.0");
        os.PrintText("       inet6 addr: ::1/128 Scope:Host");
        os.PrintText("       UP LOOPBACK RUNNING MTU:16436 Metric:1");
        os.PrintText("       RX packets:0 errors:0 dropped:0 overruns:0 frame:0 ");
        os.PrintText("       TX packets:0 errors:0 dropped:0 overruns:0 carrier:0 collisions:0");
        os.PrintText("       RX bytes:0 (0.0 B) TX bytes:0 (0.0 B)");
        os.PrintText("");
        os.PrintText("eth1:  Link encap:Ethernet HWaddr de:0a:bd:d1:82:19");
        os.PrintText("       inet addr:192.168.0.5 Bcast:192.168.0.255 Mask:255.255.255.0");
        os.PrintText("       inet6 addr: fe80::dc0a:bdff:fed1:8219/64 Scope:Link");
        os.PrintText("       UP LOOPBACK RUNNING  MULTICAST MTU:1500 Metric:1");
        os.PrintText("       RX packets:15 errors:0 dropped:0 overruns:0 frame:0 ");
        os.PrintText("       TX packets:7 errors:0 dropped:0 overruns:0 carrier:0 collisions:0");
        os.PrintText("       RX bytes:1526 (1.4 KiB) TX bytes:1026 (1.0 KiB)");
    }
}
