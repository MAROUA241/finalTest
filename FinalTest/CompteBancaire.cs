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
        public static IEnumerable<IEvenementMetier> Ouvrir(string numéroDeCompte, int autorisationDeCrédit)
        {
           yield  return new  CompteCréé(numéroDeCompte,autorisationDeCrédit);

        }
    }

    
}
