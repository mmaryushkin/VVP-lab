#include <iostream>

using namespace std;

float pointsDistance(float x1, float y1, float x2, float y2)
{
    float d;

    float s1 = pow((x2 - x1), 2); // первое слагаемое
    float s2 = pow((y2 - y1), 2); // второе слагаемое
    d = sqrt(s1 + s2);

    return d;
}


int main()
{
    setlocale(LC_ALL, "rus");
    float x1, y1, x2, y2, x3, y3, a, b, c, P, S;

    // считываем координаты точек треугольника
    cout << "Введите 1-ую вершину треугольника: ";
    cin >> x1 >> y1;

    cout << "\n" << "Введите 2-ю вершину треугольника: ";
    cin >> x2 >> y2;

    cout << "\n" << "Введите 3-ю вершину треугольника: ";
    cin >> x3 >> y3;

    // вычисление длин сторон треугольника 
    a = pointsDistance(x1, y1, x3, y3);
    b = pointsDistance(x1, y1, x2, y2);
    c = pointsDistance(x2, y2, x3, y3);

    P = a + b + c;
    cout << "\n" << "Периметр треугольника равен: " << P << "\n";

    // вычисление площади треугольника по формуле Герона
    S = sqrt(P/2 * (P/2 - a) * (P/2 - b) * (P/2 - c));
    cout << "Площадь треугольника равна: " << S << "\n";

    return 0;
}