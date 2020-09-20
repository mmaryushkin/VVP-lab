#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "rus"); // подключение русского языка
    float a, b, s;

    // считываем числа a и b
    cout << "a = ";
    cin >> a;
    cout << "b = ";
    cin >> b;

    // вычисляем и выводим на экран сред. арифметическое чисел a и b
    s = (a + b) / 2;
    cout << "Среднее арифметическое равно: " << s;
    return 0;
}