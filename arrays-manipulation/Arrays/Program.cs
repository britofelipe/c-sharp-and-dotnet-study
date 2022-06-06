using System;
using Arrays.Helper;
using System.Collections.Generic;

// int[] arrayInteiros = new int[3];
// arrayInteiros[0] = 10;
// arrayInteiros[1] = 20;
// arrayInteiros[2] = int.Parse("30");

// System.Console.WriteLine("Percorrendo o array pelo for");
// for (int i = 0; i < arrayInteiros.Length; i++)
// {
//     System.Console.WriteLine(arrayInteiros[i]);
// }

// System.Console.WriteLine("Percorrendo o array pelo foreach:");
// foreach (var numero in arrayInteiros)
// {
//     System.Console.WriteLine(numero);
// }

// int[,] matriz = new int[4, 2]
// {
//     { 0, 0 },
//     { 10, 10 },
//     { 20, 20 },
//     { 30, 30 },
// };

// for (int i = 0; i < matriz.GetLength(0); i++)
// {
//     for (int j = 0; j < matriz.GetLength(1); j++)
//     {
//         System.Console.WriteLine(matriz[i, j]);
//     }
// }

// ManipulatingArrays op = new ManipulatingArrays();

// int[] array = { 9, 1, 5, 3, 7};
// // int[] arrayCopy = new int[10];

// System.Console.WriteLine("Array Inicial: ");
// op.PrintArray(array);

// op.CopyArray(ref array, ref arrayCopy);
// System.Console.WriteLine("Array Rearranjado: ");
// // op.BubbleSort(ref array);
// op.Sort(ref array);
// op.PrintArray(array);
// System.Console.WriteLine("Array Cópia do original: ");
// op.PrintArray(arrayCopy);

// int numberSearched = 2;
// bool exists = op.NumberExists(array, numberSearched);
// if (exists)
// {
//     System.Console.WriteLine($"Encontrei o valor {numberSearched}!");
// }
// else 
// {
//     System.Console.WriteLine($"Não encontrei o valor {numberSearched} :(");
// }

// System.Console.WriteLine(op.AllGreaterThan(array, 0)); 

// int valueSearched = 7;
// int valueFound = op.GetValue(array, valueSearched);

// if (valueFound > 0)
// {
//     System.Console.WriteLine("Encontrei o valor");
// }
// else 
// {
//     System.Console.WriteLine("Não encontrei o valor");
// }

// int indexFound = op.FindExactIndex(array, valueSearched);
// System.Console.WriteLine(indexFound);

// System.Console.WriteLine($"Capacidade atual do array: {array.Length}");
// op.ResizeArray(ref array, array.Length*2);
// System.Console.WriteLine($"Capacidade do array redimensionado: {array.Length}");

// string[] arrayString = op.ConvertAll(array);
// foreach (var item in arrayString)
// {
//     System.Console.WriteLine(item);
// }

OperationsList opList = new OperationsList();

// List<string> states = new List<string>();
// states.Add("SP");
// states.Add("MG");
// states.Add("BA");

// System.Console.WriteLine($"Quantidade de elementos na lista: {states.Count}");

// foreach (var item in states)
// {
//     System.Console.WriteLine(item);
// }

// for (int i = 0; i < states.Count; i++)
// {
//     System.Console.WriteLine($"Índice {i}, Valor: {states[i]}");
// }

// opList.PrintList(states);
// System.Console.WriteLine("Removendo elemento: ");
// states.Remove("MG");
// opList.PrintList(states);

// string[] statesArray = new string[2] {"SC", "MT"};

// states.AddRange(statesArray);
// opList.PrintList(states);

// states.Insert(2, "RJ");
// opList.PrintList(states);

// Queue<string> fifo = new Queue<string>();
// fifo.Enqueue("Felipe");
// fifo.Enqueue("Brito");

// System.Console.WriteLine($"Pessoas na fila: {fifo.Count()}");

// while (fifo.Count > 0)
// {
//     System.Console.WriteLine($"Vez de: {fifo.Peek()}");
//     System.Console.WriteLine($"{fifo.Dequeue()} atendido");
// }

// Stack<string> stackBooks = new Stack<string>();
// stackBooks.Push("A menina que roubava livros");
// stackBooks.Push("O milagre da manhã");
// stackBooks.Push("The four-hour workweek");
// stackBooks.Push("Atomic habits");

// while (stackBooks.Count > 0)
// {
//     System.Console.WriteLine($"Next book: {stackBooks.Peek()}");
//     System.Console.WriteLine($"{stackBooks.Pop()} read sucessfully");
// }

// Dictionary<string, string> states = new Dictionary<string, string>();
// states.Add("SP", "São Paulo");
// states.Add("MG", "Minas Gerais");
// states.Add("BA", "Bahia");

// foreach (KeyValuePair<string, string> item in states)
// {
//     System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// string value = "CE";

// System.Console.WriteLine(states[value]);

// states[value] = "BA - Bahia atualizada";
// System.Console.WriteLine(states[value]);

// System.Console.WriteLine($"Removendo o valor: {value}");
// states.Remove(value);

// foreach (KeyValuePair<string, string> item in states)
// {
//     System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// if (states.TryGetValue(value, out string stateFound))
// {
//     System.Console.WriteLine(stateFound);
// }
// else
// {
//     System.Console.WriteLine($"Chave {value} não existe no dicionário");
// }

// var evenNumbersQuerry = 
//     from num in array
//     where num % 2 ==0
//     orderby num
//     select num;

// var evenNumbersMethod = array.Where(x => x % 2 ==0).OrderBy(x => x).ToList();

// System.Console.WriteLine("Números pares query: " + string.Join(", ", evenNumbersQuerry));
// System.Console.WriteLine("Números pares query: " + string.Join(", ", evenNumbersMethod));

int[] array = new int[10] { 100, 1, 4, 0, 8, 15, 1, 19, 4, 100 };

var minimum = array.Min();
var maximum = array.Max();
var  average = array.Average();
var sum = array.Sum();
var distinct = array.Distinct();

System.Console.WriteLine($"Mínimo: {minimum}");
System.Console.WriteLine($"Máximo: {maximum}");
System.Console.WriteLine($"Média: {average}");
System.Console.WriteLine($"Soma: {sum}");
System.Console.WriteLine($"Original: {string.Join(", ", array)}");
System.Console.WriteLine($"Não repetidos: {string.Join(", ", distinct)}");