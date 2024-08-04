using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace estudocsharp.SistemaBanco
{
     public class Conta
    {
        public int Agencia { get; set; }
        public int NumeroConta { get; set; }
        public string NomeConta { get; set; } = "Nata";
        public Titular Titular { get; set; } = new Titular();
        public decimal Saldo { get; set; } = 0;

        public decimal VerSaldo()
        {
            return Saldo;
        }
        
        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }
        
        public void Sacar(decimal valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }
        }
    }
}