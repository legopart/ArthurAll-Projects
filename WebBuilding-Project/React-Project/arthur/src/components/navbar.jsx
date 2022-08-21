import React, { Component } from 'react';


//State Less Functional Component   // sfc <tab>
const NavBar = (/*props*/ {totalCounters}) => { //!!! //prop or object distructuring
            return (
              <nav class="navbar navbar-light bg-light">
                    <a href="#" className='navbar-brand'>Navbar</a>
                    <span>Total Lines ({/*this.*//*props.*/totalCounters})</span>
               </nav>

               
        );
}

/*class NavBar extends Component {
    state = {  } 
    render() { 
            //...
    }
}*/
 
export default NavBar;