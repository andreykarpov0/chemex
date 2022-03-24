import React from 'react'


import './LabElement.css';

export default function DocElement({name, dateEdit, id, ...props}) {

  const eventAct = () => {
    window.location.href = "/Document?id=" + id.toString();
  }

  return ( 
        <div className="DocElementCont" onClick={eventAct}>
          <div className="DocElementName" href={url}>{name}</div>
          <div className="DocElementEditDate">{dateEdit}</div>
        </div>
  )
}

//labElement.defaultProps = {items : {123}}