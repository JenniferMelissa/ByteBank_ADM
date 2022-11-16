using Matematica;

Console.WriteLine("Olá, Boas Vindas ao Calculatrix!");

Operacoes operacoes = new Operacoes();

Console.WriteLine("O valor é: " + operacoes.Soma.Calcular(10,10));
Console.WriteLine("O valor é: " + operacoes.Subtracao.Calcular(30, 15));
Console.WriteLine("O valor é: " + operacoes.Divisao.Calcular(657, 98));
Console.WriteLine("O valor é: " + operacoes.Multiplicacao.Calcular(9, 48));



//Sobrecarga de métodos é uma forma de termos mais de um método com o mesmo nome em nosso
//código. O que vai diferenciá-los é o tipo e quantidade de parâmetros recebidos.
//Com ela conseguimos aplicar o conceito de polimorfismo, no qual um comportamento responde
//de maneira diferente de acordo com os dados informados em sua chamada.


//Usamos o operador this para trabalhar com elementos da própria instância do objeto.