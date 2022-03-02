import React from 'react'

import './Auth.css';

export default function Auth() {
  return (
    <div>
      <form action="">
        <p className="text">Логин или почта</p>
        <input type="text" className="formTextInput"/>
        <p className="text">Пароль</p>
        <input type="password" className="formTextInput"/>
        <br/>
        <input type="submit" className="formSubmitBtn"/>
      </form>
    </div>
  )
}
