#pragma once
#include "IGPS.h"
#include "MokeGPS.h"
#include "RealGPS.h"

#include "IHttpClient.h"
#include "RESTCHttpClient.h"
#include "CPRHttpClinet.h"
#include <iostream>

class Config
{
private:
	MockGPS gps;

	RESTCHttpClient httpClient;			///!!!
	IHttpClient& getHttpClient();
public:
	IGPS& getGPS();
	std::string requestGet(int&);
};

