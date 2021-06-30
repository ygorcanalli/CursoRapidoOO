using System;

namespace Aula05_Interface
{
    public class Cliente : IImprimivel
    {
        public string Nome;
        public string Email;

        public Cliente(string nome, string email)
        {
            this.Email = email;
            this.Nome = nome;
        }
        
        public void Imprimir()
        {
            Console.WriteLine("\nNome: {0}", this.Nome);
            Console.WriteLine("Email: {0}", this.Email);
        }
    }
}