import React from 'react';
import Component1  from './component1';
import ComponentAddLine from './componentAddEditLine';
import StateComponents from './stateComponents.js'
class Components extends StateComponents {
    render() { 
        return (<>

        <ComponentAddLine state={this.state} />

        {this.state.arr.map((x) => { return <Component1 val={x} state={this.state}  /> })}

        </>);
    }
}
 
export default Components;