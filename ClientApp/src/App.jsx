import React from 'react'
import {
    Route,
    Switch,
    Redirect
  } from "react-router-dom"

import './App.css';
import Auth from './windows/Auth';
import Home from './windows/Home';
import Main from './windows/Main';
import Reg from './windows/Reg';
import Test from './windows/Test';
// import '../Components/Menu';




export default function App({ history, ...props }) {

  return (
    <div className="mainBody"> 
        <Switch>
            <Route path="/home" component={Home}/>
            <Route path="/main" component={Main}/>
            <Route path="/reg" component={Reg}/>
            <Route path="/auth" component={Auth}/>
            <Route path="/ttt" component={Test}/>
            <Route path="/ttt" component={Test}/>
            <Redirect from='/' to='/main'/>
        </Switch>
    </div>
  )
}
