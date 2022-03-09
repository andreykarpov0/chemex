import React from 'react'

import './Auth.css';

export default function Auth() {
  return (
    <div className="auth">
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
