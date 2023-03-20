
using System.Text;

string msg = "тип {0,8} |\t.NET {1,8} |\tРазмер = {2} \t| MIN = {3,30}\t| MAX = {4}";

Console.Title = "Типы данных в C#";

Console.WriteLine(string.Format(msg, "byte", typeof(byte).Name, sizeof(byte), byte.MinValue, byte.MaxValue));
Console.WriteLine(string.Format(msg, "sbyte", typeof(sbyte).Name, sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue));
Console.WriteLine(string.Format(msg, "short", typeof(short).Name, sizeof(short), short.MinValue, short.MaxValue));
Console.WriteLine(string.Format(msg, "ushort", typeof(ushort).Name, sizeof(ushort), ushort.MinValue, ushort.MaxValue));
Console.WriteLine(string.Format(msg, "int", typeof(int).Name, sizeof(int), int.MinValue, int.MaxValue));
Console.WriteLine(string.Format(msg, "uint", typeof(uint).Name, sizeof(uint), uint.MinValue, uint.MaxValue));
Console.WriteLine(string.Format(msg, "long", typeof(long).Name, sizeof(long), long.MinValue, long.MaxValue));
Console.WriteLine(string.Format(msg, "ulong", typeof(ulong).Name, sizeof(ulong), ulong.MinValue, ulong.MaxValue));
Console.WriteLine(string.Format(msg, "float", typeof(float).Name, sizeof(float), float.MinValue, float.MaxValue));
Console.WriteLine(string.Format(msg, "double", typeof(double).Name, sizeof(double), double.MinValue, double.MaxValue));
Console.WriteLine(string.Format(msg, "decimal", typeof(decimal).Name, sizeof(decimal), decimal.MinValue, decimal.MaxValue));
Console.WriteLine(string.Format(msg, "char", typeof(char).Name, sizeof(char), char.MinValue, char.MaxValue));
Console.WriteLine(string.Format(msg, "bool", typeof(bool).Name, sizeof(bool), bool.FalseString, bool.TrueString));
Console.WriteLine(string.Format(msg, "object", typeof(object).Name, "-", "-", "-"));

Console.WriteLine("\t\nНажмите Enter для продолжения...");
Console.ReadKey();
Console.Clear();

string str = "Объект – категория, выражающая то, что противостоит субъекту в его предметно-практической и познавательной деятельности.";
Console.WriteLine($" ASCII {Encoding.ASCII.GetByteCount(str)}");
Console.WriteLine($" UTF-7 {Encoding.UTF7.GetByteCount(str)}");
Console.WriteLine($" UTF-8 {Encoding.UTF8.GetByteCount(str)}");
Console.WriteLine($" UTF-16 {Encoding.UTF32.GetByteCount(str)}");

Console.WriteLine("\t\nНажмите Enter для завершения...");


Console.ReadKey();

