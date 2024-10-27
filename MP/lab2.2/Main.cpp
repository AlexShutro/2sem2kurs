// Main      
#include <iostream>
#include <tchar.h>
#include "Combi2.h"

using std::cout;
using std::endl;

int _tmain(int argc, _TCHAR* argv[])
{
	// Установка локали на русскую
	setlocale(LC_ALL, "rus");

	// Определение исходного множества
	char  AA[][2] = { "A", "B", "C", "D" };

	// Вывод информации об исходном множестве
	cout << endl << " --- Генератор сочетаний ---";
	cout << endl << "Исходное множество: ";
	cout << "{ ";
	for (int i = 0; i < sizeof(AA) / 2; i++)
		cout << AA[i] << ((i < sizeof(AA) / 2 - 1) ? ", " : " ");
	cout << "}";

	// Вывод информации о генерации сочетаний
	cout << endl << "Генерация сочетаний ";

	// Создание объекта xcombination для генерации сочетаний
	combi2::xcombination xc(sizeof(AA) / 2, 3);
	cout << "из " << xc.n << " по " << xc.m;

	// Получение и вывод первого сочетания
	int n = xc.getfirst();
	while (n >= 0)
	{
		cout << endl << xc.nc << ": { ";
		for (int i = 0; i < n; i++)
			cout << AA[xc.ntx(i)] << ((i < n - 1) ? ", " : " ");
		cout << "}";
		n = xc.getnext();
	};

	// Вывод общего количества сочетаний
	cout << endl << "всего: " << xc.count() << endl;

	// Ожидание нажатия клавиши перед завершением программы
	system("pause");
	return 0;
}