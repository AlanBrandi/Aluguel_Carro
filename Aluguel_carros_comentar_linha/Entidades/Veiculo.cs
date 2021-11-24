using System;
using System.Collections.Generic;
using System.Text;

namespace Aluguel_carros.Entidades
{
    class Veiculo
    {
        //Encapsulamento "Modelo".
        public string Modelo { get; set; }
        //Construtor personalizado.
        public Veiculo(string modelo)
        {
            //Pegando as variáveis que foram enviadas e alocando elas.
            Modelo = modelo;
        }
    }
}
