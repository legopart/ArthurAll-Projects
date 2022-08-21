import React from 'react';
//import MuiReference from './MuiReference/muiReference';
import MuiRParams from './MuiReference/muiRParams';
import MuiRFunctionEdition from './MuiReference/muiRFunctionEdition';
import { BrowserRouter, Routes, Route, Link, useParams,  } from 'react-router-dom';

 function App1() {
   let {value} = useParams();
   return(<>
    {value}
   </>);
 }

export default function App() {
    return (<>
    <BrowserRouter>
      <Link to="/">/</Link>{' | '}
      <Link to="/1">1</Link>{' | '}
      <Link to="/2">2</Link>{' | '}
      <Link to="/5">5</Link>{' | '}
      <Link to="/MuiReference">MuiReference</Link>{' | '}
      <br />
      
      <Routes>
        <Route path="/">
          <Route index element={<>(index)</>} />
          <Route path=":value" element={<>(<App1 />)</>} />
          <Route path="1" element={<>(1)</>} />
        </Route>
        <Route path="/MuiReference">
          <Route path="Function" element={<MuiRFunctionEdition />} />
          <Route path=":aa" element={<MuiRParams />} />
          <Route index element={<MuiRParams /*MuiReference*/ />} />
        </Route>
        <Route path="*" element={<>(Error Page)</>} />
      </Routes>
    </BrowserRouter>

    <div>Footer</div>
     
    </>);
  
}
 


