using HW1.Abstract;
using HW1.Concrect;
FoodProduction foodProduction = new CerealProduction();
IProduct food = foodProduction.CreateProduct();
food.Produced();

