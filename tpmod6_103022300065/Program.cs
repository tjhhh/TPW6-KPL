// See https://aka.ms/new-console-template for more information
using System;
using tpmod6_103022300065;

class Program
{
    static void Main(string[] args)
    {
        SayaTubeVideo video1 = new SayaTubeVideo("Tutorial Design By Contract - [MUHAMMAD FAUZAN]");
        video1.IncreasePlayCount();
        video1.IncreasePlayCount();
        video1.PrintVideoDetails();
    }
}
