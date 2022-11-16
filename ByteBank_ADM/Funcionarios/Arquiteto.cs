using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank_ADM.Parceria;
using ByteBank_ADM.SistemaInterno;

namespace ByteBank_ADM.Funcionarios
{
    public class Arquiteto: PrestadorDeServico, IAutenticavel
    {
        public string Senha { get; set; }

        public double GetBonificacao()
        {
            return 1000;
        }

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }

    }
}
