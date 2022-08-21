import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import reportWebVitals from './reportWebVitals';
import Practice09 from './practice10/Index10.js';
const array1 =[
  {type: 'a', val: "https://walla.com"},
  {type: 'a', val: "https://google.com"},
  {type: 'br'},
  {type: 'input', val: "some text"},
  {type: 'input', val: "some text"},
  {type: 'br'},
  {type: 'button', val: "click here"},
  {type: 'button', val: "click here"},
];

function tags(val) {

  
  return [

  {'br': <br />},
  {'a': <a href={val}>{val}</a>},
  {'button': <button>{val}</button>},
  {'input': <input type="text" placeholder={val} />}

]

}

let a= '1';
ReactDOM.render(
  <React.StrictMode>

    <Practice09 />
    
  </React.StrictMode>,
  //{ array1.map(x => { return tags(x.val).find(y => y[x.type])[x.type] ; } ) }
  document.getElementById('root')
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
