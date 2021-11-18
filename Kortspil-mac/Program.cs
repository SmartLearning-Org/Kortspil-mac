using Kortspil_mac;
using System;

MainWindow window = new();
Console.WriteLine("Indtast nummeret på det kort, der skal vises (1-52)");
int kortnummer = Convert.ToInt32(Console.ReadLine());

string filnavn = window.FindBillede(kortnummer);
Console.WriteLine($"Billedet af kortet ligger i filen Billeder/{filnavn}");
