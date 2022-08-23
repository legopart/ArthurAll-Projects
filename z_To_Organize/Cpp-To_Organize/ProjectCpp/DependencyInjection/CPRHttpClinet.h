#pragma once
#include "IHttpClient.h"
class CPRHttpClinet: public IHttpClient
{
	virtual std::string requestGet(int&) override;
};

