import React, { Component } from 'react';
import Data from './Data.js';
import ImageList from './ImageList.js';
import DisableInput from './DisableInput.js';
import Tags from './Tags.js';
import TaxesCounter from './TaxesCounter.js';
class Index09 extends Component {
    state = {  } 
    render() { 
        return (
        <div>
            <h3>Html Tags</h3>
            <Tags />
            <h3>Input Disable</h3>
            <DisableInput />
            <h3>Image List</h3>
            <ImageList/>
            <h3>Data Hide</h3>
            <Data />
            <h3>Tax Calculator</h3>
            <TaxesCounter />
        </div>
        );
    }
}
 
export default Index09;