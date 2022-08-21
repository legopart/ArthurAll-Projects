import React, { Component } from 'react';
import Data from './Data.js';
import ImageList from './ImageList.js';

class Index09 extends Component {
    state = {  } 
    render() { 
        return (<div>
                <ImageList/>
                <Data />
        </div>);
    }
}
 
export default Index09;