namespace MorningRoutine;

public class MyMorningRoutine
{
    public void WhatShouldIDoNow()
    {
        var now = DateTime.Now;
        int currentHour = now.Hour;
        if (currentHour == 6) {
            Console.WriteLine("Do exercise");
        } else if (currentHour == 7) {
            Console.WriteLine("Read and study");
        } else if (currentHour == 8) {
            Console.WriteLine("Have breakfast");
        } else {
            Console.WriteLine("No activity");
        }
    }
}