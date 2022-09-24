import React from 'react';
import './App.css';
import { /*BrowserRouter,*/ Routes, Route, Link,  } from 'react-router-dom';  // useParams,

import Item from './components/Item/Item';
import History from './components/History'
//import { SetLocation } from './Reducers/LocationReducer';
import {LocationContextProvider} from './context/location.context';


import {ReduxProvider} from './reducers';
//import {weatherReducer} from './reducers/WeatherReducer';

//const store = createStore(appReducers,window.__REDUX_DEVTOOLS_EXTENSION__ && window.__REDUX_DEVTOOLS_EXTENSION__());

export default function App(){
    return ( 
  <div className="App">
    Weather API:<br />
    {/*<Link to="/">/</Link>*/}{' | '}
    <Link to="./Item">Item</Link>{' | '}
    <Link to="./History">History</Link>{' | '}
    <br />
    <ReduxProvider>
      <LocationContextProvider>
          <Routes>
            <Route path="/">
              <Route index element={<><Item /></>} />
              <Route path="/item" element={<><Item /></>} />
              <Route path="/history" element={<><History /></>} />
            </Route>
            <Route path="*" element={<>Error<br /></>} />
          </Routes>
      </LocationContextProvider>
    </ReduxProvider>
  </div>
  
   );

}
 


