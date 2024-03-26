/*
Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato : 
Aluno tem anos e nota usando a concatenação e a interpolação de strings. 
*/
String nome = "Paulo";
int idade = 17;
double nota = 7.5;

Console.WriteLine("Aluno: "+nome +" tem " +idade +" de idade e sua nota é " +nota);

/*
Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de
escapes.
*/

Console.WriteLine(nome +"\n"+idade+"\n"+nota );

/*
Para qual tipo de dados você pode converter um float implicitamente ?
( ) int
(X) double
( ) long
( ) decimal 
 */

/*
Em qual conversão numérica você precisaria realizar o casting (convesão forçada) ?
( ) int para long
( ) double para long
(X) double para float
( ) decimal para float
( ) long para int
( ) double para decimal
 */

/*
Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando
a concatenação e também a interpolação de strings
*/ 

Console.WriteLine("Letra 1: ");
var  l1 = Console.ReadLine();
Console.WriteLine("Letra 2: ");
var  l2 = Console.ReadLine();
Console.WriteLine("Letra 3: ");
var  l3 = Console.ReadLine();

Console.WriteLine($"{l3}" + $"{l2}" + $"{l1}");


/*
Marque verdadeiro(V) ou falso(F) para os códigos abaixo:
(F) long resultado = 1.32;
(V) var nome = “Maria”;
(F) string resultado = 100.ToString();
(V) A sequência de escape \n inclui uma nova linha
(V) float f = 5.45;
(F) decimal valor = (decimal) 10.99f;
(V) var status = null;
(F) object o = 12.45m;
(F) string titulo = true.ToString();
(V) A sequencia \t inclui uma tabulação vertical
 */

/*
Escreva um programa para receber dois valores via teclado do tipo double e a seguir
realize as operações de soma, subtração, multiplicação, exponenciação, divisão e módulo
exibindo o resultado:
*/


 Console.WriteLine("Informe o valor de x");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A some de x + y = {x+y}");
Console.WriteLine($"A subtração de x - y = {x-y}");
double divisao = (double) x/y;
Console.WriteLine($"A divisão de x / y = {divisao}");
Console.WriteLine($"A multiplicação de x * y = {x*y}");
Console.WriteLine($"Valor de x elevado a y {Math.Pow(x, y)}");



/*
Escreva um programa que receba um nome e uma senha via teclado. Nome é uma string e
Senha é um inteiro. Se o nome for igual a ‘admin’ ou ‘maria’ e a senha for igual a ‘123’
então exiba a mensagem ‘Login feito com sucesso’ caso contrário exiba a mensagem ‘Login
inválido’: (use o operador condicional ternário)
*/ 

Console.WriteLine("Nome: ");
var  nome1 = Console.ReadLine();

Console.WriteLine("Senha: ");
int senha = Convert.ToInt32(Console.ReadLine());

if((nome1 =="admin" || nome1 =="maria") & senha == 123  ){
    Console.WriteLine("Login feito com sucesso");

}else{
    Console.WriteLine("Login inválido");
}

/*
Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no
console se x é par ou não e se y é par ou não. Use o operador condicional ternário (? :)
*/

Console.WriteLine("x: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if(n1 % 2 == 0 ){
    Console.WriteLine("x é par");
}else{
    Console.WriteLine("x é impar");
}

if(n2 % 2 == 0 ){
    Console.WriteLine("y é par");
}else{
    Console.WriteLine("y é impar");
}
