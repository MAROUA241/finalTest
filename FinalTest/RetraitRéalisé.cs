using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest
{
    public class RetraitRéalisé : IEvenementMetier
    {
        private  string numéroDeCompte;
        private  Montant montantRetrait;
        private  DateTime dateRetrait;

        public RetraitRéalisé(string numéroDeCompte, Montant montantRetrait, DateTime dateRetrait)
        {
            this.numéroDeCompte = numéroDeCompte;
            this.montantRetrait = montantRetrait;
            this.dateRetrait = dateRetrait;
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            RetraitRéalisé dépotRéalisé = obj as RetraitRéalisé;

            if (dépotRéalisé.numéroDeCompte != this.numéroDeCompte) return false;
            if (dépotRéalisé.montantRetrait != this.montantRetrait) return false;
            if (dépotRéalisé.dateRetrait != this.dateRetrait) return false;

            return true;
        }

        public IEnumerable<IEvenementMetier> Ouvrir(string numéroDeCompte, int autorisationDeCrédit)
        {
            throw new NotImplementedException();
        }
    }

}
