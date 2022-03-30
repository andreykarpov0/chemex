import React from 'react'

import './Reg.css';
import Menu from './../../Components/MenuComponent/Menu';
import GetMenuItems from './../../Components/MenuComponent/GetMenuItems';

export default function Reg() {

  const eventActAuth = () => {
    window.location.href = "/auth";
}

  return (
    <div>
     <Menu items={GetMenuItems()}/>
      <p id="title">Chemex</p>
        <div className="containerReg">
            <div className="reg_block">
                <p id="reg_title">Регистрация</p>
                <input id="log_input" type="text" placeholder="Логин"/>
                <input id="email_input"type="email" placeholder="Почта"/>
                <input id="pass_input" type="password" placeholder="Пароль"/>
                <input id="repass_input" type="password" placeholder="Повторите пароль"/>
                <div id="reg_btn">Создать аккаунт</div>
            </div>
            <div className="log_block">
                <p styles="color: #222F2C;">Уже есть аккаунт? &nbsp;</p>
                <p styles="color: #A4798E; font-weight: 700;" onClick={eventActAuth}>Войти</p>
            </div>
        </div>
      </div>
  )
}
