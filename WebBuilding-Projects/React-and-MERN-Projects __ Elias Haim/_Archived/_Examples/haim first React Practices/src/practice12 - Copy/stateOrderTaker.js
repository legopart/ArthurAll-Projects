import {Component} from 'react';
class stateOrderTaker extends Component {

        data =  {
            isEditable:true,
            setButton: (line, button) => {
                    const arr = this.state.arr;
                    arr[line][button] = !arr[line][button];
                    this.setState({ arr })
                },
            getButton: (line, button) =>  this.state.arr[line][Number(button)],
        };

        dataResult =  {
            isEditable:false,
            setButton: (line, button) => {},
            getButton: (line, button) =>  this.state.arrResults[line][Number(button)],
        };

        getData = (data, line) => {
            const d={...data};
            d['line'] = line;
            return d;
        }

    state = { 
        orders: 1,
        arr: [  ],
        arrResults: [  ]
     } 

    arrClone(arr){  //up to second level
        const newArr =[];
        arr.map((x) => {newArr.push([...x])} )
        return newArr;
    }
}
export default stateOrderTaker;