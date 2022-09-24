#include "RESTCHttpClient.h"

#include <boost/lexical_cast.hpp>
#include <boost/fusion/adapted.hpp>

#include "restc-cpp/restc-cpp.h"
#include "restc-cpp/SerializeJson.h"
#include "restc-cpp/RequestBuilder.h"

using namespace restc_cpp;
std::string RESTCHttpClient::requestGet(int& i)
{
    std::string data{};
    if(i==0) std::cout << "RestApiCpp RESTC \n";
    std::string address = "http://localhost:5000/Demo";
    auto rest_client = RestClient::Create();
    rest_client->ProcessWithPromise([&](Context& ctx) {
        auto reply = RequestBuilder(ctx) .Get(address).Argument("aaa", i).Execute();
        data = reply->GetBodyAsString();
        //std::cout << data << "\n";
    });
    rest_client->CloseWhenReady(true);
    i += 1;
    return data;
}


/**rest_client->Process([&](Context& ctx) {
    auto reply = ctx.Get(address); // No: ?aaa=999
    auto json = reply->GetBodyAsString();
    cout << "Received data: " << json << endl;
});/**/