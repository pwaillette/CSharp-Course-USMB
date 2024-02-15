using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCompteAvecOperations
{
    internal class Operation
    {
        public enum TypeOperation { DEBIT, CREDIT };

        private DateTime dateHeure;
        private string description;
        private double montant;
        private TypeOperation typeOp;

        public Operation(TypeOperation typeOp, DateTime dateHeure, double montant, string description)
        {
            DateHeure = dateHeure;
            Description = description;
            Montant = montant;
            TypeOp = typeOp;
        }

        public Operation(TypeOperation typeOp, DateTime dateHeure, double montant)
        {
            DateHeure = dateHeure;
            Description = "";
            Montant = montant;
            TypeOp = typeOp;
        }

        public DateTime DateHeure { get => dateHeure; set => dateHeure = value; }
        public string Description { get => description; set => description = value; }
        public double Montant { get => montant; set => montant = value; }
        internal TypeOperation TypeOp { get => typeOp; set => typeOp = value; }

        public override bool Equals(object? obj)
        {
            return obj is Operation operation &&
                   DateHeure == operation.DateHeure &&
                   Description == operation.Description &&
                   Montant == operation.Montant &&
                   TypeOp == operation.TypeOp;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(DateHeure, Description, Montant, TypeOp);
        }

        public override string ToString()
        {
            string type = TypeOp.ToString().ToUpper();
            return $"{type} - {Montant}{Compte.MONNAIE} - {DateHeure} {Description}";
        }

        public static bool operator ==(Operation? left, Operation? right)
        {
            return EqualityComparer<Operation>.Default.Equals(left, right);
        }

        public static bool operator !=(Operation? left, Operation? right)
        {
            return !(left == right);
        }
    }
}
