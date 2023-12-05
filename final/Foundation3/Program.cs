using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture CSE210 = new Lecture();
        Reception _wedding = new Reception();
        OutdoorGathering sport = new OutdoorGathering();

        CSE210.FullDetails();
        CSE210.StandardDetails();
        CSE210.ShortDetails();
    }
}