import React from 'react'

import './Auth.css';
import Menu from './../../Components/MenuComponent/Menu';
import GetMenuItems from './../../Components/MenuComponent/GetMenuItems';

/*
Todo разобраться зачем это надо
<Menu items={GetMenuItems()}/>

*/

export default function Auth() {

  const eventAct = () => {
    window.location.href = "/reg";
}

  return (
    <div>
      <p id="title">Chemex</p>
      <div className="containerAuth">
        <div className="log_block">
          <input id="login" type="login" placeholder="Логин"/>
          <input id="password" type="password" placeholder="Пароль"/>
          <div id="log_btn">Войти</div>
          <div id="create_btn" onClick={eventAct}>Создать аккаунт</div>
        </div>
      </div>
    </div>
  )
}
