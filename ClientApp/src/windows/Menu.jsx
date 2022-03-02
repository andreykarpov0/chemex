import React from 'react'

import './Menu.css';

export default function Home() {
  return (
    <div>
        <hr />
        <a href="/home">Домой</a> <a href="/auth">Авторизироваться</a> <a href="/reg">Зарегистрироваться</a>
        <hr />
    </div>
  )
}
