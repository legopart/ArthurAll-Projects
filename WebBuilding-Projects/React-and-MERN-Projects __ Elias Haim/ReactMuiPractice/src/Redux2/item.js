
import { useDispatch,useSelector } from "react-redux";
import {AddOneCharAction} from './Reducers/CounterReducer';
import React, {Component} from 'react';

export default function ItemFunc(props){
    const dispatchNow = useDispatch();
    let counter = useSelector(s=>s.counter);
    return <Item {...props} dispachNow = {dispatchNow} counter = {counter} />
}

 class Item extends Component {
    state = {  } 
    render() { 
        return (<div>Item
        <button onClick={()=>{
            this.props.dispachNow(AddOneCharAction());
        }}>+</button>
        Updated:{this.props.counter}
    </div>);
    }
}
/*export const Item2=()=>{
    const dispachNow = useDispatch();
    let counter = useSelector(s=>s.counter);
}*/