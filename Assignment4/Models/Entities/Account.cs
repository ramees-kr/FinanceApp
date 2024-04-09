using System;
using System.Collections.Generic;

namespace Assignment4.Models.Entities;

public partial class Account
{
    public int AccountId { get; set; }

    public string AccountType { get; set; } = null!;

    public int UserId { get; set; }

    public double? CurrentBalance { get; set; }

    public DateTime? DateCreated { get; set; }

    // Method to return the account id
    public int GetAccountId()
    {
        return AccountId;
    }

    // Method to return Account details
    public string GetAccountDetails()
    {
        return $"Account Id: {AccountId}\nAccount Type: {AccountType}\nCurrent Balance: {CurrentBalance}";
    }
}
