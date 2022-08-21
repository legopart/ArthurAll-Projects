#include <boost/lexical_cast.hpp>
#include <boost/fusion/adapted.hpp>

#include "restc-cpp/restc-cpp.h"
#include "restc-cpp/SerializeJson.h"
#include "restc-cpp/RequestBuilder.h"

using namespace std;
using namespace restc_cpp;

//  https://github.com/jgaa/restc-cpp/blob/master/doc/Tutorial.md


struct Package {
    string abc;
    int timing = -1;
};

BOOST_FUSION_ADAPT_STRUCT(
    Package
    , (string, abc)
    , (int, timing)
)

auto foo = [](int& i) -> std::string {
    if (i == 0) std::cout << "RestApiCpp RESTC with JSON ! \n";

    std::string data{};


    std::string address = "http://localhost:5000/Demo";
    auto rest_client = RestClient::Create();
    /**/
    Package my_package = rest_client->ProcessWithPromiseT<Package>([&](Context& ctx) {
        Package package;
        SerializeFromJson(
            package
            , RequestBuilder(ctx).Get(address).Argument("aaa", i).Header("X-Client", "RESTC_CPP").Header("X-Client-Purpose", "Testing").Execute()
        );
        return package;
        }).get();

    i += 1;
    data = std::to_string(my_package.timing);
    //data = std::to_string(my_package.timing);
    return data;
};


int main(int argc, char** argv) {
    int n{ 1 }; //1s
    cout << "1s interval\n";
    int milli_seconds{ n * 1000 };
    int i{ 0 };
    while (1)
    {
        cout << foo(i) << "\n";
        Sleep(milli_seconds);
    }
    return 0;
}
