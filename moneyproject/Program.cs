using moneyproject;

var money1 = new Money();
var money2 = new Money(1, 400, 0, Currency.USD);
var money3 = new Money(money2);
var money4 = new Money("-500.00");

Console.WriteLine(money1.DisplayAsString());
Console.WriteLine(money2.DisplayAsString());
Console.WriteLine(money3.DisplayAsString());
Console.WriteLine(money4.DisplayAsString());

money2.setSign(-1);
money2.setInteger(400);
money2.setFractional(99);
money2.setCurrency(Currency.EUR);


money2.addMoney(money4);
Console.WriteLine(money2.DisplayAsString());

money2.subtractMoney(money4);
Console.WriteLine(money2.DisplayAsString());

money4.addValue(1, 0, 00);
Console.WriteLine(money4.DisplayAsString());

money4.subtractValue(1, 500, 0);
Console.WriteLine(money4.DisplayAsString());

Console.WriteLine(money2.Equals(money3)); //should be false

Console.WriteLine(money4.CompareTo(money4)); // should be 0
Console.WriteLine(money4.CompareTo(money3)); //should be -1

var summedMoney = Money.add2Monies(money1, money2);
Console.WriteLine(summedMoney.DisplayAsString());

var diffedMoney = Money.subtract2Monies(money1, money2);
Console.WriteLine(summedMoney.DisplayAsString());

var money5 = new Money(1, 1, 0, Currency.USD);
money5.convertTo(Currency.RUB);
Console.WriteLine(money5.DisplayAsString());




