import React from 'react';
import Register from './Register';
import Login from './Login';

import GlobalLayout from './GlobalLayout';

import { BrowserRouter, Routes, Route, Link, useNavigate } from 'react-router-dom';


import { AuthProvider } from './context/AuthProvider';
import RequireAuth from './components/RequireAuth';
import { Navigate } from 'react-router-dom';

const {User, Editor, Admin}  = {  //ROLES
  User: 2001
  , Editor: 1984
  , Admin: 5150
}


const UnAuth = () => {
  const navigate = useNavigate();
  return (<button onClick={() => navigate(-1)} >Go Back</button>)
}
const App = () => {
  
  return (<>
  <BrowserRouter> <AuthProvider>
    <LinkPage />
    <Routes>
      <Route path="/" element={<GlobalLayout />}>
        
        <Route path="login" element={<Login />} />
        <Route path="register" element={<Register />} />
    
        <Route element={<RequireAuth allowedRoles={[2001]}/>}>
          <Route index element={<>Index1</>} />
        </Route>
        <Route element={<RequireAuth allowedRoles={[1984]}/>}>
          <Route path="editor" element={<>Editors Page2</>} />
        </Route>
        <Route element={<RequireAuth allowedRoles={[5150]}/>}>
          <Route path="admin" element={<>Admin Page3</>} />
        </Route>
        <Route element={<RequireAuth allowedRoles={[1984, 5150]}/>}>
          <Route path="lounge" element={<>Lounge Page4</>} />
        </Route>

        <Route path="unauthorized" element={<><br />Error 403 Unauthorized  <UnAuth /></>} />
        <Route path="*" element={<><br />Error 404 Page not found</>} />
      </Route>
    </Routes> 
  </AuthProvider> </BrowserRouter>
  </>);
}

export default App;

const LinkPage = () => {
    return (
        <section>
            Links<br />
            <br />
            Public<br />
            <Link to="/login">Login</Link><br />
            <Link to="/register">Register</Link><br />
            <br />
            Private<br />
            <Link to="/">Home</Link><br />
            <Link to="/editor">Editors Page</Link><br />
            <Link to="/admin">Admin Page</Link><br />
        </section>
    )
}