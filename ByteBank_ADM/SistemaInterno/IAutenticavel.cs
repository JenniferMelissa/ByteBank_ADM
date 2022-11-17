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


                    //STRUCKS 
//É um tipo de valor. Struct é semelhante a uma classe,
//porém esta é definida como sendo um tipo de valor enquanto
//a classe é um tipo de referência.

//Quando definido o construtor o mesmo deve possuir parâmetros.
//Não é possível iniciar um campo a não ser por seu construtor.
//Uma struct não pode ser a base de uma outra struct ou classe.


//Uma struct é muito útil para aquelas situações nas quais precisamos de poucas
//variáveis, pois os objetos criados com base em structs são mais leves e por
//ser do tipo de valor não trabalham com referências.

//Uma struct pode possuir construtores, campos, propriedades, métodos,
//indexadores. Uma struct pode ainda implementar uma interface,
//porém não existe herança entre structs. Para utilizar um objeto criado com
//base em uma estrutura.

//EXEMPLO

public struct Pessoa
{
    public int Idade { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Email { get; set; }

    public override string ToString()
    {
        return $"Nome: {this.Nome}" +
               $"Email: {this.Email}";
    }
}
//NO PROGRAM.CS:
//Pessoa pessoa = new();
//pessoa.Cpf = "111.111.111-66";
//pessoa.Nome = "André Silva";
//pessoa.Email = "andre@email.com";
//pessoa.Idade = 36;



//CLASSE
//Para fazer uso de objetos de uma determinada classe, precisamos
//criar objetos desta classe. Estas estruturas irão receber os valores
//de propriedades para representar um “objeto” que existe no mundo real.

public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int NumeroPaginas { get; set; }
    public bool PossuiISBN { get; set; }
    public string ISBN { get; set; }
    public DateTime AnoPublicacao { get; set; }

    public string DadosLivro()
    {
        return $"Título: {this.Titulo}" +
               $"Autor: {this.Autor}";
    }

}

//NO PROGRAM.CS

//Livro livro = new Livro()
//{
//    Titulo = "Orientação a Objetos em C#",
//    Autor = "Everton Araújo",
//    NumeroPaginas = 236,
//    AnoPublicacao = 2020,
//    PossuiISBN = true,
//    ISBN = "978-65-86110-00-5"

//};



