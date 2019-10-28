using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    class Program
    {
        static void Main(string[] args)
        {
            // p[0], p[1], p[2], p[3]
            string[] months = new string[12];
            months[0] = "January";
            months[1] = "February";
            months[2] = "March";
            months[3] = "April";
            months[4] = "May";
            months[5] = "June";
            months[6] = "July";
            months[7] = "August";
            months[8] = "September";
            months[9] = "October";
            months[10] = "November";
            months[11] = "December";

            Console.WriteLine($"{"Number"} {"Name",2}");
            for (int i = 0; i < months.Length; i++)
            {

                Console.WriteLine($"{i,2} {months[i],8}");

            }
            string[] seasons = { "Winter", "Spring", "Summer", "Fall" };
            foreach (string season in seasons)
            {
                Console.WriteLine(season);
            }
            Random random = new Random();
            int randomNumber;
            randomNumber = random.Next(0, 100);
            int[] intergers = new int[1000];
            foreach (int interger in intergers)
            {
                randomNumber = random.Next(0, 100);
                Console.WriteLine(randomNumber);
            }
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            int i2 = 0;
            while (i2 < names.Length)
            {
                Console.WriteLine(names[i2]);
                i2++;
            }
            string[] names2 = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            int i3 = 0;


            while (i3 < names.Length)
            {
                Console.WriteLine("{0,2}. {1}", i3, names2[i3]);
                i3++;
            }

            string[] names3 = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };
            int i4 = 0;
            foreach (string name3 in names3)
            {
                Console.WriteLine($"{i4,2}. " + name3);
                
               
                i4++;
            }
        }
    }
}
