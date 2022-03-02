import React from 'react'

import './Auth.css';

export default function Auth() {
  return (
    <div>
      <form action="">
        <p>Логин/Почта</p>
        <input type="text" />
        <p>Пароль</p>
        <input type="password" />
        <br/>
        <input type="submit" />
      </form>
    </div>
  )
}
