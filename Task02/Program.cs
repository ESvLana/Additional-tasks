// Михаил интересуется созданием простых чисел. Его интересуют простые числа с некоторыми характеристиками:
// • число сгенерировано случайным образом;
// • его квадрат не оканчивается на 1;
// • сумма его цифр лежит в диапазоне от 10 до 20
// Сгенерировать пять простых чисел, удовлетворяющих пожеланиям Михаила, и вывести их на экран.
// Пример
// 97 397 83 317 383

// Random rnd = new Random();
// int value = rnd.Next(1, 500);
// Console.WriteLine(value);

int SquaringNumder(Number)
{
    double d = Math.Pow(Number, 2);
    return d;
}

int SumOfDigits(Number)
{
    int Sum = 0;
    while(Number > 0)
    {
        Sum = Sum + Number % 10;
        Number = Number / 10;
    }
    return Sum;
}

void PrintRedult(value)

Random rnd = new Random();
int value = rnd.Next(1, 500);
Console.WriteLine(value);

int Square = SquaringNumder(value);
int Sum = SumOfDigits(value);

bool!
