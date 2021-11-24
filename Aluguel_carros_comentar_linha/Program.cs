using System;
using System.Globalization;

namespace Aluguel_carros
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pedindo os dados do veículo.
            Console.WriteLine("Entre com os dados da locação: ");
            //Pedindo por primeiro o modelo.
            Console.WriteLine("Modelo: ");
            //Salvando o modelo na variável "modelo".
            string modelo = Console.ReadLine();
            //Pedindo data de entrada.
            Console.WriteLine("Entrada (DD/MM/AAAA HH:MM): ");
            //Salvando a entrada na variável "comeco" usando o DataTime + forma de como vai ser enviado "dd/MM/yyyy".
            DateTime comeco = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            //Pedindo data de saída;
            Console.WriteLine("Saída (DD/MM/AAAA HH:MM): ");
            //Salvando na variável "final" a saída usando o DataTime + forma de como vai ser enviado "dd/MM/yyyy".
            DateTime final = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            //Pedindo para enviar o preço por hora.
            Console.WriteLine("Entre com o preço por hora: ");
            //Salvando na variável "hora".
            double hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Pedindo o preço por dia.
            Console.WriteLine("Entre com o preço por dia: ");
            //Salvando na variável "dia".
            double dia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Criando um novo aluguel de carro, enviando as variáveis corretas.
            Entidades.AluguelCarro aluguelCarro = new Entidades.AluguelCarro(comeco, final, new Entidades.Veiculo(modelo));
            //Criando um serviço de alucação e enviando as variáveis corretas.
            Servicos.ServicoLocacao servicoLocacao = new Servicos.ServicoLocacao(hora, dia, new Servicos.TaxaServicoBR());
            //Chamando o método ProcessamentoFatura enviando o aluguel do carro, para calcular a mesma.
            servicoLocacao.ProcessamentoFatura(aluguelCarro);
            //Demonstrando a fatura.
            Console.WriteLine("Fatura: ");
            //Demonstrando na tela a fatura.
            Console.WriteLine(aluguelCarro.Fatura);
        }
    }
}
