import React from 'react'

import './Menu.css';
import LabElement from './LabElement';

export default function Menu({items, ...props}) {
  return (
    <div>
        {
        items.map((el) => <a className="menuUrl" href={el.url}>{el.name}</a>)
        }
    </div>
  )
}
