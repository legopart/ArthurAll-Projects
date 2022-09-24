#include "Prime.h"
#include <iostream>

Prime::Prime(unsigned int number) : number{number} { checkIsPrime(); }

unsigned int const Prime::getNumber() const { return this->number; }

void Prime::setIsPrime(bool isPrime){ this->isPrime = isPrime; }

bool const Prime::getIsPrime() const { return isPrime; }

void Prime::checkIsPrime()
{
	if (number % 2 == 0) { setIsPrime(false); return; };
	unsigned int half{ number / 2 };
	for (unsigned int x{ 3 };x < half; x = x + 2) {
		if (number % x == 0) { setIsPrime(false); return; }
	}
	setIsPrime(true);
}
