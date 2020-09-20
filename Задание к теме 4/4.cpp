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

    cout << "Сумма квадратов равна: " << a * a + b * b << "\n";
    cout << "Разность квадратов равна: " << a * a - b * b << "\n";
    cout << "Произведение квадратов равно: " << a * a * b * b << "\n";
    cout << "Частное квадратов равно: " << (a * a) / (b * b);

    return 0;
}