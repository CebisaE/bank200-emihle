using System;

namespace Bank200
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the Current Account with initial balance
            CurrentAcct current = new CurrentAcct("Emihle", "Cebisa", 100.0m);

           // Check the balances
            // Expected output should be 1000 at this point
            Console.WriteLine($"Current balance is {current.Balance:C2}");

            // Print the account owner information. Expected output: 
            // "Current owner: Emihle Cebisa"
            Console.WriteLine($"Current owner: {current.AccountOwner}");

            // Deposit some money in each account
            current.Deposit(2000.0m);

            // Check the balances
            // Expected output should be 3000 at this point
            Console.WriteLine($"Current balance is {current.Balance:C2}");
      
	        // Make some withdrawals from account
            current.Withdraw(500.0m);

                 // Check the balances
            // Expected output should be  and 2500 at this point
            Console.WriteLine($"Current balance is {current.Balance:C2}");

             // try to overdraw Current - should result in extra charge
            current.Withdraw(3000.0m);

            // Expected output should be -2500 
            Console.WriteLine($"Current balance is {current.Balance:C2}");
             
            // Create the Savings Account with interest and initial balance
            SavingsAcct saving = new SavingsAcct("Emihle", "Cebisa", 0.100m, 1000.0m);

             // Check the balances
            // Expected output should be 1000 at this point
            Console.WriteLine($"Savings balance is {saving.Balance:C2}");

            // Print the account owner information. Expected output:  
            // "Savings owner: Emihle Cebisa"
            Console.WriteLine($"Savings owner: {saving.AccountOwner}");

             // Deposit some money in each account
            saving.Deposit(150.0m);

            // Check the balances
            // Expected output should be  1150 at this point
            Console.WriteLine($"Savings balance is {saving.Balance:C2}");

            // Make some withdrawals from each account
            saving.Withdraw(125.0m);

            // Check the balances
            // Expected output should be  and 1025 at this point
            Console.WriteLine($"Savings balance is {saving.Balance:C2}");

            // Apply the Savings interest
            saving.ApplyInterest();
            // Savings balance should now be 1050.63 
            Console.WriteLine($"Savings balance is {saving.Balance:C2}");

            // More than 3 Savings withdrawals should result in 2.00 charge
            saving.Withdraw(10.0m);
            saving.Withdraw(20.0m);
            saving.Withdraw(30.0m);
            // Savings balance should now be 988.63
            Console.WriteLine($"Savings balance is {saving.Balance:C2}");

            // try to overdraw savings - this should be denied and print message
            saving.Withdraw(2000.0m);

            // Expected output should be 988.63
            Console.WriteLine($"Savings balance is {saving.Balance:C2}");
        }
    }
}
