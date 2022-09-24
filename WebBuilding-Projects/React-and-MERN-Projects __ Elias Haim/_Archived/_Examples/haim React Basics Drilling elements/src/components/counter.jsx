

import React, { Component } from 'react';

/*export default*/ class Counter extends Component {
    // state = {  }
   constructor(props){
        super(props);   //set props inside constractur or dont set it!
        this.state = {
            imgUrl: 'https://picsum.photos/50?',
            // tags: ['tag1', 'tag2', 'tag3', ],
        };
        this.styles = {
            fontSize: 10, //px
            fontWeight: 'bold',
        }
        this.getButtonClasses = () =>{
            let classes = 'btn btn-sm m-2 ';
            classes += this.props.data.counter.value===0 ? 'btn-warning':'btn-primary';
            return classes;
        }
        this.getCountValue = () => {
            const {value} = this.props.data.counter; 
            return value === 0 ? 'zero' : value;
        }
    }


    render() { 
        const { imgUrl } = this.state;
        const { onDelete, onIncrement, counter } = this.props.data;
        return ( //<img src={this.imgUrl} alt="" /> 
                <div>
                    {this.props.children || ''}
                    <span>({ counter.value })</span>
                    <div style={this.styles} className={ this.getButtonClasses( counter ) } >{this.getCountValue()}</div>
                    <button onClick={() => onIncrement( counter ) /*this.handleIncreament*/} className={this.getButtonClasses()}>Increament</button> 
                    <button onClick={() => onDelete( counter.id ) } className="btn btn-danger btn-sm m-2">Delete</button>
                    <img src={imgUrl} alt="RandomImage200px" /> 
                    
                </div>
        );
    }



}
 
export default Counter;