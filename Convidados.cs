using System;
using System.Collections.Generic;

namespace Projeto_Evento_MELHORADO
{
    public class Convidados
    {
        public static List<Cardapio> Cardapio;
        public string NomeDoConvidado { get; set; }
        public int Idade { get; set; }

       
        public DateTime chegada { get; set; }
       public List<Cardapio> ItensConsumidos { get; set; }

        public int Mesa { get; set; }//get(para permitir pegar valores dentro da variavel, set permite incerir valores )

        public Convidados()
        {
            ItensConsumidos = new List<Cardapio>();
            Cardapio = new List<Cardapio>();
            Cardapio.Add(new Cardapio { Id = 1, Nome = "Coca-Cola de 1L :c", Valor = 4.69 });
            Cardapio.Add(new Cardapio { Id = 2, Nome = "Coca-Cola de 600ml :c", Valor = 3.99 });
            Cardapio.Add(new Cardapio { Id = 3, Nome = "fanta 600ml :c", Valor = 4.49 });
            Cardapio.Add(new Cardapio { Id = 4, Nome = "guarana 600ml :c", Valor = 2.95 });
            Cardapio.Add(new Cardapio { Id = 5, Nome = "suco del valle uva 1L :c", Valor = 6.19 });
            Cardapio.Add(new Cardapio { Id = 6, Nome = "suco de uva integral aurora preço :c", Valor = 8.95 });
            Cardapio.Add(new Cardapio { Id = 7, Nome = "cerveja heineken preço :c", Valor = 5.69 });
            Cardapio.Add(new Cardapio { Id = 8, Nome = "cerveja skol :c", Valor = 2.39 });
            Cardapio.Add(new Cardapio { Id = 9, Nome = "Suco natural 600ml :c", Valor = 3.39 });
            
            Cardapio.Add(new Cardapio { Id = 9, Nome = "Bife a cavalo com Fritas :c", Valor = 18 });
            Cardapio.Add(new Cardapio { Id = 9, Nome = "Bisteca com fritas :c", Valor = 14 });
            Cardapio.Add(new Cardapio { Id = 9, Nome = "Virada Paulista :c", Valor = 20 });
            Cardapio.Add(new Cardapio { Id = 9, Nome = "Lasanha :c", Valor = 25 });
            Cardapio.Add(new Cardapio { Id = 9, Nome = "Rodizio de Churrasco com Bebida a parte :c", Valor = 56.80 });
            
            Cardapio.Add(new Cardapio { Id = 9, Nome = "Coxinha  :c", Valor = 3.35 });
            Cardapio.Add(new Cardapio { Id = 9, Nome = "Coxinha Com Catupiry :c", Valor = 4.35 });
            Cardapio.Add(new Cardapio { Id = 9, Nome = "Risoles  :c", Valor = 3.35 });
            Cardapio.Add(new Cardapio { Id = 9, Nome = " Kibe  :c", Valor = 4.35 });
            
            Cardapio.Add(new Cardapio { Id = 9, Nome = " Xtudo  :c", Valor = 19 });
            Cardapio.Add(new Cardapio { Id = 9, Nome = " Xsalada  :c", Valor = 15.99 });
            Cardapio.Add(new Cardapio { Id = 9, Nome = " xbacon  :c", Valor = 19.5 });

          



        }
        public double Cosumo()
        {
            double temp =0;
            for (int i = 0; i < ItensConsumidos.Count; i++)
            {
                temp += ItensConsumidos[i].Valor;
            }
            return temp;

        }
        public List<Cardapio>  cardapio=> Cardapio;

     }
}