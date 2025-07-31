using System;

     class TicketCalculator
    {
        static void Main()
        {

        double ticket = 10.0;
        Console.WriteLine("***********Ticket Price Calculator*******");

        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age >= 65 || age <= 12)
        {
            ticket = ticket - (ticket * 30 / 100);  //GHs 7 is a 30% discount

        }
        else
        {
          
        }
        Console.WriteLine("You will pay GHS " + ticket + "for your ticket.");
    }
    }
