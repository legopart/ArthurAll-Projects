import React, {Component} from 'react';
class ComponentSaveLine extends Component {
    render() { 
        return (<div>
            <input value={this.props.state.inputValue}
                onChange={(e) => {this.props.state.set({inputValue: e.target.value});}}
             />
            <button onClick={() => {this.props.state.addToArr(this.state.keyValue); }}
            > Add/Edit
            </button>
        </div>);
    }
}
export default ComponentSaveLine;