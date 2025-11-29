using System;

class AccountTest
{
    static void Main()
    {
        Account myAccount = new Account();

        
        //Console.WriteLine($"Başlangıç ismi: '{myAccount.GetName()}'");
        //Console.WriteLine("İsim gir:");
        //string theName = Console.ReadLine();
        //myAccount.SetName(theName);

        //Console.WriteLine($"Ayarladıktan sonraki hesap adı: '{myAccount.GetName()}'");

        Account account1 = new Account("Hesap1");
        Account account2 = new Account("Hesap2");

        Console.WriteLine($"Hesap 1 ismi: '{account1.GetName()}'");
        Console.WriteLine($"Hesap 2 ismi: '{account2.GetName()}'"); 

        
    }
}
