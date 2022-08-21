import React, {Component} from 'react';
import OrderTaker from './orderTaker.js';
import OnOff1Button from './onOff1Button.js';
import Components from './components.js';
class Practice12 extends Component {
    state = {  } 
    render() { 
        return (<>
            <Components />
            <br />
            <div><OnOff1Button /></div>
            <br />
            <OrderTaker />
            <br />
        </>);
    }
}
 
export default Practice12;