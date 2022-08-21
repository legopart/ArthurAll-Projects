import React, { Component } from 'react';
class Book extends Component {
    state = {  } 
    render() { 
        return (<>
        
            <img width="100" height="auto" alt="book" src="https://i.imgur.com/NWEW8BN.jpg"/>
            <input type="checkbox"  onClick={(e)=>{
                e.target.checked = e.target.checked ?  this.props.addCount(e) : this.props.decreesCount(e);
                }}/>

        </>);
    }
}
 
export default Book;