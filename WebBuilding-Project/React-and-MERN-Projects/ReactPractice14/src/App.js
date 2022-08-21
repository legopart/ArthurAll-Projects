import './App.css';
import React from 'react';
import { BrowserRouter, Routes, Route, Link,  } from 'react-router-dom';  // useParams,
import {ItemsFun as Items, Basket} from './Components/';
import { AppExtends } from './AppExtends';
import MuiReferences from './MuiReference/muiReference';
export default class App extends AppExtends {
  render() { 
    return (
    <div className="App">
        <BrowserRouter>
          Arthur Zarankin - React Exam<br />
          <Link to="/">/</Link>{' | '}
          <Link to="/Basket">Basket</Link>{' | '}
          <Link to="/Items">Items</Link>{' | '}
          <Link to="/Mui">Mui</Link>{' | '}
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
            </Route>
            <Route path="*" element={<>Error<br /></>} />
          </Routes>
          <br />
          Results:<br />
          {this.state.checkedData.map((x,i)=><span key={i}>({i}){x.toString()}{' '}</span>)}<br />
        </BrowserRouter>
    </div>
    );
  }
}