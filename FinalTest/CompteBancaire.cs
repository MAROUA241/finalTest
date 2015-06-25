using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest
{
    public class CompteBancaire
    {
        private static readonly IEnumerable<IEvenementMetier> _initialElements;
        private String numéroDuCompte;
        public CompteBancaire(CompteCréé compteCréé)
        {
            this.numéroDuCompte = compteCréé.numéroDeCompte;
        }

        public static IEnumerable<IEvenementMetier> Ouvrir(string numéroDeCompte, int autorisationDeCrédit)
        {
           yield  return new  CompteCréé(numéroDeCompte,autorisationDeCrédit);

        }

        public IEnumerable<IEvenementMetier> FaireUnDepot(Montant montantDepot, DateTime dateDepot)
        {
            yield return new DépotRéalisé(numéroDuCompte, montantDepot, dateDepot);
        }
    }

    
}
