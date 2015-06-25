using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace FinalTest.Tests
{
    class Nombres
    {
        private IEnumerable<KeyValuePair<string, int>> _keyValuePairs;
        public Nombres(IEnumerable<KeyValuePair<string, int>> keyValuePairs)
        {
            this._keyValuePairs = keyValuePairs;
            
        }

        public IEnumerable<int> NombresPairs 
        {
            get
            {
                return _keyValuePairs.Where(x => (x.Value % 2) == 0).Select(x => x.Value);
            }
         }

        public String TexteNombresImpairs
        {
            get { return _keyValuePairs.Where(x => (x.Value % 2) != 0).OrderBy(x =>x.Value)
                .Select(x => x.Key).Aggregate((current, next) => current + ", " + next); }
            
        }

        public String PremierNombreDontLeTexteContientPlusDe5Caractères
        {
            get { return _keyValuePairs.Where(x => (x.Key.Length > 5)).Select(x => x.Key).Aggregate((current, next) => current); }
        }

        public IEnumerable<int> QuatreNombresSupérieursSuivant3
        {
            get { return _keyValuePairs.Where(x => (x.Value > 3)).OrderBy(x =>x.Value).Select(x => (x.Value)).Skip(0).Take(4) ; }
        }
    }
}
