using System;
namespace csharp_oop_shop
{
	public class Product
	{
        public int Codice { get; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }
        public int Iva { get; set; }

        public Product(string nome, string descrizione, double prezzo, int iva)
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
	}
}

