import weatherReducer from './WeatherReducer';
import locationReducer from './LocationReducer';
import { combineReducers } from 'redux';
export default combineReducers({
    weatherReducer
    , locationReducer
})