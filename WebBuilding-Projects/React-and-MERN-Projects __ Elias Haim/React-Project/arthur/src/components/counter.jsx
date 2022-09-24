import React, { Component } from 'react';
/*export default*/ class Counter extends Component {
    state = {  //compunnent data
        //count: this.props.counter.value || 0,     //Clearing local state! //for 1 source of thruth
        imgUrl: 'https://picsum.photos/50',
        tags: ['tag1', 'tag2', 'tag3', ],
        /*  address: {
            street: '',
        },*/
        }

    styles = {
        fontSize: 10, //px
        fontWeight: 'bold',
        }


        
   constructor(props){
        super(props);   //set props inside constractur or dont set it!
        /*
        this.state = {
            count: props.zzz || 0,
            tags: []
        };*/
        //console.log('props', this.props.value);//^
       //this.handleIncreament.bind(this); // moving this to the function (?)
        }
     


    render() { 
        //console.log(this.props);
        //React.createElement
        //ctrl d
        const { imgUrl } = this.state;
        const { counter } = this.props;
        //let classes = 'btn btn-sm m-2 ';
        //classes += this.state.count===0 ? 'btn-warning':'btn-primary';
        return ( //<img src={this.imgUrl} alt="" /> 
        //call function withou ()
        
        <div>
            {this.props.children || ''}
            <span>({ counter.value })</span>
            <div style={this.styles} className={ this.getButtonClasses( counter ) } >{this.getCountValue()}</div>
            {/*<h5 style={{ fontSize: 30  }}>Hello World {2+2}</h5>*/}
            <button onClick={() => {this.props.onIncrement( counter )}/*this.handleIncreament*/} className={this.getButtonClasses()}>Increament</button> 
            <button onClick={() => this.props.onDelete( counter.id ) } className="btn btn-danger btn-sm m-2">Delete</button>
            <img src={imgUrl} alt="RandomImage200px" /> 
            <ul>{this.state.tags.map(tag => <li key={tag}>{tag}</li>)}</ul>
        </div>
        );
    }

    getButtonClasses(){
        let classes = 'btn btn-sm m-2 ';
        classes += this.props.counter.value===0 ? 'btn-warning':'btn-primary';
        return classes;
    }
        

    getCountValue(){
        //const {count} = this.state; //object distracturing
        const {value} = this.props.counter; //object distracturing
        return value === 0 ? 'zero' : value;
    }
}
 
export default Counter;