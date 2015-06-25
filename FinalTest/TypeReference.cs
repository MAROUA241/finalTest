using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest
{
   public class TypeReference
    {
    

     

       private  int _valeur;

        public TypeReference(int valeur)
        {

            this._valeur = valeur;
        }
        public override bool Equals(object obj)
        {

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            TypeReference typeReferenceObj = obj as TypeReference;

            if (typeReferenceObj._valeur != this._valeur) return false;

            return true;
        }

 

     
 
     
    }
}
