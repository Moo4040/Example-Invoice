using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;

namespace HalloWelt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Anschrift();
            Anschreiben(); 

            Console.WriteLine(@"
Motor        Kette      Lenkrad");
            Console.WriteLine("");
            Console.WriteLine("Menge        Preis      Gesamt");

            Rechnung(3, 7.95);
            Rechnung(1, 5.95);
            Rechnung(4, 6.95);
            Console.WriteLine("");
            PreisInsgesamt(6, 57.60);
            Zukunft();
            Einverständnis();
            Abschluss();
            
           
        }


        static void Anschrift()
        {
            Console.WriteLine(@"
Muhammed Taha Akdag
Musterstraße 123
Musterstadt 12345
Tel.: +49 121247283
E-Mail: info@Rechfirma.de
USt-IdNr.: DE123456789

Rechnungsnummer: RE-2026-001
Kundennummer: KD-001


Herr Glasmacher
Musterfirma
Musterstraße 43
12453 Musterstadt
");
        }




        static void Anschreiben()
        {
            String name = "Herr Glasmacher";
            String date = "01.01.2026";

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

            Console.WriteLine(amount + "            " + price + "€      " +     total + "€");
            

        }


        static void PreisInsgesamt(int Versand, Double Summe)
        {
            string Shipping = "Versand";
            string EndPrice = "Summe";
            Double total = Versand + Summe;

            Console.WriteLine(@"
-------------
Versandkosten inklusive");
            Console.WriteLine("GesamtSumme" + "\t\t" + total + "€");
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
