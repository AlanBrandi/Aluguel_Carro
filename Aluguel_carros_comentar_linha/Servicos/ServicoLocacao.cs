using System;
using System.Collections.Generic;
using System.Text;

namespace Aluguel_carros.Servicos
{
    class ServicoLocacao
    {
        //Encapsulamento "PrecoPorHora".
        public double PrecoPorHora { get; set; }
        //Encapsulamento "PrecoPorDia".
        public double PrecoPorDia{ get; set; }
        
        //Pegando a interface.
        ITaxaServico TaxaServico;
        //Construtor personalizado.
        public ServicoLocacao(double precoPorHora, double precoPorDia, ITaxaServico taxaServico)
        {
            //Pegando as variáveis que foram enviadas e alocando elas.
            PrecoPorDia = precoPorDia;
            //Pegando as variáveis que foram enviadas e alocando elas.
            PrecoPorHora = precoPorHora;
            //Pegando as variáveis que foram enviadas e alocando elas.
            TaxaServico = taxaServico;
        }
        //Método ProcessamentoFatura
        public void ProcessamentoFatura(Entidades.AluguelCarro aluguelCarro)
        {
            //Diferença entre duas datas, salvando em "duracao".
            TimeSpan duracao = aluguelCarro.Final.Subtract(aluguelCarro.Comeco);
            //Pagamento básico e assumindo seu valor.
            double PagamentoBasico = 0.0;
            //Se acaso a duração for maior que 12 entre aqui.
            if (duracao.TotalHours <= 12.0)
            {
                //Pagamento básico vai ser o preço por hora vezes a duração total.
                PagamentoBasico = PrecoPorHora * Math.Ceiling(duracao.TotalHours);
            }
            //Caso contrário entre aqui.
            else
            {
                //Pagamento básico vai ser o preço por hora vezes a duração total.
                PagamentoBasico = PrecoPorDia * Math.Ceiling(duracao.TotalDays);
            }
            //Taxa é igual a utilização do método "taxa" na classe "TaxaServico".
            double Taxa = TaxaServico.Taxa(PagamentoBasico);
            //salvando em fatura uma nova fatura.
            aluguelCarro.Fatura = new Entidades.Fatura(PagamentoBasico, Taxa);
        }
        
    }
}
