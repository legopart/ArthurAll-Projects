import { createStore } from 'redux';
// Action
export const SetLocation=(data)=> ({type:'SET_LOCATION', payload: data});
// Reducer
function locationReducer(state='London', action){
    console.log(state);
    switch(action.type)
    {
        case "SET_LOCATION":  
            return action.payload;
        default:
            return state;
    }
}

export const locationRedux = createStore(locationReducer);