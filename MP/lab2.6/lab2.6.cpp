#include <iostream>
#include <iomanip>
#include <tchar.h>
#include "Boat.h"
#include <ctime>
#include "Auxil.h"
#define N1 25 // интервал кол-ва контейнеров
#define N2 35

#define NN 35
#define MM 6
int _tmain(int argc, _TCHAR* argv[])
{
    setlocale(LC_ALL, "rus");

    auxil::start();

    /*int NN = auxil::iget(N1, N2);*/

    int V = 1500;
    int* v = new int[NN];
    int* c = new int[NN];
    short  r[MM];
    clock_t t1 = 0, t2 = 0;

    for (int i = 0; i < NN; i++) // Генерация случайных значений
    {
        v[i] = auxil::iget(100, 900);
        c[i] = auxil::iget(10, 150);
    }

    t1 = clock();
    int cc = boat(
        V,   // [in]  максимальный вес груза
        MM,  // [in]  количество мест для контейнеров     
        NN,  // [in]  всего контейнеров  
        v,   // [in]  вес каждого контейнера  
        c,   // [in]  доход от перевозки каждого контейнера     
        r    // [out] результат: индексы выбранных контейнеров  
    );
    t2 = clock();


    std::cout << std::endl << "- Задача о размещении контейнеров на судне";
    std::cout << std::endl << "- общее количество контейнеров    : " << NN;
    std::cout << std::endl << "- количество мест для контейнеров : " << MM;
    std::cout << std::endl << "- ограничение по суммарному весу  : " << V;
    std::cout << std::endl << "- вес контейнеров                 : ";
    for (int i = 0; i < NN; i++) std::cout << std::setw(3) << v[i] << " ";
    std::cout << std::endl << "- доход от перевозки              : ";
    for (int i = 0; i < NN; i++) std::cout << std::setw(3) << c[i] << " ";
    std::cout << std::endl << "- выбраны контейнеры (0,1,...,m-1): ";
    for (int i = 0; i < MM; i++) std::cout << r[i] << " ";
    std::cout << std::endl << "- доход от перевозки              : " << cc;
    std::cout << std::endl << "- общий вес выбранных контейнеров : ";
    int s = 0; for (int i = 0; i < MM; i++) s += v[r[i]]; std::cout << s << std::endl;
    std::cout << "Время выполнения: " << ((double)(t2 - t1)) / ((double)CLOCKS_PER_SEC) << " с.";
    std::cout << std::endl << std::endl;
    system("pause");
    return 0;
}
