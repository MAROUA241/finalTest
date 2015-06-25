using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest
{
    public class Calculatrice
    {
        private IOperation[] operations;

        public Calculatrice(IOperation[] operations)
        {
            this.operations = operations;
        }

        public double Calculer(string s)
        {
            return (from operation in operations where operation.PeutCalculer(s) select operation.Calculer(s)).FirstOrDefault();
        }
    }
       
    }

