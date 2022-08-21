import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import reportWebVitals from './reportWebVitals';
import Practices from './Practices.js';

ReactDOM.render(
  <React.StrictMode>

    <Practices />
    
  </React.StrictMode>,
  //{ array1.map(x => { return tags(x.val).find(y => y[x.type])[x.type] ; } ) }
  document.getElementById('root')
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
