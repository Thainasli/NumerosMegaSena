using System;
using System.Collections.Generic;

class Program
{
    static void Main(String[]args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("qual número mais repetido você deseja saber?");
        Console.WriteLine("1 = casa 1"); 
        Console.WriteLine("2 = casa 2"); 
        Console.WriteLine("3 = casa 3"); 
        Console.WriteLine("4 = casa 4"); 
        Console.WriteLine("5 = casa 5"); 
        Console.WriteLine("6 = casa 6"); 
        Console.WriteLine("7 = Os 10 numeros que mais se repetiram durante o ano"); 
        Console.WriteLine("0 = Sair");

        Console.WriteLine("-------------------------"); 
        Console.WriteLine("Selecione uma opção: "); 

        short res = short.Parse(Console.ReadLine());
       
        switch (res)
        {
            case 1: Casa1(); break;
            case 2: Casa2(); break;
            case 3: Casa3(); break;
            case 4: Casa4(); break;
            case 5: Casa5(); break;
            case 6: Casa6(); break;
            case 7: Total(); break;
            case 0: Console.WriteLine("A aplicação será encerrada. Obrigado por usar!");
                    System.Environment.Exit(0); break;
            default: Menu(); break;
        }
    }

    static void Casa1()
    {
        Console.Clear();

         List<int> listaNumeros = new List<int>
        {
            9, 2, 1, 15, 11, 1, 13, 18, 14, 2, 13, 8, 10, 9, 21, 28, 10, 15, 15, 16,
            8, 3, 11, 2, 3, 2, 1, 22, 5, 8, 8, 5, 15, 22, 1, 2, 20, 2, 10, 4, 1, 1,
            20, 11, 5, 8, 23, 17, 3, 11, 22, 10, 4, 1, 8, 7, 5, 9, 11, 5, 11, 16, 3,
            14, 3, 21, 4, 41, 8, 8, 4, 7, 13, 5, 3, 8, 1, 3, 3, 2, 23, 4, 1, 3, 4, 2,
            8, 4, 3, 14, 1, 10, 17, 28, 1, 9, 12, 6, 1, 2, 10, 12, 2, 25, 20, 3, 10, 9, 1
        };

        Dictionary<int, int> contagemNumeros = new Dictionary<int, int>();

        foreach (int numero in listaNumeros)
        {
            if (contagemNumeros.ContainsKey(numero))
            {
                contagemNumeros[numero]++;
            }
            else
            {
                contagemNumeros[numero] = 1;
            }
        }

        int numeroMaisRepetido = 0;
        int contagemMaisAlta = 0;

        foreach (KeyValuePair<int, int> par in contagemNumeros)
        {
            if (par.Value > contagemMaisAlta)
            {
                numeroMaisRepetido = par.Key;
                contagemMaisAlta = par.Value;
            }
        }


        Console.WriteLine($"O número {numeroMaisRepetido} é o mais frequente, aparecendo {contagemMaisAlta} vezes nesta posição no ano de 2022.");
        Console.ReadKey();
        Menu();
    }

    static void Casa2()
    {
       
        Console.Clear();

        List<int> listaNumeros = new List<int>
        {
            41, 7, 5, 17, 25, 13, 19, 30, 20, 6, 26, 10, 14, 14, 38, 34, 19, 40, 24,
            17, 11, 16, 16, 7, 8, 3, 10, 35, 28, 33, 23, 13, 18, 30, 40, 7, 33, 17, 15, 
            6, 8, 32, 34, 14, 12, 9, 36, 31, 10, 16, 29, 30, 9, 4, 12, 26, 14, 12, 19, 16,
            27, 20, 14, 33, 5, 22, 6, 45, 37, 13, 10, 10, 19, 15, 12, 17, 5, 22, 8, 17, 28,
            5, 10, 20, 13, 16, 19, 15, 5, 17, 5, 14, 18, 36, 3, 22, 24, 15, 23, 8, 28, 20, 5, 38,
            23, 23, 25, 15, 6
        };

        Dictionary<int,int> contagemNumeros = new Dictionary<int,int>();
         foreach (int numero in listaNumeros)
        {
            if (contagemNumeros.ContainsKey(numero))
            {
                contagemNumeros[numero]++;
            }
            else
            {
                contagemNumeros[numero] = 1;
            }
        }

        int numeroMaisRepetido = 0;
        int contagemMaisAlta = 0;

        foreach (KeyValuePair<int, int> par in contagemNumeros)
        {
            if (par.Value > contagemMaisAlta)
            {
                numeroMaisRepetido = par.Key;
                contagemMaisAlta = par.Value;
            }
        }

        Console.WriteLine($"O número {numeroMaisRepetido} é o mais frequente, aparecendo {contagemMaisAlta} vezes nesta posição no ano de 2022.");
        Console.ReadKey();
        Menu();
    }

