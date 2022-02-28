import React, { Component } from 'react';
import { Route } from 'react-router';

import './custom.css'
import AuthForm from './window/AuthForm';
import RegForm from './window/RegForm';

export default function App() {
  return (
    <div>
      <Route exact path='/' component={AuthForm} />
      <Route path="/reg" element={RegForm} />
    </div>
  )
}

