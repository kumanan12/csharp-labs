using System;

namespace bank
{
    public string Number { get; }
    public string Owner { get; set; }
    public decimal Balance { get; }
    
    //CONSTRUCTOR

    public Bank(string name,decimal initialBalance)
    {
        this.Owner = name;
        this.Balance = initialBalance;
    }

    public void Deposit(decimal amount,DateTime date,string note)
    {

    }

    public void Withdraw(decimal amount, DateTime date,string note)
    {

    }
    

}
