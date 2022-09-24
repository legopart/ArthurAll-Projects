import {reducerCounter} from './CounterReducer';
import { combineReducers } from 'redux';
export default combineReducers({
    counter:reducerCounter,
})

