using System;
using System.Runtime.CompilerServices;

namespace Aula06_Encapsulamento
{
    public class Cliente : IImprimivel
    {
        private string _nome;
        private string _email;

        public string Nome
        {
            get
            {
                return _nome;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
    
        public Cliente(string nome, string email)
        {
            this._email = email;
            this._nome = nome;
        }
        
        public void Imprimir()
        {
            Console.WriteLine("\nNome: {0}", this.Nome);
            Console.WriteLine("Email: {0}", this.Email);
        }
    }
}