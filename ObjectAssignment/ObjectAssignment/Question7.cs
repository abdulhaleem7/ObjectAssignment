using ObjectAssignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ObjectAssignment
{
    public class Cat
    {
        public string Name;
       
      
        public Cat(string name)
        {
            Name = name;
        }
        public static string sayMiau()
        {
            return (": Miauu");
        }
    }
    public class Sequence
    {

        public static int currentValue = 0;
        public Sequence()
        {

        }
        public static int NextValue()
        {
            currentValue++; ;
            return currentValue;
        }
    }
}
namespace ObjectAssignment
{
      public class Calling
      {
        Cat cat = new Cat("stunt");
        Sequence Sequence = new Sequence();

      } 
}


