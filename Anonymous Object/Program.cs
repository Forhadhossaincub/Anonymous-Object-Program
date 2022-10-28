using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*You have the following Data

     Distric         Infected
     Dhaka              513
     Rajshahi           951    
     sylet              155    
     Rangpur            955    
     Khulna              45    

 1. Print all data
 2. Accending Order infected
 3. sum of infected
 4. Average of infected

*/


namespace Anonymous_Object
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var coronaStatus = new[] {               
                new { Distric= "Dhaka", Infected= 10}, 
                new { Distric= "Chittagong", Infected= 5}, 
                new { Distric= "Rajshahi", Infected= 35}, 
                new { Distric= "Khulna", Infected= 54}, 
            
            };

            foreach(var data in coronaStatus)
            {
                Console.WriteLine($"{data.Distric} : {data.Infected}");
            }

            Console.WriteLine("=======Decending Order===========");

            var newQuery = coronaStatus.OrderByDescending(x => x.Infected);

            foreach (var data in newQuery)
            {
                Console.WriteLine($"{data.Distric} : {data.Infected}");
            }

            Console.WriteLine("=======Ascending data using System.Linq===========");

            //var q = coronaStatus.OrderByDescending(x => x.Infected);
            var q = from data in coronaStatus
                    orderby data.Infected ascending
                    select data;

            foreach (var data in q)
            {
                Console.WriteLine($"{data.Distric} : {data.Infected}");
            }

            Console.WriteLine("=======Sum of Infected===========");

            int sumInfected = coronaStatus.Sum(x => x.Infected);
            Console.WriteLine($"Total Infected : {sumInfected}");

            Console.WriteLine("=======Average of Infected===========");

            double averageInfected = coronaStatus.Average(x => x.Infected);
            Console.WriteLine($"Average Infected : {averageInfected}");


            Console.ReadKey();
        }
    }
}
