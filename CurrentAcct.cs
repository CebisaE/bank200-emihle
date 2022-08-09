using System;

namespace Bank200
{
    public class CurrentAcct : BankAccount {
        private const decimal OVERDRAFT_CHARGE = 3000.0m;


        public CurrentAcct(string fname, string lname, decimal initial) 
            : base (fname, lname, initial) {
        }

        public override void Withdraw(decimal amount) {
            // if the account gets overdrawn add minus from overdraft
            if (amount > Balance) {
                amount -= OVERDRAFT_CHARGE;
            }
            base.Withdraw(amount);
        }
    }
}
