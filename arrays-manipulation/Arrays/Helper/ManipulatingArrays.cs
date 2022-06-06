namespace Arrays.Helper
{
    public class ManipulatingArrays
    {
        
        public void PrintArray(int[] array)
        {
            var linha = string.Join(", ", array);
            System.Console.WriteLine(linha);
        }
        public void BubbleSort(ref int[] array)
        {
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        public void Sort(ref int[] array)
        {
            Array.Sort(array);
        }
        public void CopyArray(ref int[] array, ref int[] arrayCopy)
        {
            Array.Copy(array, arrayCopy, array.Length);
        }
        public bool NumberExists(int[] array, int number)
        {
            return Array.Exists(array, elemento => elemento == number);
        }
        public bool AllGreaterThan(int[] array, int value)
        {
            return Array.TrueForAll(array, element => element > value);
        }
        public int GetValue(int[] array, int value)
        {
            return Array.Find(array, element => element == value);
        }
        public int FindExactIndex(int[] array, int value)
        {
            return Array.IndexOf(array, value);
        }
        public void ResizeArray(ref int[] array, int size)
        {
            Array.Resize(ref array, size);
        }
        public string[] ConvertAll(int[] array)
        {
            return Array.ConvertAll(array, element => element.ToString());
        }
    }
}