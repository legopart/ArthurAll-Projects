import /*React,*/ {Component} from "react";
import {locationRedux/*, SetLocation*/} from '../../Reducers/LocationReducer';
import { AddWeather } from '../../Reducers/WeatherReducer';

export default class ItemMethods extends Component {
    state = { 
        locationArea: locationRedux.getState()
        //,data: {}
    } 

    componentDidMount= async() => {
         this.unsubscribeLocationRedux= locationRedux.subscribe( ()=> this.setState({locationArea: locationRedux.getState()}) );
    }

    componentWillUnmount = () => {
        this.unsubscribeLocationRedux();
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

    setData = async() => {
        const [/*weather*/, setWeather] = this.props.weather;
        const result = await this.loadData( this.state.locationArea );
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
}