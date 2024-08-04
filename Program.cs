using System;
using System.Security.Cryptography;
using estudocsharp.SistemaBanco;

namespace estudocsharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var conta = new Conta();
            conta.NomeConta = "Nata";
            conta.NumeroConta = 12345;
            conta.Agencia = 001;
            conta.Saldo = 3500.00m;

            conta.Titular = new Titular()
            {
                Cpf = "123.456.789-00",
                Rg = "1234567890",
                Endereco = "Rua dos brilhantes",
                Nome = "Nata"
            };
            Console.WriteLine($"O saldo atual é de: {conta.VerSaldo()}");

            conta.Depositar(1000);

            Console.WriteLine($"O saldo atualizado é de: {conta.VerSaldo()}");

            conta.Sacar(6000);

            Console.WriteLine($"O saldo atual, após saque foi de: {conta.VerSaldo()}");

            conta.Sacar(2000);
        }
    }
}
