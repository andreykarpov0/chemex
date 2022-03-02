import React from 'react'

import './Reg.css';

export default function Reg() {
  return (
    <div>
      <h1>регестрация</h1>
      <form>
        <p>Имя</p>
        <input type="text"/>
        <p>Фамилия</p>
        <input type="text"/>
        <p>Почта</p>
        <input type="text"/>
        <p>Логин</p>
        <input type="text"/>
        <p>Пароль</p>
        <input type="password"/>
        <br/>
        <input type="submit"/>
      </form>
    </div>
  )
}
