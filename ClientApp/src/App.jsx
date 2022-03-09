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
import Menu from './windows/Menu';

export default function App({ history, ...props }) {

const arr = [{url: "/home", name : "Домой"}, {url: "/auth", name : "Авторизироваться"}, {url: "/reg", name : "Зарегистрироваться"}];
  return (
    <div className="mainBody"> 
        <h1>Chemex</h1>
        <Menu items={arr}/>
        <Switch>
            <Route path="/home" component={Home}/>
            <Route path="/reg" component={Reg}/>
            <Route path="/auth" component={Auth}/>
            <Redirect from='/' to='/home'/>
        </Switch>
    </div>
  )
}