    static void Casa3()
    {
        Console.Clear();

        List<int> listaNumeros = new List<int>
        {
            42, 9, 12, 20, 32, 27, 29, 32, 21, 11, 31, 51, 15, 22, 50, 40, 56, 44, 33, 
            18, 16, 23, 31, 24, 23, 13, 19, 41, 30, 40, 29, 18, 28, 38, 44, 32, 37, 23, 17, 
            9, 21, 35, 38, 36, 32, 17, 42, 34, 13, 17, 38, 31, 37, 10, 14, 31, 23, 26, 38, 
            25, 32, 21, 16, 41, 19, 29, 12, 48, 39, 25, 15, 34, 21, 24, 19, 49, 6, 23, 20, 22, 
            33, 25, 27, 22, 21, 24, 29, 22, 32, 18, 18, 17, 20, 39, 24, 27, 26, 19, 32, 28, 45, 22, 
            27, 45, 32, 28, 31, 23, 10

        };

        Dictionary<int,int> contagemNumeros = new Dictionary<int,int>();
         foreach (int numero in listaNumeros)
        {
            if (contagemNumeros.ContainsKey(numero))
            {
                contagemNumeros[numero]++;
            }
            else
            {
                contagemNumeros[numero] = 1;
            }
        }

        int numeroMaisRepetido = 0;
        int contagemMaisAlta = 0;

        foreach (KeyValuePair<int, int> par in contagemNumeros)
        {
            if (par.Value > contagemMaisAlta)
            {
                numeroMaisRepetido = par.Key;
                contagemMaisAlta = par.Value;
            }
        }
        
        Console.WriteLine($"O número {numeroMaisRepetido} é o mais frequente, aparecendo {contagemMaisAlta} vezes nesta posição no ano de 2022.");
        Console.ReadKey();
        Menu();
    }
    
    static void Casa4()
    {
        Console.Clear();

        List<int> listaNumeros = new List<int>
        {
            46, 25, 13, 35, 37, 41, 42, 35, 31, 15, 46, 56, 14, 24, 53, 41, 47, 45, 49,
            28, 21, 41, 37, 43, 29, 20, 34, 42, 38, 42, 30, 23, 42, 39, 45, 46, 38, 28, 20,
            31, 27, 44, 40, 41, 38, 19, 48, 40, 25, 41, 43, 33, 43, 22, 30, 38, 46, 29, 47,
            32, 40, 39, 38, 42, 26, 34, 34, 51, 50, 32, 39, 47, 35, 34, 41, 51, 16, 44, 36,
            41, 38, 32, 36, 37, 26, 38, 38, 53, 56, 28, 49, 18, 37, 44, 37, 30, 31, 20, 33, 
            34, 47, 25, 30, 53, 36, 34, 37, 25, 30
 
        };

        Dictionary<int,int> contagemNumeros = new Dictionary<int,int>();
         foreach (int numero in listaNumeros)
        {
            if (contagemNumeros.ContainsKey(numero))
            {
                contagemNumeros[numero]++;
            }
            else
            {
                contagemNumeros[numero] = 1;
            }
        }

        int numeroMaisRepetido = 0;
        int contagemMaisAlta = 0;

        foreach (KeyValuePair<int, int> par in contagemNumeros)
        {
            if (par.Value > contagemMaisAlta)
            {
                numeroMaisRepetido = par.Key;
                contagemMaisAlta = par.Value;
            }
        }

        Console.WriteLine($"O número {numeroMaisRepetido} é o mais frequente, aparecendo {contagemMaisAlta} vezes nesta posição no ano de 2022.");
        Console.ReadKey();
        Menu();
    }

