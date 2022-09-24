import React, {Component} from 'react';
import './App.css';
import { /*BrowserRouter,*/ Routes, Route, Link,  } from 'react-router-dom';  // useParams,

import {Provider} from 'react-redux';
import {createStore} from 'redux';
import appReducers from './Reducers'

import Item from './Components/Item/Item';
import History from './Components/History'

const store = createStore(appReducers,window.__REDUX_DEVTOOLS_EXTENSION__ && window.__REDUX_DEVTOOLS_EXTENSION__())

export default function Appfun(props){

return <App {...props} />
}

 class App extends Component {
  state = {  } 
  render() { 
    console.log(this.props.url);
    return ( 
  <Provider store={store}>
    <div className="App">
      
          Weather API:<br />
          <Link to="./Item">Item</Link>{' | '}
          <Link to="./History">History</Link>{' | '}
          <br />
          <Routes>
        
           
            <Route path="/">
              <Route index element={<><Item /></>} />
              <Route path="/item" element={<><Item /></>} />
               <Route path="/history" element={<><History /></>} />
            </Route>
            <Route path="*" element={<>Error<br /></>} />
          </Routes>
      
    </div>
  </Provider>
   );
  }
}
 


