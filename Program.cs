using System;
using POO_Heranca.Classes;

namespace POO_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciamos a sublcasse PessoaFisica
            PessoaFisica pf = new PessoaFisica();
            PessoaFisica pessoaf = new PessoaFisica();

            // Atribuímos um cpf ao objeto
            pf.cpf = "000.000.000-00";

            pf.nome = "Derlis";

            // Chamamos nosso métodos da saudação dentro de um ConsoleWriteLine
            Console.WriteLine (pf.DarBoasVindas(pf.nome) );

            // Chamamos nosso método de validação da subclasse
            Console.WriteLine(pf.ValidaCPF(pf.cpf) );
            
        }
    }
}
