using System;

class Program
{
    static void Main()
    {

        string company = (Console.ReadLine());
        string address = (Console.ReadLine());
        string phone = (Console.ReadLine()); ;
        string fax = (Console.ReadLine());
        if (fax == "")
        {
            fax = "(no fax)";
        }

        string site = (Console.ReadLine());
        string firstname = (Console.ReadLine());
        string lastname = (Console.ReadLine());
        string age = (Console.ReadLine());
        string number = (Console.ReadLine());


        Console.WriteLine(company);
        Console.WriteLine("Address: {0}", address);

        Console.WriteLine("Tel. {0}", phone);
        Console.WriteLine("Fax: {0}", fax);
        Console.WriteLine("Web site: {0}", site);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", firstname, lastname, age, number);


    }
}
