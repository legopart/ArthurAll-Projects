
import React from "react";

import { /*useDispatch,*/ useSelector } from "react-redux";


export default function History() {
        //const setWeather = useDispatch();
         let weather = useSelector(s=>s.weatherReducer);
        return (<>
        History:<br />
        {weather.history.map( (x, i) => {return <div key={i}>
            location: {x.location},
            temperature: {x.temperature},
            humidity: {x.humidity}<br />
            </div>})}
        </>);
    
}