import React, { Component } from 'react';
class DisableInput extends Component {
    state = { txtVal: "", editMode: 1  } 

    render() { 

        let inputDisabled = <div>{this.state.txtVal}<br /></div>;

        let inputRegular = (
            <div>
                <input placeholder="Insert Text " value={this.state.txtVal} onChange={(event) => {
                    this.setState({ txtVal: event.target.value });
                    }} />
            </div>
        );

        let template = (
        <div>
            <button onClick={() => {  this.setState({ editMode: 1 }); }} > 
            Edit Mode
            </button>

            <button onClick={() => { this.setState({ editMode: 0 }); }} >
            Updtae
            </button>

            {this.state.editMode === 1 ? inputRegular : inputDisabled}

            <hr />
        </div>
        );
        return template;
    }
}
 
export default DisableInput;