import React, {useState} from 'react';
import * as Mui from '@mui/material';
//import { makeStyles as muiStyle } from '@mui/styles';
import * as Icon  from '@mui/icons-material';

export function CheckboxExample(){
  const [getChecked, setChecked] = useState(true);
  return (
    <Mui.FormControlLabel
      control={
        <Mui.Checkbox
          checked = {getChecked}
          icon = {<Icon.Save />}
          checkedIcon = {<Icon.Save />}
          onChange = {(e) => setChecked(e.target.checked)}
          color="primary"
        />
      }
      label="Testing Checkbox"
    />
  )
}