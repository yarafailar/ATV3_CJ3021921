using System.ComponentModel.Design;
using System.Xml;

namespace ATV3_CJ3021921
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //Exercicio 1 lsita 3

            int n;

            Console.WriteLine("Digite um numero: ");
            n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("Ele é par!");
            }
            else
            {
                Console.WriteLine("Ele é impar!");
            }

            //Exercício 2 lista 3

            float l1, l2, l3;

            l1 = int.Parse(Console.ReadLine());
            l2 = int.Parse(Console.ReadLine());
            l3 = int.Parse(Console.ReadLine());

            if ((l1 + l2 > l3) && l2 + l3 > l1)
            {
                Console.WriteLine("È um triângulo!");


                if (l1 == l2 && l1 == l3)
                {
                    Console.WriteLine("é um triangulo equilátero");

                }
                if (l1 != l2 && l1 != l3)
                {
                    Console.WriteLine("È um triangulo escaleno");
                }
                else
                {
                    Console.WriteLine("Triangulo Isoceles");
                }
            }
            else
            {
                Console.WriteLine("Nao é um triangulo");
            }

            //Exercicio 3 lista 3

            int numero, tentativa;

            Random gerador = new Random();
            numero = gerador.Next(1, 100);
            Console.WriteLine("Entre com um numero de 1 a 100: ");
            tentativa = int.Parse(Console.ReadLine());
            if (numero == tentativa)
            {
                Console.WriteLine("Acertou de Primeira");
            }
            if (numero < tentativa)
            {
                Console.WriteLine("O numero é menor que {0}");
            }
            Console.WriteLine("Entre com um numero de 1 a 100: ");
            tentativa = int.Parse(Console.ReadLine());
            if (numero > tentativa)
            {
                Console.WriteLine("O numero é maior que {0}");
                Console.WriteLine("Entre com um numero de 1 a 100: ");
                tentativa = int.Parse(Console.ReadLine());
                if (numero == tentativa)
                {
                    Console.WriteLine("Acertou!");
                }
                else
                {
                    Console.WriteLine("Errou");
                }
            }

            //Exercício 4 

            string nome, senha;

            Console.WriteLine("Entre com o nome de usuario: ");
            nome = Console.ReadLine();
            Console.WriteLine("Entre com a senha de usuário");
            senha = Console.ReadLine();

            if (nome == "admin" && senha == "admin123")
            {
                Console.WriteLine("Acesso concedido");
            }

            //Exercício 5 lista 3

            int nota;

            Console.WriteLine("Digite uma nota de o a 100");
            nota = int.Parse(Console.ReadLine());

            if (nota >= 90 && nota <= 100)
            {
                Console.WriteLine("Nota A");
            }
            if (nota >= 80 && nota <= 89)
            {
                Console.WriteLine("Nota B");
            }
            if (nota >= 70 && nota <= 79)
            {
                Console.WriteLine("NOta C");
            }
            if (nota >= 60 && nota <= 69)
            {
                Console.WriteLine("Nota D");
            }

            else
            {
                Console.WriteLine("Nota F");
            }

            //Exercício 6 lista 3

            int jogador, computador;

            Console.WriteLine("Escolha: 1 - pedra, 2 - papel, 3- tesoura");
            jogador = int.Parse(Console.ReadLine());
            Random gerado = new Random();
            computador = gerador.Next(1, 3);
            if (computador == jogador)
            {
                Console.WriteLine("Empate");
            }
            else
            {
                if (computador == 1 && jogador == 2 || computador == 2 && jogador == 3 || computador == 3 && jogador == 1)
                {
                    Console.WriteLine("Jogador ganhou!");
                }
                else
                {
                    Console.WriteLine("Computador ganhou!");
                }
            }


            //Exercicio 7 lista 3

            float v;

            Console.WriteLine("Entre com o valor total da compra: ");
            v = float.Parse(Console.ReadLine());

            if (v >= 400)
            {
                Console.WriteLine("O desconto será de {0} e o total");
            }
            else
            {
                if (v > 300)
                {
                    Console.WriteLine("O descontpo será de {0}");

                    if (v >= 200)
                    {
                        Console.WriteLine("O desconto será de {0}");
                    }
                    else
                    {
                        if (v > 100)
                        {
                            Console.WriteLine("O desconto será {1}", v * 0.2f, v - (v * 0.2f));
                        }
                        else
                        {
                            Console.WriteLine("O desconto será {1}", v * 0.1f, v - (v * 0.1f));
                        }
                    }

                }
            }



            //Exercício 8 Lista 3

            float peso, altura, imc;

            Console.WriteLine("Entre com o seu peso em kg: ");
            peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Entre com a sua altura em metros: ");
            altura = float.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            if (imc < 18.5f)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else
            {
                if (imc >= 18.5f && imc <= 24.9f)
                {
                    Console.WriteLine("Peso normal");
                }
                {
                    if (imc <= 34.9f)
                    {
                        Console.WriteLine("Obesidade grau I");
                    }
                    else
                    {
                        if (imc <= 39.9f)
                        {
                            Console.WriteLine("Obesidade grau II");
                        }
                        else
                        {
                            Console.WriteLine("Obesidade grau III");
                        }
                    }
                }
            }

        }
    }
}


