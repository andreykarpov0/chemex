import React from 'react'

import './Home.css';
import LabElement from '../Components/LabElement';
import Menu from '../Components/Menu';
import GetMenuItems from '../Components/GetMenuItems';

export default function Home() {
  const testList = [{url:"/1", name:"one"}]

  return (
    <div>
      <Menu items={GetMenuItems()}/>
      {
      testList.map((el) => <LabElement name={el.name} url={el.name}/>)
      }
    </div>
  )
}
