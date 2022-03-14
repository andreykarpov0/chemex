import React from 'react'

import LabElement from './labElement';

import './Home.css';

export default function Home() {
  const testList = [{url:"1", name:"one"}]
  return (
    <div>
        {testList.map((el) => {
            <LabElement name={el.name} url={el.url}/>
        })}
    </div>
  )
}
