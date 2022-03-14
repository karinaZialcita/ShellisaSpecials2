using System;

namespace BadMilkGoodMilk
{
    class BadMilkGoodMilk
    {
        const int EXPIRY_DAYS = 14;
        const int GRACE_PERIOD = 3;
        static void Main(string[] args)
        {
            bool smellsFunny = false;
            int milkAge = 0;


            Console.WriteLine("How many days old is the milk? ");
            milkAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Does the milk smell funny?");
            //based on the response of the user, store the value true or false
            if(Console.ReadLine().Equals("yes"))
            {
                smellsFunny = true;
            }else
            {
                smellsFunny = false;
            }
            
            ////go ahead and make some decisions
            ///has the expiry passed?
          /*  if(milkAge <= EXPIRY_DAYS)
            {
                //continue
                if(milkAge <= (EXPIRY_DAYS +  GRACE_PERIOD))
                {
                    //this line doesnt need a condition bc its already a boolean which is a condition in itself
                    if (smellsFunny)
                    {
                        Console.WriteLine("The milk is spoiled");
                    } else
                    {
                        Console.WriteLine("Milk is not spoiled ");
                    }
                } else
                {
                    Console.WriteLine("Milk is not spoiled ");
                }
            } else
            {
                Console.WriteLine("Milk is not spoiled ");
            }*/


            /////-----
            /*if(milkAge > EXPIRY_DAYS &&
                milkAge > EXPIRY_DAYS + GRACE_PERIOD &&
                smellsFunny )
            {
                Console.WriteLine("the Milk is spoiled");
            } else
            {
                Console.WriteLine("the Milk is not spoiled");
            }  */       
            
            
            //even more simplified condition
            if(milkAge > EXPIRY_DAYS + GRACE_PERIOD &&
                smellsFunny )
            {
                Console.WriteLine("the Milk is spoiled");
            } else
            {
                Console.WriteLine("the Milk is not spoiled");
            }

        }
    }
}
