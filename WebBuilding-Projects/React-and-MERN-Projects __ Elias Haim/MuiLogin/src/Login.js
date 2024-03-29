import React from 'react';
import { Avatar, Button, CssBaseline, TextField, FormControlLabel, 
  Checkbox, Link as MuiLink, Grid, Box, Typography, Container } from '@mui/material';
import LockOutlinedIcon from '@mui/icons-material/LockOutlined';
import { createTheme, ThemeProvider } from '@mui/material/styles';

import useAuth from './context/AuthProvider';
import { Link, useNavigate, useLocation } from 'react-router-dom';
import {Axios, Async} from './api/axios';

export default function SignIn() {
  const { auth, setAuth } = useAuth();


  const location = useLocation();
  const from = location.state?.from?.pathname || "/";
  const navigate = useNavigate();

  function goFrom(){
    navigate(from, { replace: true });
  }

  const userRef = React.useRef('fghfghhfg');
  const passwordRef = React.useRef();
  const errRef = React.useRef();
  const [errMsg, setErrMsg] = React.useState('');
  React.useEffect(() => {
    console.log('auth' ,auth)
    userRef.current.value = auth.email || '';
    passwordRef.current.value = auth.password || '';
    userRef.current.focus(); 
  }, [auth] );
  return (
    <ThemeProvider theme={createTheme()}>
      <Container component="main" maxWidth="xs">
        <CssBaseline />
        <Box sx={{ marginTop: 8, display: 'flex', flexDirection: 'column', alignItems: 'center', }}>
          <Avatar sx={{ m: 1, bgcolor: 'secondary.main' }}> <LockOutlinedIcon /> </Avatar>
          <Typography component="h1" variant="h5"> Sign in </Typography>
          <Box component="form" onSubmit={(e) => handleSubmit(e, setErrMsg, goFrom, setAuth, auth )} noValidate sx={{ mt: 1 }}>
            <TextField inputRef={userRef} margin="normal" required fullWidth id="email" label="Email Address"
              name="email" autoComplete="email" autoFocus />
            <TextField inputRef={passwordRef} margin="normal" required fullWidth name="password" label="Password"
              type="password" id="password" autoComplete="current-password" />
            <FormControlLabel label="Remember me" control={<Checkbox value="remember" color="primary" />} />
            <Typography variant="body2" color="text.secondary" ref={errRef} >|{errMsg}|</Typography>
            <Button type="submit" fullWidth variant="contained" sx={{ mt: 3, mb: 2 }}> Sign In </Button>
            <Grid container variant="body2">
              <Grid item xs> <Link to="#"> Forgot password? </Link> </Grid>
              <Grid item> <Link to="/register"  > {"Don't have an account? Sign Up"} </Link> </Grid>
            </Grid>
          </Box>
        </Box>
        <Copyright sx={{ mt: 8, mb: 4 }} />
      </Container>
    </ThemeProvider>
  );
}

const handleSubmit = (event, setErrMsg, goFrom, setAuth, auth) => {
  event.preventDefault();
  const data = new FormData(event.currentTarget);
  console.log({ email: data.get('email'), password: data.get('password'), });
  //if true!
  

  Async( async() => {
    const result = await Axios('POST', '/api/login', {email: data.get('email'), password: data.get('password')}, {});
    if(await result.error) setErrMsg(result.error)
    else if(await result.data) {
      result.data.role = [await result.data.type];
      delete await result.data.type;
      setAuth({name: await result.data.name,email: await result.data.email , roles: [2001], accessToken: await result.data.accessToken }) //set roll
      console.log('auth', auth);
      goFrom();
    } else setErrMsg('no server connection');
    console.log('resultLogin ',result);

  });

};

const Copyright = props =>  (
    <Typography variant="body2" color="text.secondary" align="center" {...props}>
      {'Copyright © '} <MuiLink color="inherit" href="https://mui.com/"> Your Website </MuiLink> {' '} {new Date().getFullYear()} {'.'}
    </Typography>
);