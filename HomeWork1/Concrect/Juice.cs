using HW1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1.Concrect
{
    internal class Juice :IProduct
    {
        public void Produced()
        {
            Console.WriteLine("Juice Produced!");
        }
    }



}
