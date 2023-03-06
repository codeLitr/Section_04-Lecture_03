/*
1. Найти позиции минимального элемента в неотсортированной части массива.
2. Произвести обмен этого значения со значением первой неотсортированной позиции.
3. Повторять пока есть неотсортированные элементы.
*/

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)// Создается метод для вывода на экран значений в массиве.
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}
void SelectionSort(int[] array)//Создается метод для сортировки массива и перестановки 
// значений от минимального до большего.
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
