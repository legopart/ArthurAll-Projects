import React, {Component} from 'react';
import './App.css';
import { BrowserRouter, Routes, Route, Link,  } from 'react-router-dom';  // useParams,

import {Provider} from 'react-redux';
import {createStore} from 'redux';
import appReducers from './Reducers'

import Item from './Components/Item/Item';
import History from './Components/History'

const store = createStore(appReducers,window.__REDUX_DEVTOOLS_EXTENSION__ && window.__REDUX_DEVTOOLS_EXTENSION__())
export default class App extends Component {
  state = {  } 
  render() { 
    return ( 
  <Provider store={store}>
    <div className="App">
        <BrowserRouter>
          Weather API:<br />
          {/*<Link to="/">/</Link>*/}{' | '}
          <Link to="/Item">Item</Link>{' | '}
          <Link to="/History">History</Link>{' | '}
          <br />
          <Routes>
            <Route path="/">
              <Route index element={<><Item /></>} />
              <Route path="/item" element={<><Item /></>} />
              <Route path="/history" element={<><History /></>} />
            </Route>
            <Route path="*" element={<>Error<br /></>} />
          </Routes>
        </BrowserRouter>
    </div>
  </Provider>
   );
  }
}
 


