import React, {Component} from "react";
import { useDispatch,useSelector } from "react-redux";

export default function Item2Fun(props){
    const dispatchNow = useDispatch();
    let counter = useSelector(s=>s.counter);
    return <Item2 {...props} dispachNow = {dispatchNow} counter = {counter} />
}

class Item2 extends Component {
    state = {  } 
    render() { 
        return (<div>Item2    
        Updated:{this.props.counter} Item2
    </div>);
    }
}
