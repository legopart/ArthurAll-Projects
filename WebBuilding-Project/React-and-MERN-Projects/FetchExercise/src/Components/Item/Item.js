import React, {Component} from "react";
import Result from './Components/Result'


import { useDispatch, useSelector } from "react-redux";
import { AddWeather } from '../../Reducers/WeatherReducer';
import { SetLocation } from '../../Reducers/LocationReducer';
export default function Item2Fun(props){
    const setWeather = useDispatch();
    let weather = useSelector(s=>s.weatherReducer);
    let location = useSelector(s=>s.locationReducer);
    return <Items {...props} weather = {[weather, setWeather, location]} />
}

class Items extends Component {
    state = { 
        //locationArea: 'London'
        //,data: {}
    } 
    loadData = async(location) => {
      const url=`http://api.weatherapi.com/v1/current.json?key=934bf32471e548949ae214411222203 &q=${location}&aqi=no`;
      let result, jsonResult;
      try{
        result = await fetch(url);
        if(result?.ok || result?.status === 200) jsonResult =  await result?.json();
        else {  }
      } catch(ex){  }
      return await jsonResult;
    };

    //componentDidMount= async() => {}

    setData = async() => {
        const [/*weather*/, setWeather, location] = this.props.weather;
        const result = await this.loadData(location/*this.state.locationArea*/);
        if (!result) {alert('Wrong input!');return;}
        try{
            const data = {
                location : result.location.name
                , temperature: result.current.temp_c
                , humidity: result.current.humidity
            }
            setWeather(AddWeather(data))
            //this.setState({ data });
        }catch(e){}
    }
    render() { 
        //const {location, temperature, humidity} = this.state.data;
        const [/*weather*/, setWeather, location] = this.props.weather;
        return (<>
        <input type="text" value={location/*this.state.locationArea*/}  onChange={(e) => {
            //this.setState({locationArea: e.target.value})
            setWeather(SetLocation(e.target.value))
            }}/>
        <button onClick={async() => { this.setData() }}>Add</button>
        <br />
        <Result />
        </>);
    }
}
 