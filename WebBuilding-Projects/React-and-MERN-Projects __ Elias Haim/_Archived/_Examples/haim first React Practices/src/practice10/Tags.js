import React, { Component } from 'react';



class Tags extends Component {
    state = {  } 
    render() { 
        return (
        <div>
            {
            
            array2.map((x) => ( printTag2(x) ))

            }
            <hr />
        </div>
        );
    }
}
 


const array2 =[
  {a: "https://walla.com"},
  {a: "https://google.com"},
  br(),
  {input: "some text"},
  {input:  "some text"},
  br(),
  {button: "click here"},
  {button: "click here"},
];

function br(){return <br />;}
function printTag2(x) {
    try{
    const key = Object.keys(x)[0];
    const value = Object.values(x)[0];
    if(key === 'a') return <a href="#0">{value}</a>;
    else if(key === 'input') return <input type="text" value={value} />;
    else if(key === 'button') return <button type="text">{value}</button>;
    }catch{}
    return x;
}


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


function printTag1(x) {
    if(x.type === 'a') return <a href="#0">{x.val}</a>;
    else if(x.type === 'br') return <br />;
    else if(x.type === 'input') return <input type="text" value={x.val} />;
    else if(x.type === 'button') return <button type="text">{x.val}</button>;
}

function tags1(val) {
  return [
  {'br': <br />},
  {'a': <a href={val}>{val}</a>},
  {'button': <button>{val}</button>},
  {'input': <input type="text" placeholder={val} />}
]

}


export default Tags;