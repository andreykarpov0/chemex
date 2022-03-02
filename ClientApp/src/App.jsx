import React from 'react'
import {
    Route,
    Switch,
    Redirect
  } from "react-router-dom"

import './App.css';
import Auth from './windows/Auth';
import Home from './windows/Home';
import Reg from './windows/Reg';

export default function App({ history, ...props }) {
  return (
    <div>
        <h1>Наше приложение!</h1>
        <Switch>
            <Route path="/home" component={Home}/>
            <Route path="/reg" component={Reg}/>
            <Route path="/auth" component={Auth}/>
            <Redirect from='/' to='/home'/>
        </Switch>
    </div>
  )
}
