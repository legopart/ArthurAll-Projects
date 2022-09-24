
// Action
export const AddOneCharAction=()=>{
    return {type:'ADD_ONE_CHAR'};
}

export const AddCharAction=(aData)=>{
    return {type:'ADD_CHAR',Data:aData};
}

export const ResetAction=()=>{
    return {type:'RESET'};
}

// Reducer
export const reducerCounter=(state,action)=>{

    switch(action.type)
    {
        case "ADD_ONE_CHAR":  return state+1;
        case "ADD_CHAR": return state+action.Data;
        case "RESET": return state+1;
        default: return 0;
    }

}