    static void Casa5()
    {
        Console.Clear();

        List<int> listaNumeros = new List<int>
        {
            47, 41, 17, 37, 47, 51, 49, 40, 49, 17, 51, 57, 34, 44, 56, 52, 49, 47, 53, 
            35, 32, 45, 42, 52, 53, 53, 35, 53, 52, 48, 36, 35, 55, 49, 58, 49, 49, 39, 21,
            50, 36, 45, 49, 54, 47, 33, 54, 56, 41, 46, 48, 42, 44, 53, 33, 46, 48, 46, 56,
            39, 58, 44, 43, 44, 43, 40, 35, 53, 59, 44, 41, 49, 46, 45, 45, 52, 22, 53, 38,
            58, 55, 39, 37, 41, 47, 43, 48, 56, 57, 30, 55, 23, 45, 56, 51, 33, 37, 33, 36,
            41, 57, 26, 46, 55, 39, 38, 38, 29, 33

        };

        Dictionary<int,int> contagemNumeros = new Dictionary<int,int>();
         foreach (int numero in listaNumeros)
        {
            if (contagemNumeros.ContainsKey(numero))
            {
                contagemNumeros[numero]++;
            }
            else
            {
                contagemNumeros[numero] = 1;
            }
        }

        int numeroMaisRepetido = 0;
        int contagemMaisAlta = 0;

        foreach (KeyValuePair<int, int> par in contagemNumeros)
        {
            if (par.Value > contagemMaisAlta)
            {
                numeroMaisRepetido = par.Key;
                contagemMaisAlta = par.Value;
            }
        }

        Console.WriteLine($"O número {numeroMaisRepetido} é o mais frequente, aparecendo {contagemMaisAlta} vezes nesta posição no ano de 2022.");
        Console.ReadKey();
        Menu();
    }
 
    static void Casa6()
    {
       
        Console.Clear();

        List<int> listaNumeros = new List<int>
        {
            54, 49, 31, 43, 56, 58, 52, 48, 52, 39, 60, 58, 44, 47, 59, 55, 50, 51, 59, 47, 
            37, 57, 51, 56, 54, 54, 45, 57, 55, 51, 55, 36, 60, 56, 60, 55, 50, 46, 35, 56, 
            37, 57, 54, 59, 60, 56, 58, 57, 42, 59, 53, 52, 56, 54, 41, 58, 52, 47, 59, 55, 
            59, 55, 45, 55, 51, 44, 53, 58, 60, 57, 49, 52, 50, 52, 54, 53, 39, 60, 57, 60, 
            59, 40, 45, 43, 51, 59, 56, 60, 59, 44, 56, 30, 53, 60, 56, 45, 48, 52, 59, 49, 
            59, 55, 53, 56, 57, 48, 57, 30, 35

        };

        Dictionary<int,int> contagemNumeros = new Dictionary<int,int>();
         foreach (int numero in listaNumeros)
        {
            if (contagemNumeros.ContainsKey(numero))
            {
                contagemNumeros[numero]++;
            }
            else
            {
                contagemNumeros[numero] = 1;
            }
        }

        int numeroMaisRepetido = 0;
        int contagemMaisAlta = 0;

        foreach (KeyValuePair<int, int> par in contagemNumeros)
        {
            if (par.Value > contagemMaisAlta)
            {
                numeroMaisRepetido = par.Key;
                contagemMaisAlta = par.Value;
            }
        }

        Console.WriteLine($"O número {numeroMaisRepetido} é o mais frequente, aparecendo {contagemMaisAlta} vezes nesta posição no ano de 2022.");
        Console.ReadKey();
        Menu();

    }

