import React, {Component} from "react";
export class Basket extends Component {
    render() { 
        let {checkedData, data} = this.props?.state
        return (<>
            Basket<br />
            <ul>
                {checkedData?.sort().map( (x, i) => ( <li key={i}>{data[x].title}</li>  ) )}
            </ul>
            </>);
    }
}