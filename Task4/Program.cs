// Домашнее задание

// Считать с консоли строку, состоящую из цифр и латинских букв. 
// Сформировать массив, состоящий из цифр этой строки.

// Пример:
// abc123def06g => [1, 2, 3, 0, 6]

// Рекомендации:
// • Разделить логику алгоритма на функции
// • Память под массив выделять необходимого
// размера (не больше, чем количество элементов)

int[] GetDigitsFromString(string s)
{
    int count = CountDigits(s);
    int[] digits = new int[count];
    int index = 0;

    foreach (char c in s)
    {
        if (char.IsDigit(c))
        {
            digits[index] = c - '0';
            index++;
        }
    }

    return digits;
}

int CountDigits(string s)
{
    int count = 0;
    foreach (char c in s)
    {
        if (char.IsDigit(c))
        {
            count++;
        }
    }
    return count;
}

string input = Console.ReadLine();
int[] digitsArray = GetDigitsFromString(input);
Console.WriteLine(string.Join(", ", digitsArray));