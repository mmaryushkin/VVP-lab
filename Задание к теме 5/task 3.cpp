#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "rus");
    float A, B, C;
    cout << "Введите последовательно расположение точек A C B: ";
    cin >> A >> C >> B;

    cout << "\n" << "Произведение длин отрезков AC и BC равно: " << abs(C - A) * abs(C - B) << "\n";
    return 0;
}