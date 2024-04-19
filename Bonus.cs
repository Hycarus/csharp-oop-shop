using System;
namespace csharp_oop_shop
{
    public class Bonus
    {
        public int Codice { get; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        private double prezzo;
        public double Prezzo
        {
            get
            {
                return prezzo;
            }
            set
            {
                Console.WriteLine("\n\nBonus LV2");
                prezzo = checkIfNegative(value, nameof(Prezzo));
            }
        }
        private int iva;
        public int Iva
        {
            get
            {
                return iva;
            }
            set
            {
                iva = (int)checkIfNegative(value, nameof(Iva));
            }
        }

        public Bonus(string nome, string descrizione, double prezzo, int iva)
        {
            Random numeroRandom = new Random();
            Codice = numeroRandom.Next(1, 100000000);
            Nome = nome;
            Descrizione = descrizione;
            Prezzo = prezzo;
            Iva = iva;
        }

        public void basicPrice()
        {
            Console.WriteLine(Prezzo);
        }

        public double priceWithIVA()
        {
            return Math.Round(Prezzo * (Iva + 100) / 100, 2);
        }

        public string extendedName()
        {
            return Codice + Nome;
        }

        public string fillCode(int codice)
        {
            string codeToString = codice.ToString();
            string formatCode = codeToString.PadLeft(8, '0');
            return formatCode;
        }


        // Bonus LV2 del pomeriggio

        private static double checkIfNegative(double num, string name)
        {
            if (num < 0)
            {
                Console.WriteLine($"Il valore di {name} non può essere negativo. E' stato convertito in positivo.");
                return Math.Abs(num);
            }
            return num;
        }
    }
}

