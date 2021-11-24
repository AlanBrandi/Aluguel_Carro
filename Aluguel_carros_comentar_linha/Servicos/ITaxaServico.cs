using System;
using System.Collections.Generic;
using System.Text;

namespace Aluguel_carros.Servicos
{
    //Interface "TaxaServico"
    interface ITaxaServico
    {
        //Criação da taxa de aluguel.
        double Taxa(double quantidade);
    }
}
