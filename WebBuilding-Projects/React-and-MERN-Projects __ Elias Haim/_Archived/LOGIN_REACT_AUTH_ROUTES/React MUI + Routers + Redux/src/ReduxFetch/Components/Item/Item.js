import React from "react";
import ItemMethods from './ItemMethods';
import Result from './Components/Result';
import {locationRedux, SetLocation} from '../../Reducers/LocationReducer';
import { useDispatch, useSelector } from "react-redux";

export default function ItemFun(props){
    const setWeather = useDispatch();
    let weather = useSelector(s=>s.weatherReducer);
    return <Items {...props} weather = {[weather, setWeather]} />
}

class Items extends ItemMethods {
    render() { 
        return (<>
        <input type="text" value={this.state.locationArea}  onChange={(e) => {
            locationRedux.dispatch(SetLocation(e.target.value))
            }}/>
        <button onClick={async() => { this.setData() }}>Add</button>
        <br />
        <Result />
        </>);
    }
}
 