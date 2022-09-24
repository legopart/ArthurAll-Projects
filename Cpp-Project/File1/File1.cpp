
#include <iostream>
#include <string> //#include <iterator>
#include <fstream>

using namespace std;

int main() {    // run arthur Object
    string fileName = "text.txt";

    ofstream outFile;

    outFile.open(fileName);
    if (outFile.is_open()) {
        //outFile << "Hello there" << endl;
        //outFile << 123 << endl;
        outFile << "Israel: 44" << endl;
        outFile << "USA: 72" << endl;
        outFile.close();
    }
    else {
        cout << "could not create file: " << fileName << endl;
    }


    //fstream inFile;
    //inFile.open(fileName, ios::in);
    ifstream inFile;
    inFile.open(fileName);

    if (!inFile.is_open()) return 1;


    //inFile >> line ;  //only first word

    //while (!inFile.eof()) {
    while (inFile) {
        string line;
        //getline(inFile, line);  //1 line
        //cout << line << endl;
        getline(inFile, line, ':');
        int value;
        inFile >> value;

        //inFile.get();// disable next line \r\n from each line
        inFile >> ws;

        if (!inFile) break;
        cout << line << ':' << value << endl;
    }
    inFile.close();



    cout << "after all message" << endl;

    return 0;
}