    static void Total()
    {
        Console.Clear();

        List<int> listaNumeros = new List<int>
        {
            54, 49, 31, 43, 56, 58, 52, 48, 52, 39, 60, 58, 44, 47, 59, 55, 50, 51, 59, 47, 
            37, 57, 51, 56, 54, 54, 45, 57, 55, 51, 55, 36, 60, 56, 60, 55, 50, 46, 35, 56, 
            37, 57, 54, 59, 60, 56, 58, 57, 42, 59, 53, 52, 56, 54, 41, 58, 52, 47, 59, 55, 
            59, 55, 45, 55, 51, 44, 53, 58, 60, 57, 49, 52, 50, 52, 54, 53, 39, 60, 57, 60, 
            59, 40, 45, 43, 51, 59, 56, 60, 59, 44, 56, 30, 53, 60, 56, 45, 48, 52, 59, 49, 
            59, 55, 53, 56, 57, 48, 57, 30, 35, 47, 41, 17, 37, 47, 51, 49, 40, 49, 17, 51, 57, 34, 44, 56, 52, 49, 47, 53, 
            35, 32, 45, 42, 52, 53, 53, 35, 53, 52, 48, 36, 35, 55, 49, 58, 49, 49, 39, 21,
            50, 36, 45, 49, 54, 47, 33, 54, 56, 41, 46, 48, 42, 44, 53, 33, 46, 48, 46, 56,
            39, 58, 44, 43, 44, 43, 40, 35, 53, 59, 44, 41, 49, 46, 45, 45, 52, 22, 53, 38,
            58, 55, 39, 37, 41, 47, 43, 48, 56, 57, 30, 55, 23, 45, 56, 51, 33, 37, 33, 36,
            41, 57, 26, 46, 55, 39, 38, 38, 29, 33, 46, 25, 13, 35, 37, 41, 42, 35, 31, 15, 46, 56, 14, 24, 53, 41, 47, 45, 49,
            28, 21, 41, 37, 43, 29, 20, 34, 42, 38, 42, 30, 23, 42, 39, 45, 46, 38, 28, 20,
            31, 27, 44, 40, 41, 38, 19, 48, 40, 25, 41, 43, 33, 43, 22, 30, 38, 46, 29, 47,
            32, 40, 39, 38, 42, 26, 34, 34, 51, 50, 32, 39, 47, 35, 34, 41, 51, 16, 44, 36,
            41, 38, 32, 36, 37, 26, 38, 38, 53, 56, 28, 49, 18, 37, 44, 37, 30, 31, 20, 33, 
            34, 47, 25, 30, 53, 36, 34, 37, 25, 30, 42, 9, 12, 20, 32, 27, 29, 32, 21, 11, 31, 51, 15, 22, 50, 40, 56, 44, 33, 
            18, 16, 23, 31, 24, 23, 13, 19, 41, 30, 40, 29, 18, 28, 38, 44, 32, 37, 23, 17, 
            9, 21, 35, 38, 36, 32, 17, 42, 34, 13, 17, 38, 31, 37, 10, 14, 31, 23, 26, 38, 
            25, 32, 21, 16, 41, 19, 29, 12, 48, 39, 25, 15, 34, 21, 24, 19, 49, 6, 23, 20, 22, 
            33, 25, 27, 22, 21, 24, 29, 22, 32, 18, 18, 17, 20, 39, 24, 27, 26, 19, 32, 28, 45, 22, 
            27, 45, 32, 28, 31, 23, 10,  41, 7, 5, 17, 25, 13, 19, 30, 20, 6, 26, 10, 14, 14, 38, 34, 19, 40, 24,
            17, 11, 16, 16, 7, 8, 3, 10, 35, 28, 33, 23, 13, 18, 30, 40, 7, 33, 17, 15, 
            6, 8, 32, 34, 14, 12, 9, 36, 31, 10, 16, 29, 30, 9, 4, 12, 26, 14, 12, 19, 16,
            27, 20, 14, 33, 5, 22, 6, 45, 37, 13, 10, 10, 19, 15, 12, 17, 5, 22, 8, 17, 28,
            5, 10, 20, 13, 16, 19, 15, 5, 17, 5, 14, 18, 36, 3, 22, 24, 15, 23, 8, 28, 20, 5, 38,
            23, 23, 25, 15, 6, 9, 2, 1, 15, 11, 1, 13, 18, 14, 2, 13, 8, 10, 9, 21, 28, 10, 15, 15, 16,
            8, 3, 11, 2, 3, 2, 1, 22, 5, 8, 8, 5, 15, 22, 1, 2, 20, 2, 10, 4, 1, 1,
            20, 11, 5, 8, 23, 17, 3, 11, 22, 10, 4, 1, 8, 7, 5, 9, 11, 5, 11, 16, 3,
            14, 3, 21, 4, 41, 8, 8, 4, 7, 13, 5, 3, 8, 1, 3, 3, 2, 23, 4, 1, 3, 4, 2,
            8, 4, 3, 14, 1, 10, 17, 28, 1, 9, 12, 6, 1, 2, 10, 12, 2, 25, 20, 3, 10, 9, 1
        };

        Dictionary<int, int> contagemNumeros = new Dictionary<int, int>();

       
        foreach (int numero in listaNumeros)
        {
            if (contagemNumeros.ContainsKey(numero))
            {
                contagemNumeros[numero]++;
            }
            else
            {
                contagemNumeros[numero] = 1;
            }
        }

        
        var numerosOrdenados = contagemNumeros.OrderByDescending(x => x.Value);

        
        Console.WriteLine("Os 10 números mais repetidos no ano de 2022 foram:");

        int contador = 0;
        foreach (var par in numerosOrdenados)
        {
            Console.WriteLine($"Número: {par.Key}, aparecendo: {par.Value} vezes");

            contador++;
            if (contador == 10)
                break;   
        }

        Console.ReadKey();
        Menu();
    }
}
          
