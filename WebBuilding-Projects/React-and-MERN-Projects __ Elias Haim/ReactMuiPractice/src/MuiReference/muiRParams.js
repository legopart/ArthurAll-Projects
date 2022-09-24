import React from 'react';
import { useParams, useNavigate } from 'react-router-dom';

import MuiReference from './muiReference';
export default function Aa1(props) {
    return( <><MuiReference {...props}  params={useParams()} navigation={useNavigate()}/>
    </>
     
    );
}