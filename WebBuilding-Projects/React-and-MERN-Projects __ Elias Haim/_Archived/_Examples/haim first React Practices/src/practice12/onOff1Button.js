import React, {Component} from 'react';
class OnOff1Button extends Component {
    state = { on: false } 
    render() { 
        return (<>
            <img width="50" height="auto" alt={this.state.on ? 'on' : 'off'} src={
                this.state.on ? 'https://i.imgur.com/whHPmT0.png'
                 : 'https://i.imgur.com/x8hxRVp.png'
            } onClick={()=>{this.setState({on: !this.state.on})}}/>
        </>);
    }
}
 
export default OnOff1Button;