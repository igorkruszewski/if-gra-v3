﻿using System.Threading.Tasks;

short życie = 100;
Console.WriteLine("masz 100 HP");
Console.WriteLine("trafiono cię zobaczmy ile masz HP !");
Console.WriteLine("czy trafiono cię pistoletem");
bool trafiono = bool.Parse(Console.ReadLine());

while (życie >= 0) {
 
    if (trafiono)
    {
        Console.Write("Przeżyłeś masz ");
        Console.Write(życie - 25);
        Console.WriteLine(" HP");
        życie = 75;

    } else {
        Console.WriteLine();
        Console.WriteLine("ok miałeś szczęście...");
    }
    Console.WriteLine("czy trafiono cię karabinem?");
    trafiono = bool.Parse(Console.ReadLine());
    if (trafiono)
    {
        życie = 25;
        Console.Write("pozostało ci ");
        Console.Write(życie);
        Console.WriteLine(" HP");
        
    } else {
        Console.WriteLine("dobra dalej Ci zostalo " + życie + " HP");
    }
    Console.WriteLine("czy trafiono cię nożem?");
    trafiono = bool.Parse(Console.ReadLine());
    if (trafiono) {
        Console.Write("masz");
        Console.Write(życie - 10);
        Console.WriteLine("HP");
        życie = 90;
    } else {
        Console.WriteLine("nie oszukujesz mnie przypadkiem ?");
    }
    Console.WriteLine("czy trafiono cię snajperką?");
    trafiono = bool.Parse(Console.ReadLine());
    if (trafiono)
    {
        Console.WriteLine("masz 0 HP!");
        Console.WriteLine("przegrałeś zagraj ponownie");
        życie = 0;
    }
    else {
        Console.WriteLine("masz szczescie, dalej masz " + życie + " HP");
    }
}