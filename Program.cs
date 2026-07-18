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

            Console.WriteLine("\nProdukte     Menge    Preis    Gesamt");
            Console.WriteLine("----------------------------------------");

            double gesamtSumme = 0;

            gesamtSumme += Rechnung("Motor", 3, 7.95);
            gesamtSumme += Rechnung("Kette", 1, 5.95);
            gesamtSumme += Rechnung("Lenkrad", 4, 6.95);
            gesamtSumme += Rechnung("Bremsbeleg", 1, 17.99);
            gesamtSumme += Rechnung("Stoßstange", 2, 35.99);
            gesamtSumme += Rechnung("Grill", 1, 29.99);

            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Gesamtsumme                    {gesamtSumme:F2}€");
            Console.WriteLine("");
            
            Zahlungsweise();
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

                                                                                          Musterstadt, der 01.01.2026.

");
        }

        static void Anschreiben()
        {
            String name = "Herr Meier";
            String date = "01.01.2026";

            Console.WriteLine("Hallo " + name + @", 
ich hoffe es geht ihnen gut! 
Hiermit übersende ich meine Rechnung an sie, die ich am " + date + @" erstellt habe:");
        }

        static double Rechnung(string produkt, int amount, double price)
        {
            double total = amount * price;
            Console.WriteLine($"{produkt,-10} {amount,5}   {price,7:F2}€  {total,8:F2}€");
            return total;
        }

        static void Zahlungsweise()
        {
            Console.WriteLine(@"
Zahlungsinformationen:
Bitte überweisen sie den Rechnungsbetrag innerhalb 14 Tagen nach Rechnungsdatum auf folgendes Konto:

Bank: Musterbank AG
IBAN: DE12 3456 7890 1234 5678 90
BIC: MUSTDEFFXXX

Zahlungsziel: 14 Tage ab Rechnungsdatum (01.01.2026)
Vielen Dank für Ihre geschätzte Zahlung.
");

        }

        static void Abschluss()
        {
            Console.WriteLine(@"

Vielen Dank für ihre Unterstützung und Mitarbeit.

Mit freundlichen Grüßen
Muhammed Taha Akdag
");
        }
    }
}