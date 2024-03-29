﻿using System;
using System.Collections.Generic;

namespace AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> authors = new List<string>() { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            List<string> cities = new List<string>() { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            List<string> phrases = new List<string>()
            {
                "Excellent product.", "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.", "I can’t live without this product."
            };
            List<string> events = new List<string>()
            {
                "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"
            };
            
            int value = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < value; i++)
            {
                Random random = new Random();

                var phrase = phrases[random.Next(phrases.Count)];
                var @event = events[random.Next(events.Count)];
                var author = authors[random.Next(authors.Count)];
                var city = cities[random.Next(cities.Count)];

                Console.WriteLine($"{phrase} {@event} {author} – {city}.");
            }
        }
    }
}
