import React, { Component } from 'react';
import Practice10 from './practice10/Index10.js';
import Practice11 from './practice11/practice11.js';
import Practice12 from './practice12/practice12.js';
class Practices extends Component {
    #actualPractice = 12
    state = { practice : this.#actualPractice } 
    render() { 
        return (
            <div>
                <h3>Set Practice:</h3>
                <button onClick={() => {this.setState({practice : 10})}}>Practice 10</button>
                <button onClick={() => {this.setState({practice : 11})}}>Practice 11</button>
                <button onClick={() => {this.setState({practice : 12})}}>Practice 12</button>
                <button onClick={() => {this.setState({practice : -1})}}>Clear</button>
                <hr />

                {
                    
                    this.state.practice === -1 ? '' 
                            : this.state.practice === 10 ? <Practice10 />
                            : this.state.practice === 11 ? <Practice11 />
                            : this.state.practice === 12 ? <><Practice12 /></>
                            : this.state.practice === 0 ? 'Current Practice'
                            : ''

                            
                }
            </div>
        );
    }
}
 
export default Practices;