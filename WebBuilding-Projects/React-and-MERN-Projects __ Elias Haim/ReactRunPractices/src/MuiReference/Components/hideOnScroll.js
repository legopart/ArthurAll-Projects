
import React from 'react'; //, {useState}
import * as Mui from '@mui/material';
//import { makeStyles as muiStyle } from '@mui/styles';
//import * as Icon  from '@mui/icons-material';

export function HideOnScroll(props) {
  const { children, window } = props;
  const trigger = Mui.useScrollTrigger({ target: window ? window() : undefined,});
  return ( <Mui.Slide appear={false} direction="down" in={!trigger}>
      {children}
    </Mui.Slide>);
}