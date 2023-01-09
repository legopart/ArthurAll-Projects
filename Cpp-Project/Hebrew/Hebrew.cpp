// Hebrew.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream> //#include <string> 
//#include <fstream>

#include <fcntl.h>  
#include <io.h>


using namespace std;



int main()
{
    auto result = _setmode(_fileno(stdout), _O_U8TEXT);
    //_O_U8TEXT //_O_UTEXT  // _O_WTEXT
#define cout wcout      //Fix ! to same unicode usage

    wchar_t wide[] = L"ארטור";
    wprintf(wide);

    std::wcout << std::endl;

    std::wstring  str = L"aaaa aaab שלום ארטור bbba bbbc";
    std::reverse(str.begin(), str.end());
    std::wcout << str << std::endl;

    std::string regularString = "ABC";

    std::cout << regularString.c_str() << std::endl; //Fix

    std::cout << std::wstring(regularString.begin(), regularString.end()) << std::endl; //Fix


}



//https://www.google.com/search?q=arduino+hebrew+string&oq=arduino+hebrew+string&aqs=chrome..69i57j33i160l4.9769j0j7&sourceid=chrome&ie=UTF-8
// 
// 
// 
// https://learn.microsoft.com/en-us/answers/questions/263442/how-to-output-non-english-string-literals-in-c.html
// 
// 
// https://stackoverflow.com/questions/32883061/putting-hebrew-string-in-a-variable-using-c-on-windows
// 
// https://www.appsloveworld.com/cplus/100/855/use-tchar-still-cant-use-stdcout-cout-should-automatically-get-converted-to
// 
// 
// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
