using System;

class Program
{
    static void Main(string[] args)
    {

        Address address = new Address("3438 Dayton-Xenia Rd", "Beavercreek", "OH", "USA");
        Lecture CSE210 = new Lecture("CSE 210", "Programming with Classes", "9/12/2023 - 12/11/2023", "9 - 10 A.M. Mountain Time", address, 500, "President Russell M. Nelson", 200);
        Reception wedding = new Reception("Samuels Wedding", "Samuel and Jennifer Kissing in a tree...", "March...ish 2012", "10 A.M.", address);
        OutdoorGathering sport = new OutdoorGathering("Sports", "Youth Activity", "12/13/2023", "6 P.M.", address);
        
        System.Console.WriteLine("CSE 210 Full");
        CSE210.FullDetails();
        System.Console.WriteLine("CSE 210 Standard");
        CSE210.StandardDetails();
        System.Console.WriteLine("CSE 210 Short");
        CSE210.ShortDetails();
        
        System.Console.WriteLine("Wedding Full");
        wedding.FullDetails();
        System.Console.WriteLine("Wedding Standard");
        wedding.StandardDetails();
        System.Console.WriteLine("Wedding Short");
        wedding.ShortDetails();
        
        System.Console.WriteLine("Sport Full");
        sport.FullDetails();
        System.Console.WriteLine("Sport Standard");
        sport.StandardDetails();
        System.Console.WriteLine("Sport Short");
        sport.ShortDetails();
    }
}