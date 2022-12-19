using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopEncapsulationProperty;
internal class Human
{
    //fields các field phải là private
    private string fullname;
    //thuộc tính address(muốn set k get thì thêm private vào get)
    public string Address { get; set; }
    public int Age { get; set; }

    //các phương thức getter, setter (cách cho mobie)
    
    public string Fullname {
        set => fullname = value; 
        
        get => fullname;
        
    }

    public void ShowPeopel()
    {
        Console.WriteLine($"{nameof(Address)}={Address}");
        Console.WriteLine($"{nameof(fullname)}={fullname}");
    }
}
