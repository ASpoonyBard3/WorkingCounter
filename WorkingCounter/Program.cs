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
            //add apples to box 
            box.Add(new Apple());
            box.Add(new Apple());
            box.Add(new Apple());
            box.Add(new Apple());
            box.Add(new Apple());


            //creates a second box
            Box box2 = new Box();
            //adds an apple to it
            box2.Add(new Apple());
            box2.Add(new Apple());
            box2.Add(new Apple());

            //creates a cart, adds box to the cart
            Cart cart = new Cart();
            cart.Add(new Box());
            cart.Add(box);
            cart.Add(box2);

            //print to console, number of apples in box
            Console.WriteLine("There are " + box.Count + " apples in the first box");
            Console.ReadLine();

            //print contents of cart to console
            Console.WriteLine("There are " + cart.Count + " boxes in the cart.");
            Console.ReadLine();

        }

       
    }

}
