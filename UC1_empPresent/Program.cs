﻿using System;
// check employee Wage on part time or full time using switch case.
class Program
{
    static void Main(string[] args)
    {
        //constants
        //int IS_FULL_TIME = 1;
        int EMP_RATE_PER_HOUR = 20;
        //int IS_PART_TIME = 2;

        // Variables
        int emphrs = 0;
        int empwage = 0;

        Random random = new Random();

        int empCheck = random.Next(0, 3);

        switch (empCheck)
        {
            case 1:
                Console.WriteLine("Employee is full time");
                emphrs = 8;
                break;
            case 2 :
                Console.WriteLine("Employee is part time");
                emphrs = 4;
                break;
            default:
                Console.WriteLine("Employee is absent");
                emphrs = 0;
                break;
        }
      
        empwage = emphrs * EMP_RATE_PER_HOUR;
        Console.WriteLine("emp Wage: " + empwage);
    }
}