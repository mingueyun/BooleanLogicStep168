using System;


namespace BooleanLogicStep168
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);

            //Console.WriteLine(true || true);
            //Console.WriteLine(false || true);
            //Console.WriteLine(false || false);

            // Console.WriteLine(true || true);
            //Console.WriteLine(false || true);
            //Console.WriteLine(false || false);

            //Console.WriteLine(true != true);
            //Console.WriteLine(false != true);
            //Console.WriteLine(false != false);

            //Console.WriteLine(true ^ true);
            //Console.WriteLine(true ^ false);
            //Console.WriteLine(false ^ false);

            //Console.WriteLine(true && true true && false);
            //Console.WriteLine(true && true  true || false);

            //Console.ReadLine();


            Console.WriteLine("What is your age?");
            string Age = Console.ReadLine();
            int nAge = Convert.ToInt32(Age);

            Console.WriteLine("Have you ever had a dui? Answer in false or true");
            string Dui = Console.ReadLine();
            bool YesOrNo = Dui == "true";

            Console.WriteLine("How many speeding tickets do you have?");
            string Ticket = Console.ReadLine();
            int nTicket = Convert.ToInt32(Ticket);

            bool qual = nAge >= 15 && YesOrNo == false && nTicket <= 3;
            Console.WriteLine("Qualified?\n" + qual);
            Console.ReadLine();
        }
    }
}
