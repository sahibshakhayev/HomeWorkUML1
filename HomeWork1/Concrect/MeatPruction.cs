using HW1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1.Concrect
{
    internal class MeatPruction : FoodProduction
    {
        public override IProduct CreateProduct()
        {
            return new Kolbasa();
        }
    }
}
