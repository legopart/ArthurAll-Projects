// CMakeProjectDemo2.cpp : Defines the entry point for the application.
//

#include "CMakeProjectDemo2.h"
#include <cpr/cpr.h>
#include <iostream>
#include <Windows.h>
using namespace std;

int main(int argc, char** argv) {

    int n = 1; //1s
    cout << "1s interval\n";
    int milli_seconds{ n * 1000 };
    int i{ 0 };
    while (1)
    {
        std::string address="http://localhost:5000/Demo?aaa=";

        address += std::to_string(i++);
        auto response = cpr::Get(cpr::Url{ address });
        std::cout << response.text << "\n";

        Sleep(milli_seconds);
    }



    /**
    cpr::Response r = cpr::Get(cpr::Url{ "http://localhost:5000/Demo" },
     //   cpr::Authentication{ "user", "pass", cpr::AuthMode::BASIC },
        cpr::Parameters{ {"anon", "true"}, {"key", "value"} });
    r.status_code;                  // 200
    r.header["content-type"];       // application/json; charset=utf-8
    r.text;                         // JSON text string
    /**/


    return 0;
}
