using moneyproject;

var money1 = new Money();
var money2 = new Money(1,400,0,Currency.USD);
var money3 = new Money(money2);
var money4 = new Money("-500.00");

//Console.WriteLine(money1.DisplayAsString());
//Console.WriteLine(money2.DisplayAsString());
//Console.WriteLine(money3.DisplayAsString());
//Console.WriteLine(money4.DisplayAsString());

//money2.setSign(-1);
//money2.setInteger(400);
//money2.setFractional(99);
//money2.setCurrency(Currency.EUR);

money4.subtractMoney(money2);
Console.WriteLine(money4.DisplayAsString());



