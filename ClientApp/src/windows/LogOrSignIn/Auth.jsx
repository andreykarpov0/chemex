import React from 'react'

import './Auth.css';
import Menu from './../../Components/MenuComponent/Menu';
import GetMenuItems from './../../Components/MenuComponent/GetMenuItems';

export default function Auth() {
  return (
    <div className="auth">
      <Menu items={GetMenuItems()}/>
      <div className="authDiv">
        <form action="">
          <p className="text">Логин / почта</p>
          <input type="text" className="formTextInput"/>
          <p className="text">Пароль</p>
          <input type="password" className="formTextInput"/>
          <br/>
          <div className="formSubmitBtn">Войти</div>
        </form>
      </div>
      
    </div>
  )
}
