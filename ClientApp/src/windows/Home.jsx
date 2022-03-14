import React from 'react'

import './Home.css';
import LabElement from './LabElement';

export default function Home() {
  const testList = [{url:"/1", name:"one"}]
  return (
    <div>
        {
        testList.map((el) => <LabElement name={el.name} url={el.name}/>)
        }
    </div>
  )
}
