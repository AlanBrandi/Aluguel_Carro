using System;
using System.Collections.Generic;
using System.Text;

namespace Aluguel_carros.Servicos
{
    class TaxaServicoBR : ITaxaServico
    {
        //Método "Taxa".
        public double Taxa(double quantidade)
        {
            //Se acaso a quantidade(valor do dinheiro) for menor ou igual a 100 entre aqui.
            if(quantidade <= 100)
            {
                //Taxa igual a 0.20.
                return quantidade * 0.20;
            }
            //Caso não for entre aqui.
            else
            {
                //Taxa igual a 0.15.
                return quantidade * 0.15;
            }
        }
    }
}
