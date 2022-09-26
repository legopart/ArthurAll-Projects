
#include <thread>
#include <iostream>
#include <string>
#include <map>

//#include <Windows.h>

#include <chrono>
using namespace std::chrono_literals;

/**
void refreshForcast(std::map<std::string, int> forcastMap) {
    std::cout << "Thread Id " << std::this_thread::get_id() << "\n";
    int i{ };
    while (i < 5) {
        for (auto& item : forcastMap) {
            item.second++;
            std::cout << item.first << " - " << item.second << "\n";
        }
        //Sleep(2000);
        std::this_thread::sleep_for(2000ms);
        ++i;
    }
};
/**/

static bool s_Finishd = false;

void doWork(const int& i) {
    std::cout << "Thread Id " << std::this_thread::get_id() << "\n";
    while (!s_Finishd) {
        std::cout << "working ( worker #" << i + 1 << " ) ...\n";
        std::this_thread::sleep_for(2000ms);
    }
}

int main()
{
    int startTime = clock();
    std::map<std::string, int> forcastMap = {
        {"New York", 15}
        , {"Mumbai", 20}
        , {"Berlin", 18}
    };
    //refreshForcast(forcastMap);
   // std::thread bgWorker(refreshForcast, forcastMap);


   // std::thread worker(doWork);
    const int workersSize{ 5 };

    std::thread workers[workersSize];
    for (int i = 0; i < workersSize; ++i) {
        workers[i] = std::thread(doWork, i);

    }

    std::cin.get();


    std::cout << "This Thread Id " << std::this_thread::get_id() << "\n";
    s_Finishd = true;
    //bgWorker.join();    //wait to thread to finish
    //worker.join();
    for (int i = 0; i < workersSize; ++i) { workers[i].join(); }  //close all
    std::cout << "all worker stop from working :) \n";
    int finishTime = clock();

    std::cout << "works took:" << (finishTime - startTime) / 1000 << "sec\n";



    std::cin.get();
    return EXIT_SUCCESS;
}
