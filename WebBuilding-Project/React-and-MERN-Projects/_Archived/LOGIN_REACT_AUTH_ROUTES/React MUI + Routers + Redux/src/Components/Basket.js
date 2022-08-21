import React, {Component} from "react";
export function Basket (props)  {
        const [price, setPrice] = React.useState('fdsf');
        let {checkedData, data} = props?.state
        return (<>
            Basket<br />
            <ul>
                {checkedData?.sort().map( (x, i) => ( <li key={i}>{data[x-1].title}</li>  ) )}
            </ul>

            <button type="button" onClick={() => {
                let totalPrice = 0;
                checkedData?.sort().map( (x, i) =>  {
                    let itemPrice = data[x-1].price;
                    if (data[x-1].id % 2 === 0) itemPrice *= 0.9;
                    return totalPrice += itemPrice}   );
                setPrice(totalPrice);
            }}>Get Total Price</button>{' '}
            { price }<br />
            </>);
    
}