import React from 'react'

import './Menu.css';
import './LabElement.css';

export default function LabElement({name, url, ...props}) {

  return ( 
    <div className="labElement">
      {
        <a className="docUrl" href={url}>{name}</a>
      }
    </div>)
  
}

//labElement.defaultProps = {items : {123}}