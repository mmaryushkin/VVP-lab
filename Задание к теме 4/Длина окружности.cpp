#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "rus"); // подключение русского языка
    float d, L;
    float const pi = 3.14;

    // считываем диаметр окружности
    cout << "Введите диаметр окружности: ";
    cin >> d;

    // вычисляем и выводим на экран длину окружности
    L = pi * d;
    cout << "Длина окружности равна: " << L;
    return 0;
}