namespace Partie2_GestionCompteAvecOperations
{
    public enum TypeOperation
    {
        Debit,
        Credit
    } 
    
    public class Operation
     {
         public DateTime Date { get; set; }
         public TimeSpan Heure { get; set; }
         public TypeOperation Type { get; set; }
         public string Description { get; set; }
         public decimal Montant { get; set; }
     }
}
