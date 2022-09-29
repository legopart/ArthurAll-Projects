

#include <iostream>
using namespace std;




int getNumber(const string& prompt, const int& min, const int& max);
int getNumber(const string& prompt);

int main()
{
    cout << "Streams" << endl;
    int first;
    int second;
    first = getNumber("enter the first number");
    second = getNumber("please enter the second number!");
    cout << endl << endl;
    cout << "you entered:" << endl;
    cout << first << endl;
    cout << second << endl;
    cout << endl << endl << endl;
   
    return EXIT_SUCCESS;
}



int getNumber(const string& prompt) 
{
    return getNumber(prompt, numeric_limits<int>::min(), numeric_limits<int>::max()); 
}
int getNumber(const string& prompt, const int& min, const int& max)
{
    int number;
    while (true)
    {
        cout << prompt << endl;
        cin >> number;
        if (cin.fail() || number < min || number > max)
        {
            cout << "enter a valid number" << endl;
            cin.clear();
            cin.ignore(numeric_limits<streamsize>::max(), '%d');
            //cin.ignore(numeric_limits<streamsize>::max(), '%d');
        }
        else break;
    }
    cin.ignore(numeric_limits<streamsize>::max(), '\n');
    return number;
}

