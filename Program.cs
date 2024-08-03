using System;


namespace OpsplitsingEuro
{
    class Program
    {
        static void Main()
        {
            // Declaratie variabelen
            int bedrag, resultaat, bilijet = 0, muntstukken= 0 ;
           
            // Opvragen bedrag
            Console.Write("Gelieve het op te delen bedrag in te geven: ");
            bedrag = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("De opsplitsing naar de verschillende biljetten en munten is:");

            // Berekening
            resultaat = bedrag / 500;
            bedrag = bedrag % 500;
            bilijet += resultaat;
            Console.WriteLine($"Aantal biljetten van 500 EUR: {resultaat}");

            resultaat = bedrag / 200;
            bedrag = bedrag % 200;
            bilijet += resultaat;
            Console.WriteLine($"Aantal biljetten van 200 EUR: {resultaat} ");

            resultaat = bedrag / 100;
            bedrag = bedrag % 100;
            bilijet += resultaat;
            Console.WriteLine($"Aantal biljetten van 100 EUR:{resultaat} ");

            resultaat = bedrag / 50;
            bedrag = bedrag % 50;
            bilijet += resultaat;
            Console.WriteLine($"Aantal biljetten van 50 EUR: {resultaat}");


            resultaat = bedrag / 20;
            bedrag = bedrag % 20;
            bilijet += resultaat;
            Console.WriteLine($"Aantal biljetten van 20 EUR: {resultaat} ");

            resultaat = bedrag / 10;
            bedrag = bedrag % 10;
            bilijet += resultaat;
            Console.WriteLine($"Aantal biljetten van 10 EUR: {resultaat} ");

            resultaat = bedrag / 5;
            bedrag = bedrag % 5;
            bilijet += resultaat;
            Console.WriteLine($"Aantal biljetten van 5 EUR: {resultaat} ");

            resultaat = bedrag / 2;
            bedrag = bedrag % 2;
            muntstukken += resultaat;
            Console.WriteLine($"Aantal muntstukken van 2 EUR: {resultaat}");

            resultaat = bedrag / 1;
            bedrag = bedrag % 1;
            muntstukken += resultaat;
            Console.WriteLine($"Aantal muntstukken van 1 EUR: {resultaat}\n");

            // Resultaat
            Console.WriteLine($"Totaal aantal biljetten: {bilijet}");
            Console.WriteLine($"Totaal aantal muntstukken: {muntstukken}");
        }
    }
}

