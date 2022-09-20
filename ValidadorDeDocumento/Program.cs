using Caelum.Stella.CSharp.Validation;
using System;

namespace ValidadorDeDocumento
{
    class Program
    {
        static void Main(string[] args)
        {
            string cpf1 = "86288366757";
            string cpf2 = "98745366797";
            string cpf3 = "22222222222";

            string cnpj1 = "23622785000130";
            string cnpj2 = "23622785000139";

            string titulo1 = "018408632100";
            string titulo2 = "018408632189";

            ValidarTitulo(titulo1);
            ValidarTitulo(titulo2);

            ValidarCPNJ(cnpj1);
            ValidarCPNJ(cnpj2);

            ValidarCPF(cpf1);
            ValidarCPF(cpf2);
            ValidarCPF(cpf3);

        }
        private static void ValidarTitulo(string titulo)
        {
            if (new TituloEleitoralValidator().IsValid(titulo))
            {
                Console.WriteLine("Titulo válido: " + titulo);
            }
            else
            {
                Console.WriteLine("Titulo inválido: " + titulo);
            }
        }
        private static void ValidarCPNJ(string cnpj)
        {
            if (new CNPJValidator().IsValid(cnpj))
            {
                Console.WriteLine("CNPJ válido: " + cnpj);
            }
            else
            {
                Console.WriteLine("CNPJ inválido: " + cnpj);
            }
        }

        private static void ValidarCPF(string cpf)
        {
            if(new CPFValidator().IsValid(cpf))
            {
                Console.WriteLine("CPF válido: " + cpf);
            }
            else
            {
                Console.WriteLine("CPF inválido: " + cpf);
            }
        }
    }
}
