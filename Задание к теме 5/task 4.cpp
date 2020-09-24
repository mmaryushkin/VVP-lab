#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "rus");
    float x1, y1, x2, y2, a, b;

    // считываем координаты точек
    cout << "Введите координаты первой точки: ";
    cin >> x1 >> y1;
    cout << "Введите координаты второй точки: ";
    cin >> x2 >> y2;

    // считаем длины сторон
    a = abs(x2 - x1);
    b = abs(y2 - y1);

    cout << "Периметр прямоугольника равен: " << 2 * (a + b) << "\n";
    cout << "Площадь прямоугольника равна: " << a * b;
    return 0;
}