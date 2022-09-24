#include <iostream>
#include <string> //#include <iterator>
#include <fstream>

using namespace std;

int main() {

#pragma pack(push, 1)
    struct Person {
        char name[50];
        int age;
        double weight;
    };
#pragma pack(pop)


    //cout << sizeof(Person) << endl;
    string fileName = "test.bin";

    Person someone{ "Arthur", 34, 110.0 };

    //fstream outputFile;
    //outputFile.open(fileName, ios::binary|ios::out);
    ofstream outputFile;
    outputFile.open(fileName, ios::binary);
    if (!outputFile.is_open()) {
        cout << "Couldn't open file " << fileName << endl;
        return 1;
    }
    //outputFile.write((char *) & someone, sizeof(Person));
    outputFile.write(reinterpret_cast<char*>(&someone), sizeof(Person));

    outputFile.close();


    //read bin:

    Person someoneElse = {}; //initialize to 0 s ...

    ifstream inputFile;
    inputFile.open(fileName, ios::binary);
    if (!inputFile.is_open()) {
        cout << "Couldn't read file " << fileName << endl;
        return 1;
    }
    //outputFile.write((char *) & someoneElse, sizeof(Person));
    inputFile.read(reinterpret_cast<char*>(&someoneElse), sizeof(Person));

    inputFile.close();

    cout << someoneElse.name << ". " << someoneElse.age << ". " << someoneElse.weight << endl;


    return 0;
}
