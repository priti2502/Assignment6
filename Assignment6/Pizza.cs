using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Pizza
    {
        private string Size { get; set; } 
        private int NoOfCheeseToppings { get; set; }
        private int NoOfPepperoniToppings { get; set; }
        private int NoOfHamToppings { get; set; }

        public Pizza(string size,int cheese,int pepporoni,int ham)
        {
            Size= size; 
            NoOfCheeseToppings= cheese; 
            NoOfPepperoniToppings = pepporoni;
            NoOfHamToppings = ham; 
        
        }
       
        public double calcCost(string Size)
        {
            
            double cost = 0.0;
            if(Size.Equals("small"))
            {
                cost = 10 + 2 * NoOfCheeseToppings + 2 * NoOfHamToppings + 2 * NoOfPepperoniToppings;
            }
            else if(Size.Equals("medium"))
            {
                cost = 12 + 2 * NoOfCheeseToppings + 2 * NoOfHamToppings + 2 * NoOfPepperoniToppings;
            }
            else if(Size.Equals("large"))
            {
                cost = 14 + 2 * NoOfCheeseToppings + 2 * NoOfHamToppings + 2 * NoOfPepperoniToppings;
            }
            else
            {
                Console.WriteLine("Give correct SIze");
            }
            return cost;

        }
        public void  getDescription()
        {
            Console.WriteLine($"PizzaSize: {Size},NoOfCheeseToppings: {NoOfCheeseToppings} ,NoOfPepperoniTopping: {NoOfPepperoniToppings},  NoOfHamToppings : {NoOfHamToppings}");

        }


    }
}
