
import {redux,incrementAction,decrementAction} from './ReduxActions';

export const Item = ()=>
{
    return <div>Item Increment
        <button onClick={()=>{
            redux.dispatch(incrementAction());
        }}>
        +
        </button>
        <button onClick={()=>{
            redux.dispatch(decrementAction());
        }}>
        -
        </button>
        Item</div>
}