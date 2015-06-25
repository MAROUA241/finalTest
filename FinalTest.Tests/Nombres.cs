using System;
using System.Collections.Generic;
using System.Linq;
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

        public IEnumerable<int> NombresPairs {
            get
            {
                return _keyValuePairs.Where(x => (x.Value % 2) == 0).Select(x => x.Value);
            }
         }
    }
}
