#pragma once
class Prime
{
	unsigned int number;
	
public:
	bool isPrime{ false };
	Prime() = delete;
	Prime(unsigned int number);
	unsigned int const getNumber() const ;
	void setIsPrime(bool isPrime);
	bool const getIsPrime() const;
	void checkIsPrime();
};

