namespace csharp_oop_shop;

class Program
{
    static void Main(string[] args)
    {
        Product libro = new Product("LOTR", "Un capolavoro, non serve aggiungere altro", 23.50, 23);
        Console.WriteLine($"Il prezzo complessivo di IVA è {libro.priceWithIVA()}");
        Console.WriteLine($"Il nome esteso del libro è {libro.extendedName()}");
        Console.WriteLine($"Il codice formattato è {libro.fillCode(libro.Codice)}");

        Product[] shop = new Product[3];
        shop[0] = new Product("Frigorifero", "Raffredda", 399, 23);
        shop[1] = new Product("Televisore", "Ci vedi le cose", 599, 23);
        shop[2] = new Product("Tostapane", "Tosta-pane, cosa vuoi che faccia", 100, 23);

        Console.WriteLine("\n\nProdotti presenti nel negozio:");
        foreach(Product product in shop)
        {
            Console.WriteLine($"\nNome del prodotto: {product.extendedName()} \nCodice del prodotto: {product.fillCode(product.Codice)} \nDescrizione del prodotto: {product.Descrizione} \nPrezzo del prodotto: {product.priceWithIVA()} IVA al {product.Iva}% inclusa");
        }

        // Bonus LV1 del pomeriggio
        Bonus bonus = new Bonus("Nome di prova", "Descrizione di prova", -10.50, -23);
        Console.WriteLine("\n\nBonus LV1:");
        Console.WriteLine($"IVA con controllo del valore negativo {bonus.Iva}");
        Console.WriteLine($"Prezzo con il controllo del valore negativo {bonus.Prezzo}");
        Console.WriteLine($"Prezzo con IVA e controllo del valore negativo applicato {bonus.priceWithIVA()}");

    }
}

