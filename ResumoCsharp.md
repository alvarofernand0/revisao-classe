### ========================================================

###  	C# fundamentos

---

### ========================================================



---



#### TIPOS DE VARIÁVEIS:



int, var, bool, float, double, string;

\*tudo em c# é string, então usar Parse. para converter..

========================================================



#### COMENTÁRIOS:



// uma linha
/\*  várias linhas  \*/
/// Notação XML (Metadata)

ATALHOS: seleciona e dá Ctrl + k + c (comenta);
Ctrl + k + u (descomenta);

========================================================



#### TIPOS PRIMITIVOS:



ou built-in types
São tipos base cujo outros tipos (complexos) irão derivar

São classificados em:
Simple Types, Enums, Structs, Nullable Types

========================================================



#### NÚMEROS INTEIROS:



int/uint
short/ushort
long/ulong

u = unsigned/sem sinal usado quando não se pode receber
valores negativos.

========================================================



#### NÚMEROS REAIS:



float; double, decimal

possuem positivos e negativos por padrão.



#### Ex:



float salario = 2.500f;
double salario = 22.000;
decimal salario = 25.000m;

========================================================



#### BOOLEAN:



true or false

Ex:

using system;

class Program
{
static void Main(string\[] args)
{

&nbsp;		bool usuarioJaCadastrado = false;
			bool pagamentoRecebido = true;
			var usuarioExpirado = false;
		}
	}










========================================================



#### CHAR:



guarda UM caractere no formato unicode;
atribuição de valor por aspas simples ''.

Ex:

char primeiraLetra = 'C';
var segundaLetra = 'D';

============================================



#### STRING:



Guarda uma cadeia de caracteres (uma lista de chars).
Atribuição de valores por aspas duplas "".



#### Ex:



string texto = "Meu texto";
string numerico = "12345.22";
var texto = "Meu texto";

===========================================



#### VAR:



* substitui o nome de um tipo.
* será do tipo do primeiro valor atribuído.
* recomendado usar var depois de dominar os tipos.



#### Ex:



var idade = 25; será do tipo int
var nome = "João"; será do tipo string

===========================================



#### OBJECT:



* Tipo genérico que recebe qualquer valor ou objeto;
* Caso não saiba o tipo da informação ou ela sera de vários tipos diferentes;
* Evite usar de início;



#### Ex:



object idade = 25;     será do tipo object
object nome = "João";  será do tipo object

===========================================



#### Nullabel Types:



void: vazio ou não retorna nada;
null: vazio ou nada. Todo tipo pode receber o valor null;

* diferente de zero ou uma string vazia;
* usa-se uma interrogação após o tipo



#### Ex:



int? idade = 0;
console.WriteLine(idade);
idade = null;
Console.WriteLine(idade);
idade = 25;
Console.WriteLine(idade);



============================================



#### ALIAS:



* apelido que todo tipo no .NET tem;
* o resultado é o mesmo, mas é indicado usar sempre o alias;



#### Ex:



int idade = 25;  Alias
Int32 idade = 25;  Tipo

============================================



#### VALORES PADRÕES:



* Todo tipo built-in já possui um valor padrão;
* Se nenhum valor for informado, seu valor padrão será usado;

  int = 0
  float = 0
  decimal = 0
  bool = false
  char = '\\0'
  string = ""

  ============================================

  

  #### CONVERSÃO IMPLÍCITA:

  

  float valor = 25.8f;
  int outro = 25;

  valor = outro  //  Conversão implícita

  ===========================================

  

  #### CONVERSÃO EXPLÍCITA:

  

* Ocorre quando os tipos não são compatíveis;
* É dada pelo uso do tipo entre parênteses antes da atribuição;
* 

  #### Ex:

  

  int inteiro = 100;
  uint inteiroSemSinal = (uint) inteiro;   // Conversão explícita

  

  ============================================

  

  #### PARSE:

  

