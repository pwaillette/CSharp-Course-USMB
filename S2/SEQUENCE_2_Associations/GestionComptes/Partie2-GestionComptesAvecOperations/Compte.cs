using System;
using System.Collections.Generic;

namespace Partie2_GestionCompteAvecOperations
{
    public class Compte
    {
        public string Nom { get; set; }
        public string Numero { get; set; }
        public decimal Solde { get; set; }
        public List<Operation> Operations { get; set; }

        public Compte(string nom, string numero, decimal solde)
        {
            Nom = nom;
            Numero = numero;
            Solde = solde;
            Operations = new List<Operation>();
        }

        public void AfficherMenu()
        {
            Console.WriteLine("--- Menu ---");
            Console.WriteLine("1. Créditer");
            Console.WriteLine("2. Débiter");
            Console.WriteLine("3. Consulter le solde");
            Console.WriteLine("4. Consulter la liste des opérations");
            Console.WriteLine("5. Quitter");
            Console.Write("Choisir une option : ");
        }

        public void Crediter(decimal montant)
        {
            Solde += montant;
            Operations.Add(new Operation { Date = DateTime.Now, Heure = DateTime.Now.TimeOfDay, Type = TypeOperation.Credit, Description = "Crédit", Montant = montant });
        }

        public void Debiter(decimal montant)
        {
            Solde -= montant;
            Operations.Add(new Operation { Date = DateTime.Now, Heure = DateTime.Now.TimeOfDay, Type = TypeOperation.Debit, Description = "Débit", Montant = montant });
        }

        public void ConsulterOpérations()
        {
            Console.WriteLine("--- Liste des opérations ---");
            foreach (var operation in Operations)
            {
                Console.WriteLine($"Date : {operation.Date}, Heure : {operation.Heure}, Type : {operation.Type}, Description : {operation.Description}, Montant : {operation.Montant}");
            }
        }
    }
}