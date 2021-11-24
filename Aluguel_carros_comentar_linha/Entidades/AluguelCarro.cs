using System;
using System.Collections.Generic;
using System.Text;

namespace Aluguel_carros.Entidades
{
    class AluguelCarro
    {
        //Encapsulamento "Comeco", usando DateTime.
        public DateTime Comeco { get; set; }
        //Encapsulamento "Final", usando DateTime.
        public DateTime Final { get; set; }
        //Encapsulamento "Veiculo".
        public Veiculo Veiculo { get; private set; }
        //Encapsulamento "Fatura".
        public Fatura Fatura { get; set; }

        //Construtor personalizado.
        public AluguelCarro(DateTime comeco, DateTime final, Veiculo veiculo)
        {
            //Pegando as variáveis que foram enviadas e alocando elas.
            Comeco = comeco;
            //Pegando as variáveis que foram enviadas e alocando elas.
            Final = final;
            //Pegando as variáveis que foram enviadas e alocando elas.
            Veiculo = veiculo;
            //Fatura é vazia.
            Fatura = null;
        }
    }
}
