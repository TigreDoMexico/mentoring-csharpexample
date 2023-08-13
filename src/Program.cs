/* COMANDOS BÁSICOS */

// Comando para imprimir uma mensagem na tela
Console.WriteLine("Bem-vindo ao projeto de Estudo CSharp");
Console.WriteLine("Digite seu nome:");

// Comando para ler uma entrada do usuário via Consolea
var entradaUsuario = Console.ReadLine();

// Pode-se formar palavras (string) de duas formas:
string concatenacaoString1 = "Olá " + entradaUsuario;
string concatenacaoString2 = string.Format("Olá {0}", entradaUsuario);

Console.WriteLine(concatenacaoString1);
Console.WriteLine(concatenacaoString2);



/* VARIÁVEIS IMPLICITAS -> PRECISA TER UM VALOR AO DECLARAR */

var numero = 10;
var numeroComVirgula = 10.50;
var caractere = 'A';
var booleano = true;
var palavra = "Palavra 1";

/* VARIÁVEIS EXPLICITAS -> SE ESPECIFICA O TIPO, MAS NÃO PRECISA DECLARAR COM VALOR */

int numero2 = 20;
double numeroComVirgula2 = 20.20;
char caractere2 = 'B';
bool booleano2 = false;
string palavra2 = "Palavra 2";



/* OPERAÇÕES MATEMÁTICAS */

Console.WriteLine("\n\nOPERAÇÕES MATEMÁTICAS\n\n");

var soma = numero + numero2;
var subtracao = numeroComVirgula - numeroComVirgula2;
var multiplicacao = numero * numeroComVirgula2;
var divisao = numeroComVirgula / numero2;

Console.WriteLine(soma);
Console.WriteLine(subtracao);
Console.WriteLine(multiplicacao);
Console.WriteLine(divisao);

/* OPERAÇÕES COM PALAVRAS */

Console.WriteLine("\n\nOPERAÇÕES COM PALAVRAS\n\n");

palavra = string.Format("{0} {1}", palavra, caractere);
palavra2 = string.Format("{0} {1}", palavra2, caractere2);

Console.WriteLine(palavra);
Console.WriteLine(palavra2);

/* OPERAÇÕES COM BOOLEANOS */

Console.WriteLine("\n\nOPERAÇÕES BOOLEANAS\n\n");

Console.WriteLine(booleano && booleano2); // OPERADOR AND
Console.WriteLine(booleano || booleano2); // OPERADOR OR
Console.WriteLine(!booleano); // OPERADOR NOT



/* CONDIÇÕES */

Console.WriteLine("\n\nCONDIÇÃO\n\n");
var idade = 18;

if(idade >= 18) {
    Console.WriteLine("IDADE MAIOR IGUAL A 18");
} else {
    Console.WriteLine("IDADE MENOR QUE 18");
}

/* CONDIÇÃO TERNÁRIA */

var ehDeMaior = idade >= 18 ? "SIM" : "NÃO";
Console.WriteLine("É DE MAIOR: " + ehDeMaior);



/* LAÇO DE REPETIÇÃO */

Console.WriteLine("\n\nLAÇO DE REPETIÇÃO\n\n");

for(int i = 0; i < 5; i++) {
    Console.WriteLine("LAÇO FOR: " + i);
}

int count = 0;
while(count < 5) {
    Console.WriteLine("LAÇO WHILE: " + count);
    count++;
}

count = 0;
do {
    Console.WriteLine("LAÇO DO WHILE: " + count);
    count++;
} while(count < 5);



/* ENUMERADOR */
/*
Console.WriteLine("\n\nENUMERADOR\n\n");

var dia = DiasDaSemana.Quarta;

Console.WriteLine("" + dia);
*/