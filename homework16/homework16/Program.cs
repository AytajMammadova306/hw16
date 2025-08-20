using homework16.Models;

namespace homework16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple
            {
                Price = 1.2m,
                Sort = "qizilehmed",
                VitaminA = 29,
                VitaminB= 30
            };
            Pineapple pineapple = new Pineapple
            {
                Price = 5,
                Sort = "hawai?",
                VitaminD=19,
                VitaminE=21,
            };
            Orange orange = new Orange
            {
                Price = 2,
                Sort = "turkish",
                VitaminC=17
            };

            //Fruit[] basket = { orange, pineapple, apple }; 
            Fruit fruit1 = apple;
            Fruit fruit2 = pineapple;
            Fruit fruit3 = orange;
            Fruit[] basket= {fruit1, fruit2, fruit3 }; 
            foreach(Fruit fruit in basket)
            {
                if (fruit is Apple apple2)
                    Console.WriteLine(apple2);
                if (fruit is Pineapple pineapple2)
                    Console.WriteLine(pineapple2);
                if (fruit is Orange orange2)
                    Console.WriteLine(orange2);
                    
            }
        }
    }
}
