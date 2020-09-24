#include <iostream>

using namespace std;

int main()
{
    // Формула: d = sqrt((x2 - x1)^2 + (y2 - y1)^2)
    float x1, x2, y1, y2, d;
    setlocale(LC_ALL, "rus");

    // считываем координаты точек
    cout << "Введите координаты первой точки: ";
    cin >> x1 >> y1;
    cout << "Введите координаты второй точки: ";
    cin >> x2 >> y2;

    // вычисление расстояния между точками
    float s1 = pow((x2 - x1), 2); // первое слагаемое
    float s2 = pow((y2 - y1), 2); // второе слагаемое
    d = sqrt(s1 + s2);

    cout << "Расстояние между точками равно: " << d;
    return 0;
}