using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInterfaceModifier
{
    public class ConstructorExample
    {
        public string Name { get; set; }
        public int EmployeeId { get; set; }

        // Parameterized constructor
        public ConstructorExample(string name, int employeeId)
        {
            Name = name;
            EmployeeId = employeeId;
        }

        // Another constructor overloading
        public ConstructorExample(string name)
        {
            Name = name;
            EmployeeId = -1; // Set a default value
        }
    }
}
