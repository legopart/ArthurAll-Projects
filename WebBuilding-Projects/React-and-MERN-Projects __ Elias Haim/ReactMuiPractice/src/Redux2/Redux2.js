import './App.css';
import Item from './item';
import Item2 from './item2';

import React, {Component} from 'react';
import {Provider} from 'react-redux';
import allReducers from './Reducers'
import {createStore} from 'redux';
const store = createStore(allReducers,window.__REDUX_DEVTOOLS_EXTENSION__ && window.__REDUX_DEVTOOLS_EXTENSION__());
export default class App extends Component {
  state = {  } 
  render() { 
    return (    <Provider store={store}>    
    <div className="App">
      <Item/>
      <Item2/>
    </div>
    </Provider>);
  }
}
 
