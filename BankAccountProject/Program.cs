using BankAccountProject;

Account account1 = new Account(50.00M);
Account account2 = new Account(-7.53M);

//Display initial balance of each object using a property.
Console.WriteLine("account1 balance: {0:C}", account1.Balance);//Display Balance property
Console.WriteLine("account2 balance: {0:C}", account2.Balance);//Display Balance property

decimal depositAmount;//deposit amount read from user

//Prompt and obtain user input
Console.Write("Enter deposit amount for account1: ");
depositAmount = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Adding {0:C} to account1 balance\n", depositAmount);
account1.Credit(depositAmount); //Add to account1 balance

//Display balances
Console.WriteLine("account1 balance: {0:C}", account1.Balance);
Console.WriteLine("account2 balance: {0:C}", account2.Balance);

//Prompt and obtain user input (Account 2
Console.Write("Enter deposit amount for account2: ");
depositAmount = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Adding {0:C} to account2 balance\n", depositAmount);
account2.Credit(depositAmount); //Add to account2 balance

//Display balances
Console.WriteLine("account1 balance: {0:C}", account1.Balance);
Console.WriteLine("account2 balance: {0:C}", account2.Balance);