import React, {Component} from 'react';
import Order from './order.js';
import StateOrderTaker from './stateOrderTaker.js'
class orderTaker extends StateOrderTaker {
    render() { 
        //to build contracture function

        return (<div>

            <div>Orders: 
            <input type="number" value={this.state.orders} onChange={(e) => {this.setState({orders:e.target.value})}} />
            <button onClick={() => {  //update order amount
              const arr = this.state.arr, counter = this.state.orders;
              if(arr.length > counter) arr.length = counter;
              else if(counter >= 0) for(let i=arr.length; i< counter;i++) arr.push([false, false, false, false]);
              this.setState({arr});
              } }>Set Order</button>
            </div>

            {/*set a Key!!!*/}
            {  this.state.arr.map((x, line) => { return <div><Order data={this.getData(this.data, line)} /></div>} ) }

            <div><button onClick={ () => {this.setState({arrResults: this.arrClone(this.state.arr)})} }>Result</button></div>
            { this.state.arrResults.map((x, line) => { return <div><Order data={this.getData(this.dataResult, line)} /></div> }) }

            <br />

          </div>);
    }
}
 
export default orderTaker;