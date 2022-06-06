using System.Collections.Generic;

namespace Arrays.Helper
{
    public class OperationsList
    {
        public void PrintList(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                System.Console.WriteLine($"Índice {i}, Valor: {list[i]}");
            }
        }
    }
}