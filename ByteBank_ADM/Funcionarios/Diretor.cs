using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
    //HERANÇA -> ":"
    //Uma classe herda atributos, metodos, propriedades, comportamentos de uma super classe, classe base
    //Voce remove os atributos desta classe pq esta herdando da outra classe
    public class Diretor:Funcionario
    {   
        //AO HERDAR:
        //Na classe base, Funcionario, o VIRTUAL diz que seu metodo pode ser redefinido, subscrito na classe que herda de funcionario.
        //E na classe que Herda, utiliza a palavra OVERRIDE para dizer que o metodo teve uma reescrita,  redefinição que foi escrito na classe funcionario(na superclasse)
        public override double GetBonificacao()
        {
            //BASE -> permite acessar implementações de propriedades existentes na propriedade base(super classe)
            return this.Salario + 0.5;
        }

        public Diretor(string cpf):base(cpf, 5000)
        {
            //Console.WriteLine("Criando um Diretor.");
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}
