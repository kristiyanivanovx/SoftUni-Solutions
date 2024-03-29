﻿using System;

namespace cruiseShip
{
    class Program
    {
        static void Main(string[] args)
        {

            // totalSum = 4 (people count) * nights count * 1 night price
            string cruiseType = Console.ReadLine(); // "Mediterranean", "Adriatic", "Aegean"
            string roomType = Console.ReadLine();  // "standard cabin", "cabin with balcony", "apartment"
            int countNights = int.Parse(Console.ReadLine());

            double price = 0;

            switch (cruiseType)
            {
                case "Mediterranean":
                    if (roomType == "standard cabin")
                    {
                        price = 27.50;
                    }
                    else if (roomType == "cabin with balcony")
                    {
                        price = 30.20;
                    }
                    else if (roomType == "apartment")
                    {
                        price = 40.50;
                    }
                    break;

                case "Adriatic":
                    if (roomType == "standard cabin")
                    {
                        price = 22.99;
                    }
                    else if (roomType == "cabin with balcony")
                    {
                        price = 25.00;
                    }
                    else if (roomType == "apartment")
                    {
                        price = 34.99;
                    }
                    break;

                case "Aegean":
                    if (roomType == "standard cabin")
                    {
                        price = 23.00;
                    }
                    else if (roomType == "cabin with balcony")
                    {
                        price = 26.60;
                    }
                    else if (roomType == "apartment")
                    {
                        price = 39.80;
                    }
                    break;

            }

            double totalSum = 4 * countNights * price;

            if (countNights > 7)
            {
                totalSum -= 0.25 * totalSum; //0.75 * totalSum;
            }

            Console.WriteLine($"Annie's holiday in the {cruiseType} sea costs {totalSum:F2} lv.");
        }
    }
}