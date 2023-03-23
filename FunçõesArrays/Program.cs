namespace FunçõesArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite um número: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            while (true)
            {
                MostrarOpcoes();
                Console.Write("Digite o número da operação desejada: ");
                int opcao = Convert.ToInt32(Console.ReadLine());
                if (opcao == 0)
                {
                    Console.WriteLine("Saindo do programa!");
                    Console.ReadLine();
                    break;
                }

                if (opcao < 0 || opcao > 7)
                {
                    Console.WriteLine("Escolha uma das opções disponíveis!");
                    Console.ReadLine();
                }

                ExecutarOpcao(opcao, ref numeros);
            }
        }

        static void ExecutarOpcao(int opcao, ref int[] numeros)
        {
            Console.Clear();
            switch (opcao)
            {
                case 1:
                    EncontrarMaiorValor(numeros);
                    break;
                case 2:
                    EncontrarMenorValor(numeros);
                    break;
                case 3:
                    EncontrarValorMédio(numeros);
                    break;
                case 4:
                    EncontrarTresMaioresValores(numeros);
                    break;
                case 5:
                    EncontrarValoresNegativos(numeros);
                    break;
                case 6:
                    MostrarValores(numeros);
                    break;
                case 7:
                    RemoverValor(ref numeros);
                    break;
            }

            Console.ReadLine();
        }

        static void MostrarOpcoes()
        {
            Console.Clear();
            Console.WriteLine("1-Encontrar o maior valor da sequência");
            Console.WriteLine("2-Encontrar o menor valor da sequência");
            Console.WriteLine("3-Encontrar o valor médio da sequência");
            Console.WriteLine("4-Encontrar os 3 maiores valores da sequência");
            Console.WriteLine("5-Encontrar os valores negativos da sequência");
            Console.WriteLine("6-Mostrar na tela os valores da sequência ");
            Console.WriteLine("7-Remover um item da sequência ");
            Console.WriteLine("0-Sair");
        }

        static void EncontrarMaiorValor(int[] numeros)
        {
            int maiorValor = numeros[0];
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > maiorValor)
                {
                    maiorValor = numeros[i];
                }
            }

            Console.WriteLine("O maior valor é: " + maiorValor);
        }

        static void EncontrarMenorValor(int[] numeros)
        {
            int menorValor = numeros[0];
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < menorValor)
                {
                    menorValor = numeros[i];
                }
            }

            Console.WriteLine("O menor valor é: " + menorValor);
        }

        static void EncontrarTresMaioresValores(int[] numeros)
        {
            if (numeros.Length < 3)
            {
                Console.WriteLine("O array possui menos de 3 elementos!");
                return;
            }

            int[] numerosCopia = new int[numeros.Length];
            numeros.CopyTo(numerosCopia, 0);
            Array.Sort(numerosCopia);
            int[] maioresValores = { numerosCopia[numeros.Length - 1], numerosCopia[numeros.Length - 2], numerosCopia[numeros.Length - 3] };
            MostrarValores(maioresValores);
        }

        static void EncontrarValoresNegativos(int[] numeros)
        {
            Console.Write("Array Correspondente:");
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < 0)
                {
                    Console.Write(" " + numeros[i]);
                }
            }
        }

        static void MostrarValores(int[] numeros)
        {
            Console.Write("Array Correspondente:");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write(" " + numeros[i]);
            }
        }

        static void RemoverValor(ref int[] numeros)
        {
            Console.Write("Digite a posição que deseja remover: ");
            int posicao = Convert.ToInt32(Console.ReadLine()) - 1;
            if (posicao < 0 || numeros.Length <= posicao)
            {
                Console.WriteLine("Escolha uma posição que existe no Array!");
                return;
            }

            int[] novoArray = new int[numeros.Length - 1];
            int i = 0;
            for (int j = 0; j < numeros.Length; j++)
            {
                if (j != posicao)
                {
                    novoArray[i] = numeros[j];
                    i++;
                }
            }

            numeros = novoArray;
            MostrarValores(numeros);
        }

        static void EncontrarValorMédio(int[] numeros)
        {
            if (numeros.Length == 0)
            {
                Console.WriteLine("O array possui não possui elementos!");
                return;
            }

            int soma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }

            Console.WriteLine("O Valor médio do array é: " + (soma / numeros.Length));
        }

    }
}