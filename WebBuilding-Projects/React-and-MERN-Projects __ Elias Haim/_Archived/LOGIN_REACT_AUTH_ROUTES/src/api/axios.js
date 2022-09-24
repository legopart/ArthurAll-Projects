import axios from 'axios';

const axiosFun = axios.create({
    baseURL: 'http://localhost:3500'
    //, timeout: 1000
    , headers: {'Content-Type': 'application/json',}
    , withCredentials: true
});


export async function Axios(method, additionUrl, data, additionHeader){
    try{
        let response = await axiosFun({
                method: method
                , url: additionUrl
                , data: JSON.stringify(data)
                //, headers: additionHeader
            });
        return await await response.data;
    }catch(e){
        console.log('data', e.response?.data);  //{result: 'user already exist!'}
        console.log('status', e.response?.status);  //status 452
        console.log('headers', e.response?.headers);  //{content-length: '32', content-type: 'application/json; charset=utf-8'}

        return {error: e.response?.data}
    }
}
 
export function Async(callback){
    (async() => { callback(); })();
}

