//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных
//   уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2
//    задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


int InputNumber(string str)
{
    int number;
    string text;

    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();

        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("ERROR, try again");
    }
    return number;
}

double b1 = InputNumber("Write number b1: ");
double k1 = InputNumber("Write number k1: ");
double b2 = InputNumber("Write number b2: ");
double k2 = InputNumber("Write number k2: ");


// (k1 * x) + b1 == (k2 * x) + b2;
// x(k1-k2)==b2-b1;
// x==(b2-b1)/(k1-k2);
// y=(k1*x)+b1

double x = (b2 - b1) / (k1 - k2);
double y = (k1 * x) + b1;
System.Console.WriteLine();
System.Console.WriteLine($"DOT: {(x, y)}");
