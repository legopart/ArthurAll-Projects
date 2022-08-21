import { createStore } from 'redux';
//Actions to fix !!!
export const incrementAction = () => ({ type: 'INCREASE' });
export const decrementAction = () => ({ type: 'DECREASE' });
export const resetAction = () => ({ type: 'RESET' });
//Reducer to fix !!!
const counterReducer = (state, action)=>{
  console.log('aaa', state, action)
    switch(action?.type)
    {
        case 'INCREASE': return state + 2;
        case 'DECREASE': return state - 2;
        case 'RESET': return 0;
        default: return 3;// default value
    }
}
export const redux = createStore(counterReducer);


const stateReducer = (state = {data: 6} , action ) => {
if( action?.type === 'SET_DATA') return action.payload?.data;
return state.data;
}
export const stateRedux = createStore(stateReducer);
export const setData = data => ({ type: 'SET_DATA', payload:{data: data} });


const arrayReducer = (state = {data: []} , action ) => {

  if(action?.type === 'ARRAY_ADD'){
    const {data} = action.payload;
    let arr = [...state.data, data];
    return {data: arr}
  }
  else if(action?.type === 'ARRAY_REMOVE'){
    const {data} = action.payload;
    //let i = state.data.indexOf(x => x === data);
    //return state.filter(bug => bug.id !== action.payload.id);
    let arr = [...state.data.slice(1)];
    return {data: arr}
  }
  else if(action?.type === 'ARRAY_UPDATE'){
    const {data} = action.payload;
   
    let arr = [data,...state.data.slice(1)];
    return {data: arr}
  }
  else if(action?.type === 'ARRAY_MODIFIED'){
    //return state.map(bug => bug.id !== action.payload.id ? bug : {...bug, resolved: true});
  }
  return state;

}
export const arrayRedux = createStore(arrayReducer);
export const arrayAdd = data => ({ type: 'ARRAY_ADD', payload:{data: data} });
export const arrayRemove = (data) => ({ type: 'ARRAY_REMOVE', payload:{data: data} });
export const arrayUpdate = (data) => ({ type: 'ARRAY_UPDATE', payload:{data: data} });

