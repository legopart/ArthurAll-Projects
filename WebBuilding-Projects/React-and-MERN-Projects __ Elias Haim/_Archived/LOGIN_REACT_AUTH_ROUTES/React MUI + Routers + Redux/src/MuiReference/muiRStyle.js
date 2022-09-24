import './muiReference.css';
import * as Mui from '@mui/material';
import * as MuiStyles from '@mui/material/styles';

const theme = MuiStyles.createTheme({  //https://mui.com/styles/basics/
  palette: {
    primary:{
      main: Mui.colors.green[500]
    },
    secondary:{
      main: Mui.colors.blue[400]
    }
  }
  , typography: {
    h2: {
      fontSize: 24,
      marginBottom: 1
    }
    , body2: {
        color: Mui.colors.deepPurple[500]
    }
    ,button: {
      sx: {
        fontSize: 20,
      }
    }
  }
});


export function MuiStyle(props){
  return(<MuiStyles.ThemeProvider theme={theme}>
   {props.children}
  </MuiStyles.ThemeProvider>);
}




