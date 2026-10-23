using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1DB_framework.entities
{
    internal class Aplicaçãofinanceira
    {
        public int id { get; set; }
        public string? nome  { get; set; } = "";

        public int valor { get; set; }

        public bool IsFinalizado { get; set; }

        

        public Aplicaçãofinanceira()
        {
            id = 0;
            nome = "";
            valor = 0  ;
            IsFinalizado = false;
        }
        
        public Aplicaçãofinanceira(string nome, int valor, bool isFinalizado)
        {
            this.id = id;
            this.nome = nome;
            this.valor = valor;
            this.IsFinalizado = isFinalizado;
        }




    }
}
