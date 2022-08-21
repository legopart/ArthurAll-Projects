import { useState } from "react";
import {redux, /*incrementAction, decrementAction,*/ resetAction} from './ReduxActions';
export const Book = ()=>
{
    let [state,setState] = useState('');

    return <div>Book
        <input onChange={(e)=>{
            console.log(e.target.value);
            setState(e.target.value);
            if(e.target.value==="RESET")
                redux.dispatch(resetAction());
        }} />
        {state}
        </div>
}