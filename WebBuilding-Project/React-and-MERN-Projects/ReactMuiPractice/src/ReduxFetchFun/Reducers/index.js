
import {Provider} from 'react-redux';
import { configureStore } from "@reduxjs/toolkit";
import weatherReducer from './weather.reducer';

const store = configureStore({
    reducer: {
        weatherReducer,
    }
})

export const ReduxProvider = ({children}) =>
     <Provider store={store}>{children}</Provider>
