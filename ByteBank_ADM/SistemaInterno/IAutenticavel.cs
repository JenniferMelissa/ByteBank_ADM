using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank_ADM.Funcionarios;

namespace ByteBank_ADM.SistemaInterno
{
    //INTERFACE - é um contrato e quem assina ele tem obrigação de implementar esse comportamento
    //quando se cria uma interface, usa-se um prefixo no nome da interface(padrão), utiliza a letra "I"
    //interface define propriedades e comportamentos que devem ser implementado por classes concretas.
    //ela sumila o comportademento de utilização de herança multipla
    public interface IAutenticavel
    {
        public string Senha { get; set; }

        public bool Autenticar(string senha);
       
    }
}
