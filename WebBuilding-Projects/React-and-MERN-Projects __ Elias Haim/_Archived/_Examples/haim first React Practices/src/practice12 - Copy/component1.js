import React, {Component} from 'react';
class Component1 extends Component {
    render() { 
        const keyValue = this.props.val[1];
        const TextValue = this.props.val[0];
        return (<div Key={keyValue}>
            {TextValue}
            <button onClick={() => { this.props.state.set({inputValue: TextValue, editedKey: keyValue})}}
            >Edit
            </button>
        </div>);
    }
}
export default Component1;