﻿//Json
Dictionary<string,string> Country = new Dictionary<string,string>();
Dictionary<int,double> UnitOfMoney = new Dictionary<int,double>();

Country.Add("Kan", "Kanchanaburi");
Country.Add("CM","ChaiengMai");
Country.Add("BKK","BangKok");
UnitOfMoney.Add(1, 1_000_000);
UnitOfMoney.Add(2, 2_000_000);
UnitOfMoney.Add(3, 3_000_000);
UnitOfMoney.Add(4, 4_000_000);
UnitOfMoney.Add(5, 5_000_000);

if (Country.ContainsKey("Kan")) Console.WriteLine(Country["Kan"]);

foreach (var item in UnitOfMoney)
{
    Console.WriteLine($"{item.Key} {item.Value}");
}

var total = UnitOfMoney[1] + UnitOfMoney[2];
UnitOfMoney.Sum(p => p.Value);