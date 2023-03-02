SavingsAccount newAccount = new SavingsAccount("Daana", 75000);
// newAccount.customerName = "Ser";

Console.WriteLine(newAccount.customerName + "'s starting balance is $" + newAccount.getBalance() );

// he added 100 more
newAccount.deposit(-100);

Console.WriteLine(newAccount.customerName + "'s now balance is $" + newAccount.getBalance() );
