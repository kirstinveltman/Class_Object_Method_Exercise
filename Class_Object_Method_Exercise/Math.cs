using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object_Method_Exercise
{
    public class Math
    {
        public int Number { get; set; }


        public int Multiply(int num)
        {
            return num * Number;
        }

        public int Subtract(int num)
        {
            return num - Number;
        }

        public int Add(int num)
        {
            return num + Number;
        }

        public Math()
        {
            Number = 0;
        }

    }
}
