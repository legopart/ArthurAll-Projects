import React, {Component} from 'react';
class OnOffButton extends Component {
    state = { } 
    render() { 
        const {line, button, setButton, getButton, isEditable} = this.props.data;
        return (<>
            <img line={line} button={button}  width="50" height="auto" alt='' 
                    src={ getButton(line, button) ? 'https://i.imgur.com/whHPmT0.png' : 'https://i.imgur.com/x8hxRVp.png' }
                    onClick={(e)=>{ if(isEditable)setButton(line, button); }}
                    />
        </>);
    }
}
export default OnOffButton;