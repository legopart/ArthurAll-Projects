import React, { Component } from 'react';
import Books from './books.js';
class Practice11 extends Component {
    #maxCount = 3;
    state = { totalCount: 0, } 
    prevent(e){ e.preventDefault(); e.stopPropagation(); e.stopImmediatePropagation(); }
    addCount=(e)=>{
        if(this.state.totalCount >= this.#maxCount){
            alert(`Cant check more then maxCount (${this.#maxCount})`)
            return false;
        }
        this.setState({totalCount: this.state.totalCount + 1 })
        return true;
    }
    decreesCount=(e)=>{
        this.setState({totalCount: this.state.totalCount - 1 })
        return false;
    }

    render() { 
        return (
            <div>
                <div>Check count: {this.state.totalCount}</div>
                <Books addCount={this.addCount} decreesCount={this.decreesCount} />
            </div>
        );
    }
}

 
export default Practice11;