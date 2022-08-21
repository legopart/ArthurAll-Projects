#include "CPRHttpClinet.h"
#include <cpr/cpr.h>
#include <iostream>
#include <Windows.h>

std::string CPRHttpClinet::requestGet(int& i)
{
    if (i == 0) std::cout << "RestApiCpp CPR \n";
    std::string address = "http://localhost:5000/Demo?aaa=" + std::to_string(i);
    auto response = cpr::Get(cpr::Url{ address });
    //std::cout << response.text << "\n";
    i += 1;
    return response.text;
}
