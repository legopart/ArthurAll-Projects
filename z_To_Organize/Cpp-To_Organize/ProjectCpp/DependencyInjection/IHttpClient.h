#pragma once
#include <iostream>
class IHttpClient
{
public:
	virtual std::string requestGet(int&) = 0;
};

