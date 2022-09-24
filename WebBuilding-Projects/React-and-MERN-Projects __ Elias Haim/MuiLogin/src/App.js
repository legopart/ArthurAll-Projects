import React from 'react';
import Register from './Register';
import Login from './Login';

import Layout from './Layout';

import { BrowserRouter, Routes, Route, Link, useNavigate } from 'react-router-dom';


import { AuthProvider } from './context/AuthProvider';
import RequireAuth from './components/RequireAuth';

const {User, Editor, Admin}  = {  //ROLES
  User: 2001
  , Editor: 1984
  , Admin: 5150
}

const App = () => {

  return (<>
  <BrowserRouter> <AuthProvider>
    <LinkPage />
    <Routes>
      <Route path="/" element={<Layout />}>
        
        <Route path="login" element={<Login />} />
        <Route path="register" element={<Register />} />
        <Route path="unauthorized" element={<>unauthorized  <button onClick={{/*() => useNavigate()(-1)*/}} >Go Back</button></>} />

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

        
        <Route path="*" element={<><br />Error 404</>} />
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