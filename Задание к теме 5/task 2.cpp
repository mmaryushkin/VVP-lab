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
    float Ax, Ay, Bx, By, Cx, Cy;

    // считываем координаты точке
    cout << "Введите координаты точки А: ";
    cin >> Ax >> Ay;

    cout << "Введите координаты точки В: ";
    cin >> Bx >> By;

    cout << "Введите координаты точки С: ";
    cin >> Cx >> Cy;

    // вычисление длин отрезков АС и ВС
    float AC = pointsDistance(Ax, Ay, Cx, Cy);
    float BC = pointsDistance(Bx, By, Cx, Cy);

    cout << "Сумма отрезков АС и ВС равна: " << AC + BC;
    return 0;
}