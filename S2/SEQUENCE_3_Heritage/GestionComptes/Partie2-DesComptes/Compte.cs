namespace Partie2_DesComptes
{
    public class Compte
    {
        public string Nom
        {
            get => _nom;
            set => _nom = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Numero
        {
            get => _numero;
            set => _numero = value ?? throw new ArgumentNullException(nameof(value));
        }

        public decimal Solde
        {
            get => _solde;
            set => _solde = value;
        }

        public List<Operation> Operations
        {
            get => _operations;
            set => _operations = value ?? throw new ArgumentNullException(nameof(value));
        }

        public Compte()
        {
        }

        private string _nom;
        private string _numero;
        private decimal _solde;
        public List<Operation> _operations;

        public Compte(string nom, string numero, decimal solde)
        {
            Nom = nom;
            Numero = numero;
            Solde = solde;
            Operations = new List<Operation>();
        }

        public Compte(decimal solde)
        {
            Nom = "?";
            Numero = new Random().Next(0, 1245656555).ToString();
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

        public virtual void Crediter(decimal montant)
        {
            Solde += montant;
            Operations.Add(new Operation { Date = DateTime.Now, Heure = DateTime.Now.TimeOfDay, Type = TypeOperation.Credit, Description = "Crédit", Montant = montant });
        }

        public virtual bool Debiter(decimal montant)
        {
            Solde -= montant;
            Operations.Add(new Operation { Date = DateTime.Now, Heure = DateTime.Now.TimeOfDay, Type = TypeOperation.Debit, Description = "Débit", Montant = montant });
            return true;
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