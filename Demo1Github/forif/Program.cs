
using System.Collections;
using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

string[] arrs = { "1", "2", "3", "4", "5" };

foreach(var t in arrs)
{
    Console.WriteLine($"{nameof(t)} có chiều dài {t.Length}");
    Console.WriteLine( t );
}

/*int i = 0;
while (i < arrs.Length)
{
    Console.WriteLine($"{arrs[i]} có chiều dài {arrs[i].Length}");
    Console.Write(arrs[i]);
    i++;
}

IEnumerator e= arrs.GetEnumerator();
while (e.MoveNext())
{
    string s = (string)e.Current;
    Console.WriteLine($"{s} có chiều dài {s.Length}");
}*/