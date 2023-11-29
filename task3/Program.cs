// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
int[] array = {9,28,32,19,90,1,22};
int length = array.Length-1;
void ArrayBack(int[] array, int i = 0)
{ 
    if(i < length)
    {       
       ArrayBack(array, i+1); 
    }
 Console.Write(array[i] + " ");
}
ArrayBack(array);