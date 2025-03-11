using System;
using System.Collections.Generic;
using System.Linq;
using SephoraClase;
using NivelStocareDate;


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
        double pret;
        while (!double.TryParse(Console.ReadLine(), out pret) || pret <= 0)
        {
            Console.Write("Pret invalid! Introduceti un numar valid: ");
        }

        Console.Write("Categorie Produs: ");
        string categorie = Console.ReadLine();

        return new Produs(nume, pret, categorie);
    }

    static Produs[] CautareInDenumire(Produs[] produse, string cuvantCautat)
    {
        return produse.Where(p => p != null && p.Nume.IndexOf(cuvantCautat, StringComparison.OrdinalIgnoreCase) >= 0).ToArray();
    }

    static void Main()
    {
        AdministrareProdus adminPr = new AdministrareProdus();
        Console.Write("Numarul de produse pe care doriti sa il adaugati este: ");
        int nrPr;
        while (!int.TryParse(Console.ReadLine(), out nrPr) || nrPr <= 0)
        {
            Console.Write("Numar invalid! Introduceti un numar valid: ");
        }

        for (int i = 0; i < nrPr; i++)
        {
            Produs produs = Citeste_tastatura_p();
            adminPr.AddProdus(produs);
        }

        Produs[] produse = adminPr.GetProduse(out int nrProdus).Where(p => p != null).ToArray();
        Console.WriteLine("\nProduse salvate:");
        foreach (var produs in produse)
        {
            Console.WriteLine(produs);
        }

        AdministrareClient adminCl = new AdministrareClient();
        Console.Write("Numarul de clienti ai magazinului: ");
        int nrCl;
        while (!int.TryParse(Console.ReadLine(), out nrCl) || nrCl <= 0)
        {
            Console.Write("Numar invalid! Introduceti un numar valid: ");
        }

        for (int i = 0; i < nrCl; i++)
        {
            Client client = Citeste_tastatura_c();
            adminCl.AddClient(client);
        }

        Client[] clienti = adminCl.GetClient(out int nrClienti).Where(c => c != null).ToArray();
        Console.WriteLine("\n Clientii magazinului:");
        foreach (var client in clienti)
        {
            Console.WriteLine(client);
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

        Console.ReadKey();
    }
}
