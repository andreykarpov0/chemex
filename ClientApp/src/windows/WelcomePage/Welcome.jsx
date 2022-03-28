import React from 'react'

import './Welcome.css';

export default function Main({...props}) {

    const eventAct = () => {
        window.location.href = "/reg";
    }

    const eventActAuth = () => {
        window.location.href = "/auth";
    }

    return ( 
    <div className="mainPage">
        <p id="title">Chemex</p>
        <div className="container">
            <div className="info_block">
                <p id="welcome"> Добро пожаловать!</p> 
                <div className="button_row">
                    <div id="reg_btn" onClick={eventAct}>Создать аккаунт</div>
                    <div id="log_btn" onClick={eventActAuth}>Войти</div>
                </div>
            </div>
        </div>
    </div>
    )

  
}

//labElement.defaultProps = {items : {123}}