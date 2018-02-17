using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare new box
            Box box = new Box();
            box.Add(new Apple());
            box.Add(new Apple());
            box.Add(new Chip());

            Box box2 = new Box();
            box2.Add(new Apple());
            box2.Add(new Chip());


            Console.WriteLine(box.Count);
            Console.ReadLine();

            Cart cart = new Cart();
            cart.Add(new Box());
            cart.Add(box);
            cart.Add(box2);

            Console.WriteLine(cart.Count);
            Console.ReadLine();

        }
    }



}
