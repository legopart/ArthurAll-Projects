#include "Config.h"

IGPS& Config::getGPS() { return gps; } //private gps
IHttpClient& Config::getHttpClient(){ return httpClient; }//private getHttpClient() //private httpClient

std::string Config::requestGet(int& i)
{
	return getHttpClient().requestGet(i);
}
