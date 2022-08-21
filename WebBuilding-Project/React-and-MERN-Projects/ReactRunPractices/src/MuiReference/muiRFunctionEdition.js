import logo from './logo.svg';
import './muiReference.css';
import React from 'react'; //useState
import * as Mui from '@mui/material';
import * as Icon  from '@mui/icons-material';

import {ButtonStyled, CheckboxExample, HideOnScroll, } from './Components';
import {MuiStyle} from './muiRStyle';
//  https://mui.com/customization/color/
//  https://mui.com/system/palette/#color

import { useNavigate, } from 'react-router-dom';

export default function MuiRFunction(props)  {
    let navigate = useNavigate();
    return (
      <MuiStyle>
        <Mui.Container maxWidth="xs">
              {/* https://mui.com/components/app-bar/
                  https://mui.com/api/app-bar/  */}
            <HideOnScroll {...props}><Mui.AppBar color="secondary" position="fixed" sx={{maxHeight: '50px ! important'}}>
                <Mui.Toolbar>
                  <Mui.IconButton> <Icon.Menu />  </Mui.IconButton>
                  <Mui.Typography variant="body2">  MUI Theming </Mui.Typography>
                  <Mui.Button sx={{color: Mui.colors.cyan[100] }}>Login</Mui.Button>
                </Mui.Toolbar>
            </Mui.AppBar></HideOnScroll>
            <Mui.Toolbar />
              
              <button onClick={()=>navigate("/2")}>Home/2</button>
                    
          <div className="App-header">
                <Mui.Typography variant="h2"> h5. Heading </Mui.Typography>
                <Mui.Typography variant="subtitle"> sub head </Mui.Typography>
                <Mui.Typography variant="body2"> Text output </Mui.Typography>
                  --({props?.params?.aa})--
                <ButtonStyled />

                {/* https://mui.com/api/grid/
                  https://smartdevpreneur.com/the-complete-guide-to-material-ui-grid-align-items/ */}
                <Mui.Grid container spacing={3} justifyContent="center" alignItems="center">
                  <Mui.Grid item xs={12} sm={6}> <Mui.Paper style={{ height: 75, width: '100%', }}/> </Mui.Grid>
                  <Mui.Grid item xs={3}> <Mui.Paper style={{ height: 75, width: '100%', }}/> </Mui.Grid>
                  <Mui.Grid item xs={3}> <Mui.Paper style={{ height: 75, width: '100%', }}/> </Mui.Grid>
                </Mui.Grid>

                <br />

                <Mui.TextField className="textField" type="text" variant="outlined" color="primary"
                  label="The Time" helperText="Type your text here" placeholder="Put your text here"
                />

                <div><CheckboxExample /></div>

                <Mui.ButtonGroup> {/*variant="contained" color="primary"*/}
                      <Mui.Button href="#"  endIcon={<Icon.Save />}
                        variant="contained" color="primary" style={{fontSize: 9}}  size="small"
                      >
                        Button
                      </Mui.Button>

                      <Mui.Button href="#"  startIcon={<Icon.Delete />}
                        variant="contained" color="secondary" style={{fontSize: 9}} size="small"
                      >
                        Example
                      </Mui.Button>
                </Mui.ButtonGroup>
              <img src={logo} className="App-logo" alt="logo" />
              <p> Edit <code>src/App.js</code> and save to reload. </p>
              <a className="App-link"  href="https://reactjs.org"  target="_blank" rel="noopener noreferrer" > Learn React </a>
          </div>
        </Mui.Container>
      </MuiStyle>
    );
  
}
 


