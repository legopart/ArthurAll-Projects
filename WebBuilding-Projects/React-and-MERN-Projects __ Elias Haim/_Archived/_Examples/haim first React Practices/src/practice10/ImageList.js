import React, { Component } from 'react';
class ImageList extends Component {
    #image = 'https://picsum.photos/50';
    #runningNumber = 0;
    state = { 
        imageAddress: this.#image,
        urlAddress: '',
        arr : [],
        exampleImage : () => {return this.#image+'?'+(this.#runningNumber++) ;},
     } 
     
    render() { 

                
        function ge(id){return document.getElementById(id);}
        return (
            <div>
                <input id="image" type="url" value={this.state.imageAddress} onChange={
                    (e) => {this.setState({imageAddress : e.target.value }) } 
                    } placeholder='Image Address' /><br />
                <input id="url" type="url" value={this.state.urlAddress} onChange={
                    (e) => {this.setState({urlAddress: e.target.value}) } 
                    } placeholder='Url Address' /><br />
                <button onClick={() =>{
                        let arrState = this.state.arr;
                        let newObj = {imageAddress: this.state.imageAddress, urlAddress: this.state.urlAddress};
                        arrState.push(newObj)
                        this.setState({arr: arrState})
                } }>Add</button>
                <button onClick={() =>{
                        this.setState({urlAddress: '', imageAddress: this.state.exampleImage()})
                } }>Reset</button>
                <hr/>
                    <a href={'#'+this.state.urlAddress}><img alt={this.state.imageAddress} src={this.state.imageAddress} /></a>
                <hr/>
                    ImageList:
                    {
                        this.state.arr.map((x) => {
                            return <a href={'#'+x.urlAddress}><img alt={x.imageAddress} src={x.imageAddress} /></a>
                        })
                    }
                <hr/>
            </div>
        );
    }
}
 
export default ImageList;