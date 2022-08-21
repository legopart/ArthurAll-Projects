// CMakeProjectDemo2.cpp : Defines the entry point for the application.
//
// vcpkg cpr        //? vcpkg install cpr 

// https://github.com/libcpr/cpr

#include <cpr/cpr.h>
#include <iostream>
#include <Windows.h>


//vcpkg install rapidjson
#include "rapidjson/document.h"
#include "rapidjson/writer.h"
#include "rapidjson/stringbuffer.h"
#include <iostream>
#include <cstring>  //.c_str()
#include <fstream>
#include <jsoncpp/json/value.h>
using namespace rapidjson;



//#include <string>

//#include "restc-cpp/restc-cpp.h"
using namespace std;


/**
static bool deserialize(const std::string& JSONPath)   //const rapidjson::Value& obj
{
    const std::string  JSONString = JSONPath;//getFileString(JSONPath);
    if (JSONString.empty()) {
        std::cerr << "No Json Resurce File \n";
        return false;
    }

    rapidjson::Document document;
    rapidjson::ParseResult parseResult = document.Parse(JSONString.c_str());

    if (!parseResult) {
        std::cerr << "JSON parse error:" << rapidjson::GetParseErrorFunc(parseResult.Code()) << "(" << parseResult.Offset() << ")\n";
        //std::cerr << "In JSON file" << JSONPath << "\n";
        return false;
    }


    auto shaddersIt = document.FindMember("shaders_something_array");
    if (shaddersIt != document.MemberEnd()) { //if is valid
        for (const auto& currentShader : shaddersIt->value.GetArray()) {
            const std::string name = currentShader["name"].GetString();
            const std::string last_name = currentShader["last_name"].GetString();
            //Here we load the data
        }
    return true; 
}
/**/




struct Package {
public:
    string abc;
    int timing = -1;
    int timing2 = -1;
};


auto foo = [](int& i) {
    using namespace rapidjson;

    string data{};
    if (i == 0) std::cout << "RestApiCpp CPR with JSON \n";
    std::string address = "http://localhost:5000/Demo?aaa=" + std::to_string(i);
    auto response = cpr::Get(cpr::Url{ address });
    string dataJsonText = response.text;
    Document d;
    d.Parse(dataJsonText.c_str());

    Package pkgs { (d["abc"]).GetString(), (d["timing"]).GetInt()};
    //Package pkgs2 = d.GetObject();
    cout << pkgs.timing;

    i += 1;
};


int main(int argc, char** argv) {
    ifstream file("data.json");
    string data{};
    reader.parse(file, data);

    int n{ 1 }; //1s
    cout << "1s interval\n";
    int milli_seconds{ n * 1000 };
    int i{ 0 };
    /**/
    while (1)
    {
        foo(i);
        Sleep(milli_seconds);
    }
    /**/




    /**
    const char* json = "{\"project\":\"rapidjson\",\"stars\":10}";
    Document d;
    d.Parse(json);
    
    int start = (d["stars"]).GetInt();
    string project = (d["project"]).GetString();
    std::cout << project;
    /**/

    /**update to string
    StringBuffer buffer;
    Writer<StringBuffer> writer(buffer);
    d.Accept(writer);
    std::cout << buffer.GetString() << std::endl;
    /**/







    /**cpr::Response r = cpr::Get(cpr::Url{ "http://localhost:5000/Demo" },
     //   cpr::Authentication{ "user", "pass", cpr::AuthMode::BASIC },
        cpr::Parameters{ {"anon", "true"}, {"key", "value"} });
    r.status_code;                  // 200
    r.header["content-type"];       // application/json; charset=utf-8
    r.text;                         // JSON text string /**/

    return 0;
}
