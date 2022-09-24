import React, {Component} from "react";

import { useDispatch, useSelector } from "react-redux";
export default function ResultFun(props){
    const setWeather = useDispatch();
    let weather = useSelector(s=>s.weatherReducer);
    return <Result {...props} weather = {[weather, setWeather]} />
}

class Result extends Component {
    state = {  } 
    render() { 
        const [weather, ] = this.props.weather;
        const {location, temperature, humidity} = weather.result;
        return (<div>
        Result: <br />
        location: {location}<br />
        temperature: {temperature}<br />
        humidity: {humidity}<br />
        </div>);
    }
}