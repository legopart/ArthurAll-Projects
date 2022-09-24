import React, {Component} from 'react';
import OnOff from './onOffButton';
class Order extends Component {
    state = {  } 
    render() { 
        const {line, setButton, getButton, isEditable}=this.props.data;
        const data = {line, setButton, getButton, isEditable};
        const GetDataSetButton = (button) => {
            const d = {...data};
            d['button'] = button;
            return d;
        };
        return (<div>
        <OnOff data={ GetDataSetButton(0) } />
        <OnOff data={ GetDataSetButton(1) } />
        <OnOff data={ GetDataSetButton(2) } />
        <OnOff data={ GetDataSetButton(3) } />
        </div>);
    }
}
export default Order;