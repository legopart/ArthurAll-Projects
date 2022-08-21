import './App.css';
import React from 'react';
import { BrowserRouter, Routes, Route, Link,  } from 'react-router-dom';  // useParams,
import {ItemsFun as Items, Basket} from './Components/';
import { AppExtends } from './AppExtends';
import MuiReferences from './MuiReference/muiReference';
import ReduxReference1 from './Redux1/Redux1';
import ReduxReference2 from './Redux2/Redux2';
import ReduxFetch from './ReduxFetch/ReduxFetch';
import ReduxFetchFun from './ReduxFetchFun/ReduxFetchFun';
export default class App extends AppExtends {
  render() { 
    return (
    <div className="App">
        <BrowserRouter>
          Arthur Zarankin - React Exam<br />
          <Link to="/">/</Link>{' | '}
          <Link to="./Basket">Basket</Link>{' | '}
          <Link to="./Items">Items</Link>{' | '}
          <Link to="./Mui">Mui</Link>{' | '}
          <Link to="./Redux1">ReduxReference1</Link>{' | '}
          <Link to="./Redux2">ReduxReference2</Link>{' | '}
          <Link to="./ReduxFetch">ReduxFetch</Link>{' | '}
          <Link to="./ReduxFetchFun">ReduxFetchFun</Link>{' | '}
          {/*
          <Link to="/Items/0">Item0</Link>{' | '}
          <Link to="/Items/1">Item1</Link>{' | '}
          <Link to="/Error">Error</Link>
          */}
          <br />
          <Routes>
            <Route path="/">
              <Route index element={<>Index<br /></>} />
              <Route path="/mui" element={<><MuiReferences /></>}></Route>
              <Route path="/items">
                <Route index element={<><Items state={this.state} /></>} />
                <Route path=":value" element={<><Items state={this.state} /></>} />
              </Route>
              <Route path="basket" element={<><Basket state={this.state} /></>} />
              <Route path="redux1" element={<><ReduxReference1 /></>} />
              <Route path="redux2" element={<><ReduxReference2 /></>} />
              <Route path="reduxFetch/*" element={<><ReduxFetch /></>} />
              <Route path="ReduxFetchFun/*" element={<><ReduxFetchFun /></>} />
            </Route>
            {/*<Route path="*" element={<>Error<br /></>} />*/}
          </Routes>
          <br />
          Results:<br />
          {this.state.checkedData.map((x,i)=><span key={i}>({i}){x.toString()}{' '}</span>)}<br />
        </BrowserRouter>
    </div>
    );
  }
}