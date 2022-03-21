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


           // Random rdm = new Random();

            dynamic Items = new List<dynamic>();
            int repetir = 0;

            while (repetir < 5)
            {
                // List<string> sorteio = new List<string>();


                Console.Write("digite o nome do canditado:");
                string nome = Console.ReadLine();
                Console.Write($"escolha uma mesa de 1 há 20:" );
                int Mesa = int.Parse(Console.ReadLine());


                //int mesa = rdm.Next(1, 20);

                double consumo = 0.0;
                string data = String.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now);
                Console.Write($"diga a idade: ");
                int idade = int.Parse(Console.ReadLine());


                Items.Add(new { Nome = nome, Mesa = Mesa, Despesa = consumo, Time = data, Idade = idade });// serão add.nas listas criadas.
                if (idade < 18)

                {
                    playground.Add(nome);

                    Console.WriteLine("Menores de idade nao poderao participar mas tem acesso vip no playground");

                    Console.WriteLine("$ Menor de idade ...[a]fliperamas | [b]futebol society | [c] ps5 ");

                    char Ebrinquedo;

                    Ebrinquedo = char.Parse(Console.ReadLine());

                    switch (Ebrinquedo)
                    {
                        case 'a':
                            Console.WriteLine("esta jogando the king of fighters 95 a 98 | street fighter.");
                            break;
                        case 'b':

                            Console.WriteLine(" estará jogando  futebol com o professor falcao.");
                            break;
                        case 'c':
                            Console.WriteLine(" estará jogando  COD WARZOONE .");
                            break;
                        default:
                            Console.WriteLine("opçao invalida");
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
                    Mesas.Add(Mesa);
                    
                }


                //Console.ReadKey();

                string resultado = String.Empty;

                //int candidato = 0;
                char aceito;

                Console.WriteLine("\n CHEGADA NO EVENTO ");

                Console.WriteLine($"Deseja beber algo?:s/n");
                string drink = Console.ReadLine().ToLower();
                if (drink == "s" && idade > 18)
                {

                    Console.WriteLine("Escolh a bebida");
                    foreach (string b in Mbebidas)
                    {
                        Console.WriteLine("cardapio:{0}", b);
                    }
                    Console.ReadLine();
                    Console.WriteLine("$ ESCOLHA A BEBIDA ...[a] COCA-COLA | [b] FANTA | [c] GUARANA | [d] CERVEJA | [e] WHISKY | [F] PINGA [g] agua...");
                    aceito = char.Parse(Console.ReadLine());

                    switch (aceito)
                    {
                        case 'a':
                            Console.WriteLine("Servindo uma Coca-Cola bem gelada...");
                            break;
                        case 'b':
                            Console.WriteLine("Servindo uma Fanta bem gelada...");
                            break;
                        case 'c':
                            Console.WriteLine("Servindo um Guarana bem gelado...");
                            break;
                        case 'd':
                            Console.WriteLine("Servindo uma Cerveja bem gelada...");
                            break;
                        case 'e':
                            Console.WriteLine(".....Whisky...melhor qualidade");
                            break;
                        case 'f':
                            Console.WriteLine(".....Rabo de galo.....");
                            break;
                        case 'g':
                            Console.WriteLine(".....agua gelada.....");
                            break;
                        default:
                            Console.WriteLine("opçao invalido");
                            break;

                    }
             //       Random rmd = new Random();
               //     int tentativa = rdm.Next(1, 20);
                 //   Console.ReadLine();
                 //
                    DateTime dataEntrada = DateTime.Now;
                    Console.WriteLine(dataEntrada);

                   // resultado = rdm.Next(1, 20).ToString();
                    //Console.WriteLine(" Sentara na mesa:" + resultado);

                }


                else if (idade < 18)
                {
                    Console.WriteLine("Escolh a bebida");
                    foreach (string bm in bebidasmenor)
                    {
                        Console.WriteLine("cardapio:{0}", bm);
                    }
                    Console.ReadLine();
                    Console.WriteLine("$ ESCOLHA A BEBIDA ...[a] COCA-COLA | [b] FANTA | [c] GUARANA | [d] AGUA ");
                    aceito = char.Parse(Console.ReadLine());
                    switch (aceito)
                    {
                        case 'a':
                            Console.WriteLine("Servindo uma Coca-Cola bem gelada...");
                            break;
                        case 'b':
                            Console.WriteLine("Servindo uma Fanta bem gelada...");
                            break;
                        case 'c':
                            Console.WriteLine("Servindo um Guarana bem gelado...");
                            break;
                        case 'd':
                            Console.WriteLine("Servindo uma agua bem gelada...");
                            break;
                        default:
                            Console.WriteLine("opçao invalido");
                            break;
                    }
                }
                repetir++;
                if (repetir == 5)
                {


                    string[] sorteados = new string[5];
                    sorteio.CopyTo(sorteados);
                    int[] MS = new int[5];
                    Mesas.CopyTo(MS);

                    foreach (string s in sorteados)
                    {

                        //Console.WriteLine("vencedores do evento{0}",sorteados[0]);
                        // Console.WriteLine("vencedores do evento:{0}", sorteados[1]);
                        //Console.WriteLine("vencedores do evento:{0}", sorteados[2]);
                    }

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

