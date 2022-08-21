
import React, {Component} from "react";

import { useDispatch, useSelector } from "react-redux";
export default function HistoryFun(props){
    const setWeather = useDispatch();
    let weather = useSelector(s=>s.weatherReducer);
    return <History {...props} weather = {[weather, setWeather]} />
}

class History extends Component {
    state = {  } 
    render() { 
        const [weather, /*setWeather*/] = this.props.weather;
        return (<>
        History:<br />
        {weather.history.map( (x, i) => {return <div key={i}>
            location: {x.location},
            temperature: {x.temperature},
            humidity: {x.humidity}<br />
            </div>})}
        </>);
    }
}