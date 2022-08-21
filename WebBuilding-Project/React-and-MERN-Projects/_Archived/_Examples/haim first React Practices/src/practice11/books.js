import React, { Component } from 'react';
import Book from './book.js';
class Books extends Component {
    state = {  } 
    render() { 
        return (<div>


<Book addCount={this.props.addCount} decreesCount={this.props.decreesCount}/>

<Book addCount={this.props.addCount} decreesCount={this.props.decreesCount}/>

<Book addCount={this.props.addCount} decreesCount={this.props.decreesCount}/>

<Book addCount={this.props.addCount} decreesCount={this.props.decreesCount}/>



        </div>);
    }
}
    
export default Books;
