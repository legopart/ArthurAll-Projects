import './App.css';
import { Item } from './Item.jsx';
import { Book } from './Book.jsx';
import {redux, incrementAction, decrementAction
  , stateRedux, setData, arrayRedux, arrayAdd, arrayRemove, arrayUpdate} from './ReduxActions';
import { useState } from 'react';

import React, {Component} from 'react';

export default class App extends Component {
  state = { 
      funcState: redux.getState()
      , state: stateRedux.getState()
      , array: arrayRedux.getState()
   } 
  componentDidMount() {
      /*const unStore =*/ redux.subscribe( ()=> this.setState({funcState: redux.getState()}) );
      /*const stateStore =*/ stateRedux.subscribe( ()=> this.setState({state: stateRedux.getState()}) );
      arrayRedux.subscribe( ()=> this.setState({array: arrayRedux.getState()}) );
    }
  render() {
    return (<div className="App">
      <button onClick={()=>{
        arrayRedux.dispatch(arrayAdd('a11'));
      }}>Add</button>  
      <button onClick={()=>{
        arrayRedux.dispatch(arrayUpdate('b22'));
      }}>Update</button>  
            <button onClick={()=>{
        arrayRedux.dispatch(arrayRemove('a11'));
      }}>Remove</button>  
      <br />
      {this.state.array.data?.toString()}
      {console.log(this.state.array)}
      <br /><br /><br /><br />
      <button onClick={()=>{
        stateRedux.dispatch(setData(8));
      }}>State Changer 6 to 8</button>  
      {this.state.state}
      <br /><br /><br /><br />
      <button onClick={()=>{
        redux.dispatch(incrementAction());
      }}>+</button>  
      {this.state.funcState}
      <Item/><Item/><Item/><Item/><Item/><Item/><Item/><Item/>
      <Book/>
    </div>);
  }
}
 


 function Appfunc() {
  const [funcState, setFuncState] = useState(redux.getState());
  const unStore = redux.subscribe( ()=> setFuncState(redux.getState()) );
  const [state, setState] = useState(stateRedux.getState());
  const unStateS= stateRedux.subscribe( ()=> setState(stateRedux.getState()) );
  return (<div className="App"></div>);
}

