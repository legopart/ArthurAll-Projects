import React from "react";
import Result from './Result'

import * as functions from '../../api/functions';
import { useWeatherDispatch } from '../../reducers/weather.reducer';
import {useLocationContext} from '../../context/location.context';

//let unsubscribeLocationRedux;

export default function Items () {

    const locationContext = useLocationContext();

    const weatherDispatch = useWeatherDispatch();
    const setData = async() => {
        const result = await functions.loadData(locationContext.location);
        if (!result) {alert('Wrong input!');return;}
        try{
            const data = {
                location : result.location.name
                , temperature: result.current.temp_c
                , humidity: result.current.humidity
            }
            const {location, temperature, humidity} = data;
            weatherDispatch.AddWeather(location, temperature, humidity);    //(data)
        }catch(e){}
    }

    return (<>
    <input type="text" value={locationContext.location}  onChange={(e) => {
        //locationRedux.dispatch(SetLocation(e.target.value));
        locationContext.SetLocation(x => x = e.target.value);
        }}/>
    <button onClick={async() => { setData() }}>Add</button>
    <br />
    <Result />
    </>);
}
 