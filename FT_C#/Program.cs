//Из заданного массива строк сформировать массив  строк, длина элементов которого менее или равно 3.

string[] mass = { "Monday", "3554", "hi", "next", "123", "lol", "<3", "нет"};

string[] ThreeMass(string[] mass)
{
    string[] new_mas = new string[1];
    int j = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i].Length <= 3)
        {
            Array.Resize(ref new_mas, 1 + j);
            new_mas[j] = mass[i];
            j++;
        }
    }
    return new_mas;
}
Console.WriteLine("Массив, длина элементов которого меньше или равна 3 -");
Console.WriteLine(String.Join("|", ThreeMass(mass)));