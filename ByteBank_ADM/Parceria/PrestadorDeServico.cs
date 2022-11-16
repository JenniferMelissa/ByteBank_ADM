using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank_ADM.SistemaInterno;

namespace ByteBank_ADM.Parceria
{
    public abstract class PrestadorDeServico: IBonificavel
    {
        public string CNPJ { get; set; }
    }
}
