import React from 'react'

import './Welcome.css';

export default function Main({...props}) {

    const eventAct = () => {
        window.location.href = "/reg";
    }

    return ( 
    <div className="mainPage">
        <p id="title">Chemex</p>
        <div className="container">
            <div className="info_block">
                <p id="welcome"> Добро пожаловать!</p> 
                <div className="button_row">
                    <div id="reg_btn" onClick={eventAct}>Создать аккаунт</div>
                    <div id="log_btn">Войти</div>
                </div>
            </div>
        </div>
    </div>
    )

  
}

//labElement.defaultProps = {items : {123}}