import React, { Component } from 'react';

const NavBar = (/*props*/ {totalCounters}) => {
            return (
              <nav class="navbar navbar-light bg-light">
                    <span>Total Lines ({/*this.*//*props.*/totalCounters})</span>
               </nav>
        );
}
 
export default NavBar;