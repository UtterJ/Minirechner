﻿using System;

namespace Minirechner
{
	class Program
	{		

		static void Main(string[] args)
		{
			//Variablen
			string Rechenart = "";
			double Zahl1;
			double Zahl2;

			//Überschrift
			Console.WriteLine("Minirechner");

			//Zahlen eingeben
			Console.Write("Zahl 1:");
			Zahl1 = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine();

			Console.Write("Zahl 2:");
			Zahl2 = Convert.ToDouble(Console.ReadLine());

			//Rechenart eingeben
			Console.Write("Rechenart eingeben:");
			Rechenart = Console.ReadLine();

			if (Rechenart == "+")
			{
				Addieren(Zahl1, Zahl2);
			}
		}

		static void Addieren(double Zahl1, double Zahl2)
		{
			//Rechnen + Ausgeben
			Console.Write("Ergebnis:");			
			Console.WriteLine(Zahl1 + Zahl2);
			Console.ReadKey();
		}
		
	}
}
