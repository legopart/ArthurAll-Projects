
#include <iostream>
#include <stack>
#include <cctype>
#include <algorithm>
#include <sstream>
#include <string>
#include <vector>
#include <queue>
#include <stack>
#include <set>
#include <map>
#include <list>
using std::to_string,std::string, std::boolalpha, std::swap, std::vector, std::queue, std::set, std::map, std::pair;
using std::list, std::stack, std::istringstream,std::cout, std::endl;

static int countVowels(string str);
static string reverseString(string str);
static string reverseWords(string sentence);
static bool isRotation(string str1, string str2);
static string removeDuplicates(string str);


int main()
{

    cout << "Count Vowels: \t\t" << countVowels("Hello World") << endl;
    cout << "Reverse String: \t\t" << reverseString("Hello  World") << endl;
    cout << "Reverse Words: \t\t" << reverseWords("Hello World") << endl;
    cout << "Reverse Words: \t\t" << boolalpha << isRotation("WorldHello ", "Hello World") << endl;
    cout << "Reverse Words: \t\t" << removeDuplicates("Hello World") << endl;


    return EXIT_SUCCESS;
}


static bool contains(const string& str, const char& ch)
{
    return std::find(str.begin(),str.end(), ch ) != str.end();
}

static bool contains(const string& str, const string& str2)
{

    return str.find(str2) != string::npos  ;
}

static string& trim(string& str)
{
    size_t space = str.find_first_not_of(" \t");
    if( string::npos != space ) str = str.substr( space );
    return str;
}

static int countVowels(string str)
{
    if (str.empty()) return 0;
    int count = 0;
    string vowels = "aeiou";
    /*to lower case*/
    for (int i = 0; i < str.length(); i++) str[i] = tolower(str[i]);
    for (auto& ch : str)
        if (contains(vowels, ch)) count++;

    return count;
}

static string reverseString(string str)
{
    int n = str.length();
    for (int i = 0; i < n / 2; i++) swap(str[i], str[n - i - 1]);
    return str;
}

static stack<string> splitString(string s1)
{
    istringstream iss(s1);
    stack<string> result{};
    for(string s;iss>>s;) result.push(s);
    return result;
}


static string reverseWords(string sentence)
{
    if (sentence.empty()) return "";

    auto words = splitString(sentence);
    string str{};
    while(!words.empty())
    {
        str += trim(words.top()) + " ";
        words.pop();
    }
    return str;
}


static bool isRotation(string str1, string str2)
{
    if (str1.empty() || str2.empty()) return false;
    else if (str1.size() != str2.size()) return false;
    string newString = str1 + str1;
    if (contains(newString, str2)) return true;
    return false;
}

static string removeDuplicates(string str)
{
    if (str.empty()) return "";
    string output{};
    set<char> seen{};
    for (auto ch : str)
    {
        if (!seen.contains(ch))
        {
            seen.insert(ch);
            output += ch;
        }
    }
    return output;
}