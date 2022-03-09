import React from 'react'

import './Menu.css';

export default function Home({items, ...props}) {
  return (
    
    <div className="menu">
          {
          items.map((el) => 
            <a className="menuUrl" href={el.url}>{el.name}</a>
          )}
    </div>
  )
}

//Home.defaultProps = {items : {123}}