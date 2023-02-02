Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

int a = number;
int reverse = 0;
int count = 0;


while (number > 0)
{
    int modulo = number % 10;
    reverse = reverse * 10 + modulo;
    number = number / 10;
    count++;
}

if (a == reverse && count == 5)
{
    Console.WriteLine("Это палиндром");
}
else if (count != 5)
{
    Console.WriteLine("Вы ввели не пятизначное число. Попробуйте еще раз");
}
else Console.WriteLine("Извините, но это не палиндром");




