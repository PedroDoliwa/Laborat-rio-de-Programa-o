
// 1. Crie uma variável chamada idade e atribua a ela o valor 35 e exiba o seu valor.
int idade = 25;
Console.WriteLine(idade);

// 2. Crie uma variável chamada nome e atribua o valor "Maria" e exiba o seu valor.
String nome = "Maria";
Console.WriteLine(nome);

// 3. Crie uma variável chamada altura e atribua a ela o valor 3.45.
double altura = 3.45;
Console.WriteLine(altura);

// 4. Crie uma constante chamada ano e atribua a ela o valor 12 e exiba o seu valor
const int ano = 12;
Console.WriteLine(ano);

// 5. Declare uma variável nota do tipo double como sendo do tipo Nullable type e atribua o valor 7.80 e exiba o seu valor
double? nota = 7.80;
Console.WriteLine(nota);


// 6. Quais as diferenças entre os tipos por valor e os tipos por referência ?

/* Variáveis de tipos de referência armazenam referências em seus dados (objetos), no caso
duas variáveis podem fazer referência ao mesmo objeto.

Já variáveis de tipos de valor contém diretamente seus dados.
No qual cada variável tem a própria cópia dos dados e as operações em uma variável não podem afetar a outra.*/


// 7. O que é um nullable type e qual a sua utilidade ?

/* É um recurso de programação que permitem que um valor seja definido 
para o valor especial NULL em vez dos valores usuais possíveis do tipo de dados.

Em alguns aplicativos, um valor variável pode estar indefinido ou ausente. 
Por exemplo, um campo de dados pode conter true ou false, ou pode não conter nenhum valor, ou seja, NULL. 
Você pode usar o tipo bool? nesse cenário.*/


// 8. O que é Camel Case ? Dê um exemplo de sua aplicação.

/*Camel case é um estilo de nomenclatura de texto usado em programação que combina várias palavras em uma única palavra, 
em que a primeira letra de cada palavra é escrita em minúscula, exceto a primeira palavra. 
É usada para nomear variáveis, parâmetros de método e propriedades. */

int  idadeDaPessoa = 10;
Console.WriteLine(idadeDaPessoa);


// 9. O que é Pascal Case ? Dê um exemplo de sua aplicação

/*Pascal case é um estilo de nomenclatura de texto usado em programação que combina várias palavras em uma única palavra, 
mas a primeira letra de cada palavra é escrita em maiúscula.
É usada para nomear classes, interfaces, enums e métodos públicos.*/

String NomeDoCliente = "Pedro";
Console.WriteLine(NomeDoCliente);


/*10. Declare duas variáveis x e y como sendo do tipo int e atribua a ela os valores 77 e 66 e a
seguir imprima o valor da soma de x com y. (Use o operador aritmético + para realizar a
operação de soma)*/ 
int x = 77;
int y = 66;
int soma = x + y;
Console.WriteLine(soma);

/*11. Quais os valores padrões dos tipos de dados bool, char, int, double, float, decimal e
string

bool : false
char : \0
int : 0
double : 0
float : 0
decimal : 0
string : null
*/



