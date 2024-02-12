// Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.
// Семинар 7. Рекурсия
// Пример
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 
int[] array = {1, 2, 5, 0, 10, 34};
int size = array.Length;
void ShowArray (int[] arr,int size)
{
    
    if (size==0)
    {
        return;
    }
    Console.Write(arr[size-1]+" ");

    ShowArray (arr,size-1);
}
   ShowArray (array,size);