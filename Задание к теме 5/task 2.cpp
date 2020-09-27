#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "rus");
    float A, B, C, AC, BC;
    cout << "Введите расположение на числовой оси точек А В С: ";
    cin >> A >> B >> C;
    // длины отрезков АС и ВС
    AC = abs(A - C);
    BC = abs(B - C);

    cout << "\n" << "Сумма отрезков АС и ВС равна: " << AC + BC << "\n";
    return 0;
}