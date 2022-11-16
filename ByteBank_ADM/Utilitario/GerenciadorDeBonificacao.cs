using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank_ADM.Funcionarios;

namespace ByteBank_ADM.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        public double TotalDeBonificacao { get; private set; }
        public void Registrar(Funcionario funcionario)
        {
            this.TotalDeBonificacao += funcionario.GetBonificacao();
        }

        //SOBRECARGA DE METODOS
        //Em GerenciadorDeBonificacao, vamos fazer uma cópia do método Registrar() e sobrecarregá-lo,
        //de modo que ele também poderá receber um tipo Diretor
        //POLIMORFISMO
        //classe GerenciadorDeBonificacao, o método Registrar()
        //trabalhará de maneira diferente de acordo com o parâmetro recebido.
        //Temos o mesmo comportamento, porém o método a ser invocado dependerá do parâmetro.


        //remove isso pq causa da heranca
        /*public void Registrar(Diretor diretor)
        {
            this.TotalDeBonificacao += diretor.GetBonificacao();
        }
        */

        //EXEMPLO DE DESCONSTRUTOR
        /*public class Auxiliar : Funcionario
        {
            public Auxiliar(string cpf) : base(cpf, 2000)
            {
            }

            public override void AumentarSalario()
            {
                Salario *= 0.10;
            }

            public override double getBonificacao()
            {
                return Salario * 0.2;
            }

            ~Auxiliar()
            {
                Console.WriteLine("Liberando recursos...");
            }

            Uma classe possui somente um método destrutor;
            Diferentemente dos construtores, ele não pode ser herdado nem sobrecarregado;
            Ele é invocado automaticamente;
            Não aplicamos modificadores de acesso ou parâmetrosao destrutor;
            Tem o mesmo nome da classe e é precedido do caractere “~”.
        */


    }
}
