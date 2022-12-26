using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp10;
public class Employee
{
    public void EmployeeDetails()
    {
        var names = new[] { "Nick", "John", "Mike", "Peter" };
        var serialized = JsonSerializer.Serialize(names);
        Console.WriteLine(serialized);
        Console.ReadKey();
    }
}
