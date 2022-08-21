import React from 'react';//, {useState}
import * as Mui from '@mui/material';
import { makeStyles as muiStyle } from '@mui/styles';
//import * as Icon  from '@mui/icons-material';


export function ButtonStyled(props){
  const useStyles = muiStyle({
    root: {
      background: 'linear-gradient(45deg, #FE6B8B 30%, #FF8E53 90%)',
      border: 0,
      borderRadius: 3,
      boxShadow: '0 3px 5px 2px rgba(255, 105, 135, .3)',
      padding: '0px 30px',
      marginBottom: '5px ! important',
      color: 'white ! important'
    },
  });
  const classes = useStyles();
  return <Mui.Button {...props} className={classes.root}>Test Text</Mui.Button>
}