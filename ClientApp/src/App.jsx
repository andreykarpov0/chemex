import React from 'react'
import {
    Route,
    Switch,
    Redirect
  } from "react-router-dom"

import './App.css';
import Auth from './windows/LogOrSignin/Auth';
import Home from './windows/DocListWindow/DocList';
import Main from './windows/WelcomePage/Welcome';
import Reg from './windows/LogOrSignin/Reg';
// import '../Components/Menu';




export default function App({ history, ...props }) {

  return (
    <div className="mainBody"> 
        <Switch>
            <Route path="/doclist" component={doclist}/>
            <Route path="/welcome" component={Main}/>
            <Route path="/reg" component={Reg}/>
            <Route path="/auth" component={Auth}/>
            <Redirect from='/' to='/welcome'/>
        </Switch>
    </div>
  )
}
