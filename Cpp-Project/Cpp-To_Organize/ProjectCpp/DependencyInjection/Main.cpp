// DependencyInjection.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include "IGPS.h"
#include <Windows.h>
//#include "MokeGPS.h"
//#include "RealGPS.h"
#include "config.h"
void DriveRobot(IGPS& gps) {
    float lat = gps.getLatitude();
    float lon = gps.getLongitude();
}



int main()
{
        //example
    //MockGPS gps;
    //RealGPS gps;
    //DriveRobot(gps);
    Config config;
    DriveRobot(config.getGPS());

    int n{ 1 }; //1s
    std::cout << "1s interval\n";
    int milli_seconds{ n * 1000 };
    int i{ 0 };
    while (1)
    {
        Sleep(milli_seconds);
        std::cout << config.requestGet(i) << "\n";
    }

    std::cout << "Hello World!\n";
    return 0;
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu
