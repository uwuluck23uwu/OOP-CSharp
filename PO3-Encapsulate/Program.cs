﻿using P03_Encapsulate;

var account = new BankAccount();
//BankAccount bankAccount = new BankAccount();

account.Id = 1;
account.Name = "Test";
account.Rate = 10;

account.SetPassword("1234");

var newAccount = new NewAccount();
newAccount.WithDraw(100);