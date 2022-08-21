import React, { Component } from 'react';
import Counter from './counter';

class Counters extends Component {
    state = {  } 
    render() { 
        const {onReset, onIncrement, onDelete, counter} = this.props;//prop or object distructuring

        return (
        <div>
            <button onClick={/*this.props.*/ onReset } className="btn btn-primary btn-sm m-2">Reset</button>
            {this.props.counters.map(
                counter => 
                    <Counter 
                        onIncrement={/*this.props.*/onIncrement}
                        onDelete={/*this.props.*/onDelete}
                        counter={counter /*All possible values*/}
                         key={counter.id}  selected>
                        <h5>Chidren #{counter.id}</h5>
                    </Counter> // selected={true} // value={counter.value} id={counter.id}, all set in "counter"
            )}
        </div>
        );
    }

    /*state = { 
        counters:[
            {id: 1, value: 12, onDelete: this.id}, //do foreach for each onDelete Add
            {id: 2, value: 0, onDelete: this.id},
            {id: 3, value: 0, onDelete: this.id},
            {id: 4, value: 0, onDelete: this.id},
            {id: 5, value: 0, onDelete: this.id},
        ],
     } 
     handleIncreament= (counter) =>{ 
         const counters = [...this.state.counters]
         const index = counters.indexOf(counter);
         counters[index] = {...counter};    //add {id: *, value: *,
         counters[index].value++;
        console.log('counter', counters[index] );
        this.setState( { counters } );
     }
     handleDelete = (counterId) => {
            const counters = this.state.counters.filter(c => c.id !== counterId);
            this.setState({ counters }); //counters: counters
            console.log('Event Handler Called', counterId);
     }*/


}
 
export default Counters;