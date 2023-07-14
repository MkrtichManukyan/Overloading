using Overloading;

var point1 = new Point(30, 40);
var point2 = new Point(10, 20);
var point3 = new And(true, false);
var point4 = new And(true, true);
var point5 = new And(true, true);
var point6 = new Or(false, false);
var point7 = new Or(false, false);
var point8 = new Or(true, false);

Console.WriteLine("-------CompareTo--------");

Console.WriteLine(point1 >= point2);
Console.WriteLine(point1 <= point2);

Console.WriteLine("-------And--------");

Console.WriteLine(point3 & point4);
Console.WriteLine(point4 & point5);

Console.WriteLine("-------Or--------");

Console.WriteLine(point6 | point7);
Console.WriteLine(point7 | point8);

Console.ReadKey();