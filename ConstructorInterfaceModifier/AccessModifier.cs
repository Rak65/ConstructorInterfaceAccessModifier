using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInterfaceModifier
{
    //The public access modifier allows members to be accessed from anywhere within the same
    //assembly or a different assembly.
    public class AccessModifier
    {
        public int PublicField;
        public void PublicMethod()
        {
            Console.WriteLine("Public Class.");
        }
    }
    //The private access modifier restricts access to members within the same class or struct.
    public class MyClass
    {
        private int PrivateField=5;
        private void PrivateMethod()
        {
            Console.WriteLine("Private Access Modifier"+PrivateField);
        }
    }
    //The protected access modifier allows access within the same class or derived classes.
    public class MyBaseClass
    {
        protected int ProtectedField;
        protected void ProtectedMethod()
        {
            Console.WriteLine("");
        }
    }

    public class DerivedClass : MyBaseClass
    {
        public void AccessProtectedMember()
        {
            ProtectedField = 10; // Accessible in derived class
            ProtectedMethod();   // Accessible in derived class
        }
    }
    //The internal access modifier allows access within the same assembly but restricts access from outside the assembly.
    internal class InternalClass
    {
        internal int InternalField;
        internal void InternalMethod()
        {
            Console.WriteLine("Internal");
        }
    }



}
