import React from "react";

import { /*useDispatch,*/ useSelector } from "react-redux";


export default function Result () {
        //const setWeather = useDispatch();
        let weather = useSelector(s=>s.weatherReducer);
        const {location, temperature, humidity} = weather.result;
        return (<div>
        Result: <br />
        location: {location}<br />
        temperature: {temperature}<br />
        humidity: {humidity}<br />
        </div>);
}