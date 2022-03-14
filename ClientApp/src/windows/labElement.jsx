import React from 'react'

import './Menu.css';

export default function labElement({name, url, ...props}) {
  return (
    <div className="labElement">
          {
              <a className="docUrl" href={url}>{name}</a>
          }
    </div>
  )
}

//labElement.defaultProps = {items : {123}}