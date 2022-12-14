using RefOut;
using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;
/*
int a = 10;
int b = 5;*/
int a;
int b;
//ref a = a ; b = b
//bỏ ref a = b; b = a
/*newrefout.ChangeNumber(ref a,ref b);
Console.WriteLine($"Program : {nameof(a)}={a},{nameof(b)}={b}");*/
newrefout.ChangeNumber(out a, out b);
Console.WriteLine($"Program : {nameof(a)}={a},{nameof(b)}={b}");

