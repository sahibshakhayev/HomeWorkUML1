using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1.Abstract
{
    abstract class FoodProduction
    {
        public void Produced()
        {
            Console.WriteLine("Factory Production!");

        }
        public abstract IProduct CreateProduct();
    }
}
