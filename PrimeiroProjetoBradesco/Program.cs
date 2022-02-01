
//Linguagem de Programação CSharp - Básico

//Realizando treinamento conforme desenvolve o curso.

/*  
    Console.WriteLine(!X);
    n3++;
    Console.WriteLine(n3);
    n4--;
    Console.WriteLine(n4);

    Console.WriteLine(n2 == --n1);
    Console.WriteLine(n2 == ++n1);

 */


/*

string nomeMae = Console.ReadLine();
Console.WriteLine("Quantos irmãos você tem?");
int irmaos = int.Parse(Console.ReadLine());

Console.WriteLine("Seu nome é {0}, sua idade é de {1} anos, sua Mãe chama-se {2} e você tem {3} irmãos.", nome, idade, nomeMae, irmaos);

*/

/*

Estrutura de controle - if/else

A estrutura que você estudará é a ''If'' (do inglês, "SE"), essa estrutura irá realizar determinada ação "SE" a condição 
//que for imposta, colocada entre parênteses, for satisfeita.

Obs: As ações que serão executadas devem estar entre as chaves que são abertas após a imposição das condições.

Para complementar a utilização do “if”, existe ainda o 'else', equivalente a "SE NÃO", ou seja, são as ações que serão 
executadas se as condições iniciais não forem satisfeitas.*/

/*
var n1 = 5;
var n2 = 9;
var n3 = 10;

if (n1 < n2){

    Console.WriteLine("Condição 1 é satisfeita!!");
    Console.WriteLine("Resultado da soma é {0}", n1 + n2);
}
if (n3 < n2)
{
    Console.WriteLine(n3 + n2);
}
else
{
    Console.WriteLine("Condição 2 não é satisfeita!!");
}
*/


/*

Estrutura de controle - Switch

O 'Switch' é semelhante ao que é realizado pela estrutura 'if', mas com uma diferença que funciona a partir de "escolhas". 
Essa estrutura retorna um valor, seja ele numérico ou outro, de acordo com a necessidade do programador.
Temos como exemplo um restaurante que deseja avaliar os seus pratos e enviar para todos os seus clientes uma 
entrevista para que eles deem a nota desejada.

Observe no código abaixo, ele demonstra esse projeto sendo realizado por meio da linguagem C#.

Console.WriteLine("Qual a nota você dar para o prato? 0, 5, ou 10");
int.TryParse(Console.ReadLine(), out int nota);*/

/*
switch (nota)
{
    case 0:
        Console.WriteLine("Comida muito ruim!.");
        break;
    case 5:
        Console.WriteLine("Comida razóavel.");
        break;
    case 10:
        Console.WriteLine("Comida Ótima!!.");
        break;
    default:
        Console.WriteLine("Nota inexistente");
        break;

}
*/


/* 
 
Estruturas de Controle - While

A estrutura 'While' é uma estrutura de repetição, ou seja, 
determinada ação desejada pelo programador será repetida enquanto a condição é satisfeita.

Exemplo: Neste exemplo, foi criada uma variável 'n1' com valor '1', a condição dada pela estrutura 'While' é que enquanto 'n1' 
for menor ou igual a '15' ele irá exibir na tela os números, resumindo, o programa fará a contagem de 1 a 15.*/

/*
var n1 = 1;

while (n1 <= 15)
{
    Console.WriteLine(n1);
    n1++;
}
*/

/*

Estruturas de controle - For

A estrutura do tipo 'for' (do inglês, "para"), como sua expressão já diz, é utilizada com objetivo de realizar ações para determinadas 
condições, funcionando da seguinte forma:

Obs: for (condição inicial; condição; incremento);

Lembre-se! Não é obrigatório ter os três termos para que a estrutura 'for' funcione, podendo ser criada uma estrutura apenas com a 
condição necessária.*/

/*
var n1 = 1;

for(n1 = 1; n1 <=10; n1++)
{
    Console.WriteLine(n1);
}
*/


