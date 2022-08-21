import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import App from './App';
import { AuthProvider as AuthProviderContext } from './context/AuthProvider';
import { BrowserRouter, Routes, Route } from 'react-router-dom';

ReactDOM.render(
  <React.StrictMode>
    <BrowserRouter>
      <AuthProviderContext>
        <Routes>
          <Route path="/*" element={<App />} />
        </Routes>
      </AuthProviderContext>
    </BrowserRouter>
  </React.StrictMode>,
  document.getElementById('root')
);