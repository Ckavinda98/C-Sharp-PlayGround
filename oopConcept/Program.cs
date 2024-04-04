using oopConcept;

BankAccount account = new BankAccount("Mical Mical", 50000);
BankAccount account2 = new BankAccount("Kevin Kevin", 70000);


account.MakeDeposit(80000, DateTime.Now, "Lottery Price");
account.MakeDeposit(90000, DateTime.Now, "Tranfering from anther bank");
account.MakeDeposit(60000, DateTime.Now, "Deposit from Salary");
account.MakeWithdraw(25000, DateTime.Now, "For Rent A Car");

Console.WriteLine("Your Account Summery");
Console.WriteLine("----------------------------------------------");
Console.WriteLine(account.GetAccountHistory());


Console.WriteLine($"Your Current Balance is : {account.Balance}");


