using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest
{
    public class DépotRéalisé : IEvenementMetier
    {
        private readonly string numéroDeCompte;
        private readonly Montant montantDepot;
        private readonly DateTime dateDepot;

        public DépotRéalisé(string numéroDeCompte, Montant montantDepot, DateTime dateDepot)
        {
            this.numéroDeCompte = numéroDeCompte;
            this.montantDepot = montantDepot;
            this.dateDepot = dateDepot;
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            DépotRéalisé dépotRéalisé = obj as DépotRéalisé;
            if (dépotRéalisé.numéroDeCompte != this.numéroDeCompte) return false;
            if (dépotRéalisé.montantDepot != this.montantDepot) return false;
            if (dépotRéalisé.dateDepot != this.dateDepot) return false;

            return true;
        }


    }
 }

