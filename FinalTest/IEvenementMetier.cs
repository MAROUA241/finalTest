﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest
{
    public interface IEvenementMetier
    {
        IEnumerable<IEvenementMetier> Ouvrir(string numéroDeCompte, int autorisationDeCrédit);
    }
}