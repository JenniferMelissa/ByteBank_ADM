using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank_ADM.SistemaInterno;

namespace ByteBank_ADM.Funcionarios
{
    public class GerenteDeContas : FuncionarioAutenticavel
    {
        

        public GerenteDeContas(string cpf, double salario) : base(cpf, salario)
        {

        }

        public override double GetBonificacao()
        {
            return this.Salario + 0.25;
        }

        public GerenteDeContas(string cpf) : base(cpf, 4000)
        {
            //Console.WriteLine("Criando um Diretor.");
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }

    }
}
