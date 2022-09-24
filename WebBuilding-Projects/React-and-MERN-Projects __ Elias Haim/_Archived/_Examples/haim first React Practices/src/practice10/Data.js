import React, { Component } from 'react';
class Data extends Component {
    #resetName = 'Mosh';
    state = { 
        count: 10,
        resetName: this.#resetName,
        name: this.#resetName,
        num1: 0,
        num2: 0,

     } 
    render() { 
        
        return (
            <div>
                Counter: {this.state.count}  
                <button onClick={() => {this.setState({count : this.state.count + 1})}}> + </button> 
                <button onClick={() => {this.setState({count : 0, name : this.state.resetName}); ge('name').value='';}}> reset </button>
                <br />
                Name: {this.state.name}<br />
                <input id="name" type="text" onChange={(e) => { this.setState({name : e.target.value}) } } />
                <hr />
                Total Sum: {this.state.num1*1 + this.state.num2*1} <br />
                <input type="number" onChange={(e) => { this.setState({num1 : e.target.value}) } } value={this.state.num1} /><br />
                <input type="number" onChange={(e) => { this.setState({num2 : e.target.value}) } } value={this.state.num2} /><br />
                <hr />
            </div>
        );
    }
}

function ge(id){return document.getElementById(id);}

export default Data;