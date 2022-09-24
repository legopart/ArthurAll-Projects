import React, { Component } from 'react';
class Data extends Component {
    state = { 
        count: 10,
        name: "Mosh",
        num1: 0,
        num2: 0,
     } 
    render() { 
        return (
            <div>
                Counter: {this.state.count}  
                <button onClick={() => {this.setState({count : this.state.count + 1})}}> + </button> 
                <button onClick={() => {this.setState({count : 0})}}> reset </button>
                <br />
                Name: {this.state.name}<br />
                <input type="text" onChange={(e) => { this.setState({name : e.target.value}) } } />
                <hr />
                Total Sum: {this.state.num1*1 + this.state.num2*1} <br />
                <input type="number" onChange={(e) => { this.setState({num1 : e.target.value}) } } value={this.state.num1} /><br />
                <input type="number" onChange={(e) => { this.setState({num2 : e.target.value}) } } value={this.state.num2} /><br />
                <hr />
            </div>
        );
    }
}
 
export default Data;