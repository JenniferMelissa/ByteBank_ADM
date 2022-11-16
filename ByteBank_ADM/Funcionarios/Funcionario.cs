using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
    //Funcionario é uma classe abstrata; é uma ideia conceito e serve como modelo para criacao de outras classes
    //utiliza ABSTRACT para classe abstrata, assim, impedindo que crie algum funcionario diretamente pois é uma classe abstrata
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }

        //PROTECTED - está protegendo este campo, pretegendo de alteraçoes; Ele é visivel na propria classe(funcionario) e nas classes que herdam de funcionario(diretor)
        public double Salario { get; protected set; }

        //STATIC - defini que essa propriedade é da classe e nao do objeto
        //private set - como a propriedade vai ser visivel (public) no projeto, ao usar private set
        //para manter a segurança, o encapsulamento, define somente a leitura dessa propriedade e nao a escrita dela
        //assim, bloqueia a escrita
        public static int TotalDeFuncionarios { get; private set; }


        //Virtual - O metodo pode ser redefinido, reescrito utilizando essa palavra 
        //qualquer classe que herdar de funcionario, pode reescrever esse metodo 
        //CLASSE BASE - VIRTUAL
        //CLASSE QUE HERDOU - OVERRIDE
        //remocaçao do virtual para abstract


        //METODO ABSTRATO NAO TEM IMPLEMENTACAO, SÓ TEM A DEFINICAO DO METODO E UM TIPO DE RETORNO
        public abstract double GetBonificacao();
        
        public Funcionario(string cpf, double salario)
        {
            this.Salario = salario; 
            this.Cpf = cpf;
            TotalDeFuncionarios++;
            //Console.WriteLine("Criando um Funcionário.");
        }

        //remocao do virtual, para o abstract
        public abstract void AumentarSalario();

    }
}
