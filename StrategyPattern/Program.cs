// See https://aka.ms/new-console-template for more information


using StrategyPattern;

Calculator calculatrice = new Calculator(new AdditionStrategy());

int res1 = calculatrice.DoOperation(1, 2);
Console.WriteLine($"resultat de l'op : {res1}");

calculatrice.SetStrategy(new SubstractStrategy());
res1 = calculatrice.DoOperation(1, 4);

Console.WriteLine($"resultat de l'op : {res1}");
