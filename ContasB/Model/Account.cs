using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasB.Model
{
    public abstract class Account
    {
        public int Id { get; set; }
        public double Balance { get; set; }
        public int UserId { get; set; }
        public required User User { get; set; }


        public abstract void Deposit(double value);
        public abstract void Withdraw(double value);   

    }
}


