using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string cpf, double salario) : base(cpf, salario)
        {

        }

        public override double GetBonificacao()
        {
            return this.Salario + 0.17;
        }

        public Designer(string cpf) : base(cpf, 3000)
        {
            //Console.WriteLine("Criando um Diretor.");
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.11;
        }




    }
}
