using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HalloWelt
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Anschreiben(); 

            Console.WriteLine(@"
Motor        Kette      Lenkrad");
            Console.WriteLine("");
            Console.WriteLine("Menge        Preis      Gesamt");

            Rechnung(3, 7.95);
            Rechnung(1, 5.95);
            Rechnung(4, 6.95);
            PreisInsgesamt();
            Zukunft();
            Einverständnis();
            Abschluss();
        }


        static void Anschreiben()
        {
            String name = "Herr Müller";
            String date = "01.01.2022";

            Console.WriteLine("Hallo " + name + @", 
ich hoffe es geht ihnen gut! 
Hiermit übersende ich meine Rechnung an sie, die ich am " + date + @" erstellt habe:");
        
        
        }


        static void Rechnung(int amount, Double price)
        {
            string ProduktOne = "Motor";
            string ProduktTwo = "Kette";
            string ProduktThree = "Lenkrad";
            Double total = amount * price;


            Console.WriteLine(amount + "            " + price + "€      " + total + "€");


        }

        static void PreisInsgesamt()
        {
            Console.WriteLine(@"
Insgesmat kommen wir dann zu einem Preis von 57.60€. 
Bitte diesen Betrag innerhalb 14 Werktage, auf das oben genannte Bankkonto zu überweisen.
");
        }


        static void Einverständnis()
        {
            Console.WriteLine(@"

Zur Einverständniserklärung, schicke ich ihnen extra ein Anhang mit in PDF-Form. 
");
        }


        static void Zukunft()
        {
            Console.WriteLine(@"

Ich wünsche mir das wir in Zukunft, mehr zusammen arbeiten. 
Eine Kooperation wäre ein vorschlag, meiner Seite aus...
Bei Interesse melden sie sich jederzeit bei mir!
");
        }


        static void Abschluss()
        {
            Console.WriteLine(@"

Vielen Dank, für ihre Unterstützung und mitarbeit.

Mit freundlichen Grüßen
Muhammed Taha Akdag
");
        }

    }
}
