using moneyproject;

Money money = new Money("44.0");
Money money2 = new Money("43.32");


Console.WriteLine(money.DisplayAsString());
money.convertTo(Currency.RUB);
Console.WriteLine(money.DisplayAsString()); 


