using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest
{
    public class CompteCréé :IEvenementMetier
    {

        private string numéroDeCompte ;
        private int autorisationDeCrédit;
        public CompteCréé(string numéroDeCompte, int autorisationDeCrédit)
        {
            this.numéroDeCompte = numéroDeCompte;
            this.autorisationDeCrédit = autorisationDeCrédit;
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            CompteCréé compteObj = obj as CompteCréé;

            if (compteObj.numéroDeCompte != this.numéroDeCompte) return false;
            if (compteObj.autorisationDeCrédit != this.autorisationDeCrédit) return false;

            return true;
        }

        public IEnumerable<IEvenementMetier> Ouvrir(string numéroDeCompte, int autorisationDeCrédit)
        {
            throw new NotImplementedException();
        }
    }
}
