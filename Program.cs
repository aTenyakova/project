// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам.

string[] arrayOne = new string[5] {"1", "12", "123", "1234", "12345"};
string[] arrayTwo = new string[arrayOne.Length];

void GetArray(string[] arrayOne, string[] arrayTwo)
{
    int count = 0;
    for (int i = 0; i < arrayOne.Length; i++)
    {
        if (arrayOne[i].Length < 4)
        {
            arrayTwo[count] = arrayOne[i];
            count++;
        }
    }
}