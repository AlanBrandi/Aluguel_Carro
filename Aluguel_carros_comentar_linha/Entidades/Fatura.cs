using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Aluguel_carros.Entidades
{
    class Fatura
    {
        //Encapsulamento "PagamentoBasico".
        public double PagamentoBasico { get; set; }
        //Encapsulamento "Taxa".
        public double Taxa { get; set; }
        //Encapsulamento personalizada.
        public Fatura(double aluguel, double taxa)
        {
            //Pegando as variáveis que foram enviadas e alocando elas.
            PagamentoBasico = aluguel;
            //Pegando as variáveis que foram enviadas e alocando elas.
            Taxa = taxa;
        }
        //Método Pagamento total.
        public double PagementoTotal
        {
            ////Método Pagamento total, retorna o Pagamento básico mais a taxa.
            get { return PagamentoBasico + Taxa; }
        }
        //Método ToString(transforma o que se colocar em string)
        public override string ToString()
        {
            //Método ToString(transforma o que se colocar em string), retorna o conteúdo em uma lista para demonstrar.
            return "Pagamento Básico: " + PagamentoBasico.ToString("F2", CultureInfo.InvariantCulture) + "\n Taxa: " + Taxa.ToString("F2", CultureInfo.InvariantCulture) + "\n Pagamento Total: " + PagementoTotal.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
