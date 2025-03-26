using System;
using System.Collections.Generic;
using System.Linq;
using SephoraClase;
using NivelStocareDate;
using System.Configuration;
using System.IO;

class Program
{
    static Client Citeste_tastatura_c()
    {
        Console.Write("Id Client: ");
        int id;
        while (!int.TryParse(Console.ReadLine(), out id))
        {
            Console.Write("Id invalid! Introduceti un numar valid: ");
        }

        Console.Write("Nume Client: ");
        string nume = Console.ReadLine();
        Console.Write("Email Client: ");
        string email = Console.ReadLine();

        return new Client(id, nume, email);
    }

    static Produs Citeste_tastatura_p()
    {
        Console.Write("Nume Produs: ");
        string nume = Console.ReadLine();

        Console.Write("Pret Produs: ");
        int pret;
        while (!int.TryParse(Console.ReadLine(), out pret) || pret < 0)
        {
            Console.Write("Pret invalid! Introduceti un numar valid: ");
        }
        Console.Write("cantitate Produs: ");
        string cantitate = Console.ReadLine();

     
        Console.WriteLine("Alegeti o categorie: ");
        Console.WriteLine("1 - Machiaj \n" +
        "2 - Skincare \n" +
        "3 - Parfumuri \n" +
        "4 - Bodycare \n" +
        "5 - Par \n" +
        "6 - Accesorii \n" +
        "7 - KoreanBeauty \n");

        string opt = Console.ReadLine();
        bool valid = Enum.TryParse(opt, out Categorii ps);
        if (valid && Enum.IsDefined(typeof(Categorii), ps))
        {
            Produs produs = new Produs(nume, pret, cantitate);
            produs.CategorieProd = ps;
            return produs;
        }
        return new Produs(nume, pret, cantitate );
    }

    static Produs[] CautareInDenumire(Produs[] produse, string cuvantCautat)
    {
        return produse.Where(p => p != null && p.Nume.IndexOf(cuvantCautat, StringComparison.OrdinalIgnoreCase) >= 0).ToArray();
    }

    static void CitesteCuvinteDinFisier(string filePath)
    {
        string[] words = File.ReadAllLines(filePath)
                             .SelectMany(line => line.Split(new[] { ' ', '\t', ',', '.', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries))
                             .ToArray();

        List<string>[] ladderArray = new List<string>[26];
        for (int i = 0; i < ladderArray.Length; i++)
        {
            ladderArray[i] = new List<string>();
        }

        foreach (var word in words)
        {
            char firstChar = char.ToLower(word[0]);
            if (firstChar >= 'a' && firstChar <= 'z')
            {
                int index = firstChar - 'a';
                ladderArray[index].Add(word);
            }
        }

        for (int i = 0; i < ladderArray.Length; i++)
        {
            char letter = (char)('a' + i);
            Console.WriteLine($"Cuvinte care incep cu: '{letter}':");
            foreach (var word in ladderArray[i])
            {
                Console.WriteLine(word);
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        string numeFisierClienti = ConfigurationManager.AppSettings["NumeFisierClienti"];
        string numeFisierProduse = ConfigurationManager.AppSettings["NumeFisierProduse"];
        Console.WriteLine($"File path for clients from config: {numeFisierClienti}");
        Console.WriteLine($"File path for products from config: {numeFisierProduse}");

        AdministrareClient_FisierText adminClienti = new AdministrareClient_FisierText(numeFisierClienti);
        AdministrareProdus_FisierText adminProduse = new AdministrareProdus_FisierText(numeFisierProduse);

        Client clientNou = new Client();


        //AdministrareClient_FisierText adminClienti = new AdministrareClient();
        Console.Write("Numarul de clienti ai magazinului: ");
        int nrCl;
        while (!int.TryParse(Console.ReadLine(), out nrCl) || nrCl <= 0)
        {
            Console.Write("Numar invalid! Introduceti un numar valid: ");
        }

        for (int i = 0; i < nrCl; i++)
        {
            clientNou = Citeste_tastatura_c();
            adminClienti.AddClient(clientNou);
        }

        Client[] clienti = adminClienti.GetClienti(out int nrClienti).Where(c => c != null).ToArray();
        Console.WriteLine("\n Clientii magazinului:");
        foreach (var client in clienti)
        {
            Console.WriteLine(client);
        }

        Console.Write("Numarul de produse pe care doriti sa il adaugati este: ");
        int nrPr;
        while (!int.TryParse(Console.ReadLine(), out nrPr) || nrPr <= 0)
        {
            Console.Write("Numar invalid! Introduceti un numar valid: ");
        }

        for (int i = 0; i < nrPr; i++)
        {
            Produs produs = Citeste_tastatura_p();
            adminProduse.AddProdus(produs);
        }

        Produs[] produse = adminProduse.GetProduse(out int nrProdus).Where(p => p != null).ToArray();
        Console.WriteLine("\nProduse salvate:");
        foreach (var produs in produse)
        {
            Console.WriteLine(produs);
        }

        Console.Write("Introduceti cuvantul cautat in denumirea produsului: ");
        string cuvantCautat = Console.ReadLine();
        Produs[] rezultate = CautareInDenumire(produse, cuvantCautat);

        if (rezultate.Length > 0)
        {
            Console.WriteLine("Produse gasite:");
            foreach (var pr in rezultate)
            {
                Console.WriteLine(pr);
            }
        }
        else
        {
            Console.WriteLine("\nNu s-a gasit niciun produs.");
        }

        Console.Write("Introduceti calea fisierului cu cuvinte: ");
        string filePath = Console.ReadLine();
        if (File.Exists(filePath))
        {
            CitesteCuvinteDinFisier(filePath);
        }
        else
        {
            Console.WriteLine($"File not found: {filePath}");
        }

        Console.ReadKey();
    }
}
