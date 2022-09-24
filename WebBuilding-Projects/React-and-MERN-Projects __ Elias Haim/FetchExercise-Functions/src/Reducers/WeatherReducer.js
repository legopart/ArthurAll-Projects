
// Action
export const AddWeather=(data)=> ({type:'ADD_RESULT', payload: data});
export const ResetWeather= ()=> ( {type:'RESET'});

// Reducer
export default function weatherReducer(state = {result: {}, history: []}, action){
    console.log(state);
    switch(action.type)
    {
        case "ADD_RESULT":  
            const arr = JSON.parse(JSON.stringify(state.history));
            return {
                result: {...action.payload}
                , history: [{...action.payload}, ...arr]
            };
        case "RESET": return {result: {}, history: []};
        default: return state;
    }
}