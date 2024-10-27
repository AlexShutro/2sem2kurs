#include "Combi1.h"
namespace combi1
{
	subset::subset(short n) {
		// Конструктор класса subset
		this->n = n;
		this->sset = new short[n];
		this->reset();
	};

	void subset::reset() {
		// Сброс состояния генератора подмножеств
		this->sn = 0;
		this->mask = 0;
	};

	short subset::getfirst() {
		// Получение первого подмножества
		__int64 buf = this->mask;
		this->sn = 0;
		for (short i = 0; i < n; i++) {
			if (buf & 0x1) this->sset[this->sn++] = i;
			buf >>= 1;
		}
		return this->sn;
	};

	short subset::getnext() {
		// Получение следующего подмножества
		int rc = -1;
		this->sn = 0;
		if (++this->mask < this->count()) rc = getfirst();
		return rc;
	};

	short subset::ntx(short i) {
		// Получение i-го элемента текущего подмножества
		return this->sset[i];
	};

	unsigned __int64 subset::count() {
		// Подсчет общего количества подмножеств
		return (unsigned __int64)(1 << this->n);
	};
};