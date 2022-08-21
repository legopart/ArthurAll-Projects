#include <iostream>
#include <string> //#include <iterator>
#include <map>;
#include <vector>;

using namespace std;


static int mainNested() {
    map<string, vector<int>> scores;
    scores["Mike"].push_back(10);
    scores["Mike"].push_back(20);
    scores["Vicky"].push_back(50);

    for (auto it: scores) {
        string name = it.first;
        vector<int> scoreList = it.second;
        cout << name << ": " << flush;
        for (auto i: scoreList) {   //int i = 0; i < scoreList.size(); i++
            cout << i << " " << flush;
        }
        cout << endl;

    }

    //for (map < string, vector<int> >::iterator it = scores.begin(); it != scores.end(); it++) {
    //    string name = it->first;
    //    vector<int> scoreList = it->second;
    //    cout << name << ": " << flush;
    //    for (int i = 0; i < scoreList.size(); i++) {
    //        cout << scoreList[i] << " " << flush;
    //    }
    //    cout << endl;

    //}



    return 0;
}
