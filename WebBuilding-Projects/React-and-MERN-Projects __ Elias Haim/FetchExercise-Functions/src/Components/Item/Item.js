import React from "react";
import Result from './Components/Result'


import { useDispatch, useSelector } from "react-redux";
import { AddWeather } from '../../Reducers/WeatherReducer';
import { SetLocation } from '../../Reducers/LocationReducer';

const loadData = async(location) => {
      const url=`http://api.weatherapi.com/v1/current.json?key=934bf32471e548949ae214411222203 &q=${location}&aqi=no`;
      let result, jsonResult;
      try{
        result = await fetch(url);
        if(result?.ok || result?.status === 200) jsonResult =  await result?.json();
        else {  }
      } catch(ex){  }
      return await jsonResult;
    };

export default function Items () {
    const setWeather = useDispatch();
    let location = useSelector(s=>s.locationReducer);
    const setData = async() => {
        const result = await loadData(location);
        if (!result) {alert('Wrong input!');return;}
        try{
            const data = {
                location : result.location.name
                , temperature: result.current.temp_c
                , humidity: result.current.humidity
            }
            setWeather(AddWeather(data))
        }catch(e){}
    }

    return (<>
    <input type="text" value={location}  onChange={(e) => {
        setWeather(SetLocation(e.target.value))
        }}/>
    <button onClick={async() => { setData() }}>Add</button>
    <br />
    <Result />
    </>);
}
 