using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTaxCalculator
{
    // Calculate income tax based on sumplified progressive tax structure

    class Program
    {
        static void Main(string[] args)
        {
            // Input taxable income
            Decimal taxable = 0;
            bool isvalid = false;

            // loop untill a valid number is input
            while (isvalid == false)
            {
                Console.WriteLine("Please enter your taxable income:");
                string inputString = Console.ReadLine();
                isvalid = Decimal.TryParse(inputString, out taxable);
            }
            

            //taxable =  (inputString != null) ?
            //  Decimal.Parse(inputString) :
            //    0.0m;


            Decimal tax = 0;

            // tax rate is set by bracket

            if (taxable <= 20000)
            {
                tax = taxable * .05m;
            }
           

            if (taxable > 20000 && taxable <= 50000)
            {
                tax = (20000 * .05m) + ((taxable -20000) * .1m);
            }
            

            if (taxable > 50000 && taxable <= 75000)
            {
                tax = (20000 * .05m) + (30000 * .1m) + ((taxable - 50000) * .2m);
            }
            

            if (taxable > 75000)
            {
                tax = (20000 * .05m) + (30000 * .1m) + (25000 * .2m) + ((taxable - 75000) * .35m);
            }

            Console.WriteLine("Your Tax is: {0:C}", tax);
            Console.ReadLine();
	
            

        }
    }
}
