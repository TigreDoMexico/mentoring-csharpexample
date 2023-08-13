using EstudoCSharp.Enumerador;

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



/* CONVERSÕES */

Console.WriteLine("\n\nCONVERSÕES\n\n");

string numeroComoPalavra = "1234";
int numeroComoNumero = int.Parse(numeroComoPalavra);

numeroComoPalavra = "1234.55";
double numeroComVirgula3 = double.Parse(numeroComoPalavra);

Console.WriteLine("Número convertido de string para int: " + numeroComoNumero);
Console.WriteLine("Número convertido de string para double: " + numeroComVirgula3);



/* ENUMERADOR */

Console.WriteLine("\n\nENUMERADOR\n\n");

var dia = DiasDaSemana.Quarta; // ESTE ENUMERADOR ESTÁ DECLARADO EM: Enumerador/DiaDaSemana.cs

Console.WriteLine("HOJE É " + dia);

/* SWITCH */

switch(dia) {
    case DiasDaSemana.Domingo:
        Console.WriteLine("FINAL DE SEMANA");
        break;
    case DiasDaSemana.Sabado:
        Console.WriteLine("FINAL DE SEMANA");
        break;
    default:
        Console.WriteLine("DIA ÚTIL");
        break;
}



/* DATAS */

Console.WriteLine("\n\nENUMERADOR\n\n");

var dataDeHoje = DateTime.Now;
var dataCriada = new DateTime(2023, 11, 10); // 10/nov/2023

string dataComoPalavra = "08/07/2023";
var dataConvertida = DateTime.Parse(dataComoPalavra);

Console.WriteLine(dataDeHoje.ToString("yyyy/MM/dd"));
Console.WriteLine(dataCriada.ToString("dd/MM/yy"));
Console.WriteLine(dataConvertida.ToString("MM/dd/yyyy"));

Console.WriteLine("DIA: " + dataConvertida.Day);
Console.WriteLine("MÊS: " + dataConvertida.Month);
Console.WriteLine("ANO: " + dataConvertida.Year);
