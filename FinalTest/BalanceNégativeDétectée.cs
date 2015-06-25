using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest
{
    public class BalanceNégativeDétectée : IEvenementMetier
    {
        private string numéroDeCompte ;
        private Montant montant;
        private DateTime dateRetrait= new DateTime();
        public BalanceNégativeDétectée(string numéroDeCompte, Montant montant, DateTime dateRetrait)
        {
            this.numéroDeCompte = numéroDeCompte;
            this.montant=montant;
            this.dateRetrait = dateRetrait;
        }

    
    }
}
