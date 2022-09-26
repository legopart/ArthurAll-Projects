#include <boost/lexical_cast.hpp>
#include <boost/fusion/adapted.hpp>

#include "restc-cpp/restc-cpp.h"
#include "restc-cpp/SerializeJson.h"
#include "restc-cpp/RequestBuilder.h"

using namespace restc_cpp;

//  https://github.com/jgaa/restc-cpp/blob/master/doc/Tutorial.md

int cpyCount{ 0 };
int disCount{ 0 };
class Package {
public:
    std::string abc;
    int timing = -1;;
    Package() { }
    Package(const Package& p1){ abc = p1.abc; timing = p1.timing; cpyCount++; }
    ~Package() { disCount++; }
};

BOOST_FUSION_ADAPT_STRUCT( Package, (std::string, abc), (int, timing) )

auto foo = [](int& i) -> std::string {
    if (i == 0) std::cout << "RestApiCpp RESTC with JSON ! \n";
    std::string data{};
    std::string address{ "http://localhost:5000/Demo" };
    auto rest_client = RestClient::Create();
    
    Package my_package = rest_client->ProcessWithPromiseT<Package>( [&](Context& ctx) {
        Package my_packageTemp;
            SerializeFromJson(my_packageTemp, RequestBuilder(ctx).Get(address).Argument("aaa", i).Header("X-Client", "RESTC_CPP").Header("X-Client-Purpose", "Testing").Execute() );
            return my_packageTemp;
        } ).get();

    i += 1;

    return my_package.abc;
};

int main(int argc, char** argv) {
    const int dalay{ 1 }; //1s
    std::cout << dalay <<"s interval\n";
    int milli_seconds{ dalay * 1000 };
    int i{ 0 };
    while (1) {
        std::cout << foo(i) << "\n";
        std::cout << "Copied: " << cpyCount << " Distructured: " << disCount << "\n";
        cpyCount = 0 ;
        disCount = 0 ;
        Sleep(milli_seconds);
    }

    return EXIT_SUCCESS;
}