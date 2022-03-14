import React from 'react'

import labEl from './labElement';

import './Home.css';

export default function Home() {
  const testList = [{url:"1", name:"one"}]
  return (
    <div>
        {testList.map((el) => {
            <labEl name={el.name} url={el.url}/>
        })}
    </div>
  )
}
