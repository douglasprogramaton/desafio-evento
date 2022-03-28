using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Projeto_Evento_MELHORADO
{
    public class Inicial
    {
        private static string NomedoEvento;
        private List<int> MesasDisponiveis { get; set; }
        Evento EventoAtual = new Evento();
        Convidados Sankasha = new Convidados();


        public void InclusaodeConsumo(int mesa, Convidados convidado)
        {

            bool IsValid = true;
     
            Console.Clear();
            Console.WriteLine("...............Cardapio.................");
            foreach (var item in Sankasha.cardapio)
            {

                Console.WriteLine($"Codigo:{item.Id} - Item:{item.Nome} - Valor: {item.Valor:C}");
            }
            Console.WriteLine("\n");
            do
            {
                try
                {
                    Console.WriteLine("Digite o Codido do produto:");
                    int codigoproduto = int.Parse(Console.ReadLine());
                   

                    var item = (from Cardapio in Sankasha.cardapio where Cardapio.Id == codigoproduto select Cardapio).SingleOrDefault();

                    convidado.ItensConsumidos.Add(item);
                    Console.WriteLine("Deseja fazer outro pedido ? \nS - SIM ou qualquer tecla para NAO");
                    IsValid = Console.ReadLine().ToUpper() == "S" ? true : false;

                }
                catch
                {
                    Console.WriteLine("............Digite apenas o codigo do produto..............");
                    IsValid = true;
                }
            } while (IsValid);


        }
        public void IniciodoEvento()
        {
            Console.Clear();
            Console.Write("Digite o Nome do Evento:");
            string NomeEvento = Console.ReadLine();
            Console.Write("Digite a Quantidade de mesas a serem reservadas:");
            int QtdMesas = int.Parse(Console.ReadLine());
            MesasDisponiveis = new List<int>();
            for (int i = 0; i < QtdMesas; i++)
            {
                MesasDisponiveis.Add(i + 1);
            }


            EventoAtual.Nome = NomeEvento;
            for (int i = 0; i < QtdMesas; i++)
            {
                var Convidado = IncluirConvidado();
                EventoAtual.Convidados.Add(Convidado);
                if (Convidado.Idade > 18) EventoAtual.Sorteio.Add(Convidado);
            }

            Console.ReadKey();
        }
        public Convidados IncluirConvidado()
        {
            
            Sankasha = new Convidados();
            Console.Clear();
            Console.Write("Digite o Nome do Convidado:");
            string nomeConvidados = Console.ReadLine();
            Console.Write("Digite a idade do Convidado:");
            int idade = int.Parse(Console.ReadLine());
            Console.Write("\nMesas Disponiveis\n:");

            foreach (var item in MesasDisponiveis)
            {
                Console.Write($"{item} |");

            }
            Console.Write("\n Qual mesa gostaria de sentar:");
            int Mesa = int.Parse(Console.ReadLine());
            MesasDisponiveis.Remove(Mesa);

            Sankasha.NomeDoConvidado = nomeConvidados;
            Sankasha.Idade = idade;
            Sankasha.chegada = DateTime.Now;
            Sankasha.Mesa = Mesa;
            return Sankasha;

        }
        public void Start()
        {
            bool isValed;
            IniciodoEvento();

            do
            {
                Console.WriteLine("Escolha uma fas mesas para ser incluso o consumo:\n");
                for (int i = 0; i < EventoAtual.Convidados.Count; i++)
                {
                    Console.Write($"{EventoAtual.Convidados[i].Mesa}|");
                }
                Console.WriteLine("\nDigite uma mesa");
                try
                {
                    int escolha = int.Parse(Console.ReadLine());
                    var SankashaSearch = (from convidado
                       in EventoAtual.Convidados
                       where convidado.Mesa == escolha
                      select convidado).Single();

                    if (SankashaSearch.Mesa== escolha)
                    {

                        InclusaodeConsumo(escolha,SankashaSearch);
                        Console.WriteLine($"Consumo do {SankashaSearch.NomeDoConvidado} é de {SankashaSearch.Cosumo():c}");
                        isValed = false;
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("Voce e o vencedor");
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.WriteLine("3");
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.WriteLine("2");
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.WriteLine("1");
                        Thread.Sleep(1000);
                        Console.Clear();
                        int qtdVencedores = 2;
                        for (int i = 0; i < qtdVencedores; i++)
                        {


                            var Sorteado = Sorteio();
                            Console.WriteLine($"{i+2} Sorteados é {Sorteado.NomeDoConvidado}");

                        }
                    }
                    else
                    {
                        Console.ReadKey();
                        isValed = true;

                    }
                }
                catch 
                {
                    Console.WriteLine("Digite somente numeros");
                        Console.ReadKey();
                    isValed = true;
                }
            }
            while (isValed);
            {


            }
        }

        public void InclusaodeConsumo(Convidados sankashaSearch)
        {
            throw new NotImplementedException();
        }
        public Convidados Sorteio()
        {
            Random random = new Random();
            int vencedor = random.Next(EventoAtual.Sorteio.Count);
            return EventoAtual.Convidados.ElementAt(vencedor);
        }
    }
}







