//double a = 0.1;
//double b = 0.2;
//Console.WriteLine(a + b == 0.3 ? "true" : "false");

//float c = 0.1F;//float phai co F
//decimal d = 0.2M;//decimal phai co M
//decimal e = 0.1M;
//Console.WriteLine(e+d == 0.3M ? "true" : "false");

//?: ==> ternary operator

string fullname = null;

//int i = null; ==> error vì kiểu số không thể null

//Nullable<int> i = null;

//c# moi
//bool? check = null;

//int length = fullname != null ? fullname.Length : 0;

//int? length = fullname is not null ? fullname.Length : 0;

/*var a = 10;
if(a is 10)
{
    Console.WriteLine(a);
}*/

//null-conditional operator '?'
//tương tự !=, fullname mà khác null thì trả về vế sau.
int? length = fullname?.Length;

//null-coalescing operator '??'
//tương tự như dấu ==, fullname bằng null trả về vế sau
int chieudai = fullname?.Length ?? 0;