* Método presente em todo tipo primitivo;
* Usado para converter um caractere ou string para um tipo qualquer;
* Caso haja alguma incompatibilidade, gera um erro;
* 

  #### Ex:

  

  int inteiro = int.Parse("100");

  ============================================

  

  #### CONVERT:

  

* Similar ao Parse, porém permite converter vários tipos
  de valor, não apenas string;
* Devemos informar o tipo na chamada da conversão;

  Ex:

  int inteiro = Convert.ToInt32("100");

  ==========================================

  

  #### OPERAÇÕES ARITMÉTICAS:

  

* Soma +
* Subtração -
* Multiplicação \*
* Divisão /
* Resto da divisão ou Mod %

  Obs:

* Multiplicação e divisão são executadas primeiro;
* Caso queira outra ordem, usar parênteses;
* Aceita short, int, float, double e decimal;
* 

  #### Ex:

  

  -Em caso de números inteiros, se o resultado for real,
  será arredondado;

  4.4 => 5

  

  int soma = 25 + 22;   //47
  int subtracao = 25 - 22;    //3
  int multiplicacao = 25 \* 22;   //550
  int divisao = 22 / 5;    // 4 foi arredondado

  ---

* Utilizar parênteses para redefinir a ordem de execução;

  int x = 2 + 2 \* 2 => 6
  int y = 2 + (2 \* 2) => 6  mesmo resultado
  int z = (2 + 2) \* 2 => 8 executou a soma primeiro

  

  ===========================================================

  

  #### OPERAÇÕES DE ATRIBUIÇÃO:

  

* Usa-se = para atribuir um valor;
* Pode-se usar igual junto a um operador aritmético;
* 

  #### Ex:

  

  X += 5

  é o mesmo que...

  X = X + 5

  

   	outros exemplos:

  &nbsp;			int x = 0;  atribuição
    				
    				x -= 5  é o mesmo que x = x + 5;
    				
    				x \\\*= 10 é o mesmo que x \\\* 10;

    				x /= 2 é o mesmo que x = x / 2;

  

  ===================================================================

  

  #### OPERADORES DE ATRIBUIÇÃO:

  

* Pode-se comparar qualquer tipo de dado: números, strings, bytes...

  -A comparação SEMPRE retorna True or False;

  

  #### Ex:

  

* Igual: ==
* Diferente: !=
* Maior que: >
* Menor que: <
* Maior ou igual a: >=
* Menor ou igual a: <=

  ---

  

  #### Ex:

  

  int x = 25;

  x == 0;  // False

  x != 0;  // True

  x > 0; // True

  x < 0;  // False

  x <= 0;  // False

  x >= 0;  // True

  

  ===========================================================

  

  #### OPERADORES LÓGICOS:

  

* Usados em operações condicionais;
* Retorna SEMPRE verdadeiro ou falso;

  ---

  E - AND: \&\&

  OU - OR: ||

  NEGAÇÃO - NOT: !

  

  #### Ex:

  int x = 12;
  bool e = (x > 25) \&\& (x < 40);  //False
  bool ou = (x > 25) || (x < 40);  //True
  bool negacao = !(x < 25);   //False

  

  ================================================================

  

  #### ESTRUTURA CONDICIONAL IF:

  

* Tradução: "SE", ou seja, "Caso alguma condição seja atendida";
* Usado para tomada de decisões;
* Utiliza os operadores lógicos;

  ---

  #### ESTRUTURA CONDICIONAL ELSE:

  

* Complemento do IF;
* Caso a condição não seja atendida;
* Podemos ter
  else if (condição)
  não tem limites (Mas cuidado)
* Podemos ter else para executar algo caso a condição seja atendida;

  Ex:

  if(condicao) { // Caso seja verdadeiro
  ...
  }

  if(condicao) //Caso seja verdadeiro;
  ...   //Caso só haja uma linha, não precisa de chaves;

  

  ---

  Ex:

  if(condicao) { // caso seja verdadeiro
  } else {  // Caso seja falso
  ...
  }

  if(condicao) //Caso seja verdadeiro
  ...  //Caso só haja uma linha, não precisa de chaves
  else //Caso seja falso
  ...

  

  ====================================================================

  

  #### ESTRUTURA CONDICIONAL SWITCH:

  

