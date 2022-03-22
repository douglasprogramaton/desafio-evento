using System;
using System.Collections.Generic;

namespace NOVO_EVENTO
{



    class Program
    {

        public static void Main()
        {
            List<string> Mbebidas = new List<string>();
            Mbebidas.Add("COCA-COLA");
            Mbebidas.Add("FANTA");
            Mbebidas.Add("GUARANA");
            Mbebidas.Add("CERVEJA");
            Mbebidas.Add("AGUA");
            Mbebidas.Add("whisky");
            Mbebidas.Add("PINGA");

            List<string> bebidasmenor = new List<string>();
            bebidasmenor.Add("COCA-COLA");
            bebidasmenor.Add("FANTA");
            bebidasmenor.Add("GUARANA");
            bebidasmenor.Add("AGUA");

            List<string> playground = new List<string>();
            List<string> sorteio = new List<string>();
            List<int> Mesas = new List<int>();

            dynamic Items = new List<dynamic>();
            int repetir = 0;

            while (repetir < 5)
            {

                Console.WriteLine("\n CHEGADA NO EVENTO\n ");
                


                Console.Write("digite o nome do canditado:");
                string nome = Console.ReadLine();
               
                double consumo = 0.0;
                string data = String.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now);
                Console.Write($"diga a idade: ");
                int idade = int.Parse(Console.ReadLine());
                
                int Mesa = 0;

                Items.Add(new { Nome = nome, Mesa = Mesa, Despesa = consumo, Time = data, Idade = idade });// serão add.nas listas criadas.
                if (idade < 18)

                {
                    playground.Add(nome);

                    Console.WriteLine("Menores de idade nao poderao participar mas tem acesso vip no playground");

                    Console.WriteLine("$ \n Menor de idade ...[a]fliperamas | [b]futebol society | [c] ps5 \n ");

                    char Ebrinquedo;

                    Ebrinquedo = char.Parse(Console.ReadLine());

                    switch (Ebrinquedo)
                    {
                        case 'a':
                            Console.WriteLine("\n esta jogando the king of fighters 95 a 98 | street fighter \n.");
                            break;
                        case 'b':

                            Console.WriteLine("\n estará jogando  futebol com o professor falcao \n.");
                            break;
                        case 'c':
                            Console.WriteLine("\n estará jogando  COD WARZOONE . \n");
                            break;
                        default:
                            Console.WriteLine("\n opçao invalida \n");
                            break;
                    }
                }
                else if (idade > 65)
                {
                    Console.WriteLine("GANHARA BRINDES NO FIM DO EVENTO");
                }
                else
                {
                    sorteio.Add(nome);
                    Console.Write($"escolha uma mesa de 1 há 20:");
                    Mesas.Add(int.Parse(Console.ReadLine()));
                    
                }
                string resultado = String.Empty;
                char aceito;


                Console.WriteLine($"........................Deseja beber algo?:s/n........................");
                string drink = Console.ReadLine().ToLower();
                if (drink == "s"  && idade > 18)
                {
                  
                   
                    Console.WriteLine(".......................Escolh a bebida.............................");
                    foreach (string b in Mbebidas)
                    {
                        Console.WriteLine("cardapio:{0}", b);
                    }
                    Console.ReadLine();
                    Console.WriteLine("$       ESCOLHA A BEBIDA ...[a] COCA-COLA | [b] FANTA | [c] GUARANA | [d] CERVEJA | [e] WHISKY | [F] PINGA [g] agua...");
                    aceito = char.Parse(Console.ReadLine());

                    switch (aceito)
                    {
                        case 'a':
                            Console.WriteLine("\n Servindo uma Coca-Cola bem gelada...\n");
                            break;
                        case 'b':
                            Console.WriteLine("\n Servindo uma Fanta bem gelada...\n");
                            break;
                        case 'c':
                            Console.WriteLine("\n Servindo um Guarana bem gelado... \n");
                            break;
                        case 'd':
                            Console.WriteLine("\n Servindo uma Cerveja bem gelada...\n");
                            break;
                        case 'e':
                            Console.WriteLine("\n.....Whisky...melhor qualidade \n");
                            break;
                        case 'f':
                            Console.WriteLine("\n.....Rabo de galo.....\n");
                            break;
                        case 'g':
                            Console.WriteLine("\n.....agua gelada.....\n");
                            break;
                        default:
                            Console.WriteLine("\n opçao invalido\n");
                            break;

                    }
           
                }
                
                else if (drink == "s" && idade < 18)
                {
                    Console.WriteLine("\n Escolh a bebida \n");
                    foreach (string bm in bebidasmenor)
                    {
                        Console.WriteLine("cardapio:{0}", bm);
                    }
                    Console.ReadLine();
                    Console.WriteLine("$      ESCOLHA A BEBIDA ...[a] COCA-COLA | [b] FANTA | [c] GUARANA | [d] AGUA ");
                    aceito = char.Parse(Console.ReadLine());
                    switch (aceito)
                    {
                        case 'a':
                            Console.WriteLine("\n Servindo uma Coca-Cola bem gelada...\n");
                            break;
                        case 'b':
                            Console.WriteLine("\n Servindo uma Fanta bem gelada...\n");
                            break;
                        case 'c':
                            Console.WriteLine("\n Servindo um Guarana bem gelado...\n");
                            break;
                        case 'd':
                            Console.WriteLine("\n Servindo uma agua bem gelada...\n");
                            break;
                        default:
                            Console.WriteLine("\n opçao invalido \n ");
                            break;
                    }
                 

                }
                else
                {
                    drink = "n";
                    Console.WriteLine(".......................OK estamos a disposição........................");
                }
                DateTime dataEntrada = DateTime.Now;
                Console.WriteLine(dataEntrada);
                repetir++;
                if (repetir == 5)
                {

                    string[] sorteados = new string[5];
                    sorteio.CopyTo(sorteados);
                    int[] MS = new int[5];
                    Mesas.CopyTo(MS);
                    Console.WriteLine("primeira mesa sorteada:{0}",MS[0]);
                    Console.WriteLine("vencedores do evento:{0}", sorteados[0]);
                    Console.WriteLine("segunda mesa sorteada:{0}",MS[1]);
                    Console.WriteLine("vencedores do evento:{0}", sorteados[1]);
                    Console.WriteLine("terceira mesa sorteada:{0}",MS[2]);
                    Console.WriteLine("vencedores do evento:{0}", sorteados[2]);

                }
            }

        }
    }
}

