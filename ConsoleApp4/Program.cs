using System;
using System.Diagnostics;
using nnn;

namespace nnn
{
    class Program
    {
        static void Main(string[] args)
        {
            nnn_sevice nnns = new nnn_sevice();
            nnns.startProcess("taskmgr.exe");
        }
    }
}