* Utilizado quando temos muitas decisões;
* Executado em cascata;
* Devemos parar manualmente a execução com o comando BREAK;
* Possui uma execução padrão chamada 'default';

  

  #### Ex:

  

  int valor = 1;
  switch (valor)
  {
  case 1: Console.WriteLine("1"); break;
  case 2: Console.WriteLine("2"); break;
  case 3: Console.WriteLine("3"); break;
  default: Console.WriteLine("4"); break;  //Se não for nenhum acima, será esse;

  

  =====================================================================

  

  #### LAÇOS DE REPETIÇÃO: FOR

  

* Tradução "para", ou seja, para cada item em um valor;
* Executa uma determinada ação várias vezes;
* Definido pela palavra 'for';
* Exige 3 parâmetros:

  * Contador;
  * Condição;
  * Incremento;



  #### Ex:

  

  for (var i = 0; i <=5; i++)

  

  

  #### Ex:

  

  //Conta de 0 a 5

  for (var i = 0; i <= 5; i++)
  Console.WriteLine(i);

  //Conta de 1 a 5

  for (var i = 1; i <=5; i++)
  Console.WriteLine(i);

  //Conta de 0 a 4

  for (var i = 0; i < 5; i++)
  Console.WriteLine(i);

  //Conta de 5 a 0

  for (var i = 5; i >= 0; i--)
  Console.WriteLine(i);

  

  

  ====================================================================

  

  #### LAÇOS DE REPETIÇÃO: WHILE

  

* Tradução de 'enquanto', ou seja, enquanto uma condição for verdadeira...
* Definido pela palavra 'while';
* Exige apenas uma condição;
* Checa a condição ANTES de executar;

  

  #### Ex:

  

  //Conta de 0 a 5
  //Exibe de 0 a 5 na tela

  var valor = 0;

  while (valor <=5)

  {
  Console.WriteLine(valor);
  valor++;
  }

  

  ======================================================================

  

  #### LAÇOS DE REPETIÇÃO: DO/WHILE

  

* Tradução: "Faça", ou seja, realiza uma ação enquanto...
* Definido pela palavra "do/while";
* Exige apenas uma condição no while;
* Checa a condição DEPOIS de executar;

  

  #### Ex:

  

  var valor = 0

  do
  {
  Console.WriteLine("Teste");
  valor++;
  } while (valor < 5);

  

  

  =====================================================================

  

  #### MÉTODOS E FUNÇÕES:

  

* Podemos segmentar nosso programa em funções;
* Também conhecidos como métodos;
* O 'Main' é um exemplo de método;
* Possui um retorno, um nome e parâmetros;
* Esta composição é chamada de assinatura;
* Começam sempre com maiúscula.

  

  #### Ex:

  

  static void Main(string\[] args)
  {
  // Invocação do método
  MeuMetodo("C# é legal");
  }

  // Definição do Método
  static void MeuMetodo(string parametro)
  {
  Console.WriteLine(parametro);
  }

  

  ---

  #### Ex:

  //Definição do método
  //Retorna uma string e recebe vários parâmetros

  static string RetornaNome(string nome, string sobrenome)
  {
  //Retorna o nome e sobrenome
  return nome + " " + sobrenome;

  }

  

  ---

  static void Main(string\[] args)
  {

  //Invocação do método
  //Armazena o resultado em uma variável
  var nome = RetornaNome("Antonio", "Nunes");

  //Imprime o nome na tela
  Console.WriteLine(nome);

  }

  

  

  ====================================================================

  

  #### VALUE TYPES E REFERENCE TYPES:

  

* A memória é dividida em duas partes: 'Heap' e 'Stack';
* 'Heap' armazena os dados;
* 'Stack' armazena as referências para os dados;

  ---

* Qualquer tipo no .NET é tratado como:

  Tipo de Referência (Reference Type)
  Tipo de Valor (Value Type)

* Tipos de valor armazenam dados;
* São armazenados em um local da memória chamado 'Stack'

  ---

* Quando armazenamos um valor, a memória é alocada;
* Este espaço armazena o dado criado;
* Nossa variável acessa este dado diretamente;
* Se assimilarmos uma variável do tipo de valor a outra

  O valor será COPIADO
  Ambas serão independentes

* Built-in, structs, Enums;
* 'Garbage Collector' não acessa o Stack;

  

  #### Ex de Value Type ------------------------

  

  int x = 25;
  int y = x;  // Y é uma cópia de x
  Console.WriteLine(x);  // 25
  Console.WriteLine(y);  // 25
  x = 32;  // Somente x foi alterado
  Console.WriteLine(x);  // 32
  Console.WriteLine(y);  // 25

  

  ---

  

  #### Reference Types ------------------

  

* Armazenam o endereço do objeto que contém os dados;
* Não armazena os dados em si;
* São armazenados em um local da memória chamado de 'Heap';
* Ao assimilar uma variável:

  * Criará uma referência;
  * Aponta para a mesma informação;
  * Não são independentes;

* Quando não mais utilizados são marcados para exclusão;
* 'Garbage Collector' passa removendo todos eles;
* Classes, Objects, Arrays...

  

  #### Ex de Reference Type -----------------------------

  

  var arr = new string\[2];
  arr\[0] = "Item 1";
  var arr2 = arr; // Não cria uma cópia

  Console.WriteLine(arr\[0]);
  Console.WriteLine(arr2\[0]);

  // Altera as duas listas
  arr\[0] = "Item Alterado";
  Console.WriteLine(arr\[0]);
  Console.WriteLine(arr2\[0]);

  

  

  ========================================================================

  

  #### STRUCTS:

  

* Tipos de dado estruturado;
* Apenas a estrutura, o esqueleto;
* Tipo de valor;
* Armazenam apenas outros tipos de dados;
* Definido pela palavra 'struct';
* Composto de propriedades e métodos;
* Nome sempre com maiúsculo;

  * O mesmo para propriedades e métodos;

* Criado a partir da palavra new;

  * Neste momento sim, temos os valores;

  

  #### ------- A anatomia de uma estrutura normalmente é:

  struct Product
  {
  //Propriedades
  //Métodos
  }

  

  

  #### -------- A anatomia de uma propriedade:

  struct Product
  {
  //Propriedades
  public int Id;

  &nbsp;	//Métodos

  }

  

  #### --------- Anatomia de um método

  struct Product
  {
  public int Id;
  public float Price;

  &nbsp;	public float PriceInDolar(float dolar)
    		{
    			return Price \\\* dolar;
    		}
    	

  }

  

  

  #### ------------ Para criar uma estrutura

  static void Main(string\[] args)
  {
  //Criar uma estrutura
  var product = new Product();
  }

  

  ---

* Vem com dados dos tipos padrão
* Para preencher os dados

  Ex:

  var product = new Product();
  product.Id = 1;
  product.Title = "Mouse gamer";
  product.Price = 197.23f;

  Console.WriteLine(product.Id);
  Console.WriteLine(product.Title);
  Console.WriteLine(product.Price);

  

  ---

  

* Método construtor é um método com mesmo nome da struct;

  

  struct Product
  {
  public Product(int id, string title, float price)
  {
  Id = id;
  Title = title;
  Price = price;
  }
  }

  

  ---

* Eles facilitam a criação de estruturas

  var product =  new Product(1, "Mouse Gamer", 128.75f);

  Console.WriteLine(product.Id);
  Console.WriteLine(product.Title);
  Console.WriteLine(product.Price);
  Console.WriteLine(product.PriceInDolar(5.70f));

  

  ===========================================================================================

