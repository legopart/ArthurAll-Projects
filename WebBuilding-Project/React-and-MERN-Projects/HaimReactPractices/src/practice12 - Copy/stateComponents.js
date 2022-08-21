import {Component} from 'react';
class State1 extends Component {
    #runNumber = 1; //no 0!!!
    state = { 
        inputValue: 'dfdf',
        arr: [['aaa', this.#runNumber++], ['bbb', this.#runNumber++], ['ccc', this.#runNumber++], ['ddd', this.#runNumber++], ],
        addToArr: ()=>{this.addToArr()},
        editedKey: null,
        set: (e) => {this.setState(e)}
     } 
     addToArr = () => {
        const {arr, inputValue, editedKey} = this.state;
        let newArr;
        if(editedKey){
            const i = arr.findIndex(x => x[1]===editedKey);
            if(i >= 0) {
                arr[i][0] = inputValue;
                newArr = [...arr];
            }
        } else newArr= [[inputValue, this.#runNumber++], ...arr];

        this.setState({inputValue:'', arr: newArr, editedKey: null});
     }
}
 
export default State1;