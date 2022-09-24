import React, { Component } from 'react';
import Counter from './counter';

class Counters extends Component {
    constructor(props){
        super(props);
        this.state = {  } 
    }
    
    render() { 
        const {onReset, onIncrement, onDelete, counters} = this.props.data;
        return (
            <div>
                <button onClick={/*this.props.*/ onReset } className="btn btn-primary btn-sm m-2">Reset</button>
                {
                    counters.map( counter => 
                        <Counter
                            data = {{ onDelete: onDelete, onIncrement: onIncrement, counter: counter, }}
                            key={counter.id}
                        >
                            <h5>Children #{counter.id}</h5>
                        </Counter>
                )}
            </div>
        );
    }

}

export default Counters;