#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "rus"); // подключение русского языка
    float a, b;

    // считываем числа a и b
    cout << "a = ";
    cin >> a;
    cout << "b = ";
    cin >> b;

    cout << "Сумма модулей чисел: " << abs(a) + abs(b) << "\n";
    cout << "Разность модулей чисел: " << abs(a) - abs(b) << "\n";
    cout << "Произведение модулей чисел: " << abs(a) * abs(b) << "\n";
    cout << "Частное модулей чисел: " << abs(a) / abs(b) << "\n";

    return 0; 
}