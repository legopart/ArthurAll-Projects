#pragma once
#include "IHttpClient.h"
class RESTCHttpClient: public IHttpClient
{
	virtual std::string requestGet(int&) override;
};

