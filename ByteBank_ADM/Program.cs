using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.SistemaInterno;
using ByteBank_ADM.Utilitario;

#region 
//#region - #endregion: PERMITE MINIMIZAR E OCULTAR OS COMENTARIOS
//Funcionario pedro = new Funcionario("12345678910",2000);
//pedro.Nome = "Pedro Malazartes";


//Console.WriteLine(pedro.Nome);
//Console.WriteLine(pedro.GetBonificacao());

//Diretor roberta = new Diretor("998785545");
//roberta.Nome = "Roberta Silva";


//Console.WriteLine(roberta.Nome);
//Console.WriteLine(roberta.GetBonificacao());

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(pedro);
//gerenciador.Registrar(roberta);


//Console.WriteLine("Total de Bonificações: " + gerenciador.TotalDeBonificacao);
//Console.WriteLine("Total de Funcionários: " + Funcionario.TotalDeFuncionarios);

//pedro.AumentarSalario();
//roberta.AumentarSalario();

//Console.WriteLine("Novo Salário do Pedro: " + pedro.Salario);
//Console.WriteLine("Novo Salário da Roberta: " + roberta.Salario);
#endregion

    //CalcularBonificacao();
    UsarSistema();

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer ulisses = new Designer("12345664555");
    ulisses.Nome = "Uisses Souza";

    Diretor paula = new Diretor("122211111");
    paula.Nome = "Paula Souza";

    Auxiliar igor = new Auxiliar("111212121");
    igor.Nome = "Igor Dias";

    GerenteDeContas camila = new GerenteDeContas("1122224545");
    camila.Nome = "Camila Oliveira";

    gerenciador.Registrar(camila);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(ulisses);

    Console.WriteLine("Total de Bonificação = " + gerenciador.TotalDeBonificacao);

}

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor ingrid = new Diretor("000333266");
    ingrid.Nome = "Ingrid Novaes";
    ingrid.Senha = "123";

    GerenteDeContas ursula = new GerenteDeContas("1212555");
    ursula.Nome = "Ursula Alcantara";
    ursula.Senha = "321";

    sistema.Logar(ingrid, "123");
    sistema.Logar(ursula, "963");

}
















