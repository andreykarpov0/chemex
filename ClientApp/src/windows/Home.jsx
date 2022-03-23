import React, { useEffect, useState } from 'react'

import './Home.css';
import LabElement from '../Components/LabElement';
import Menu from '../Components/Menu';
import GetMenuItems from '../Components/GetMenuItems';

export default function Home() {
  const testList = [{url:"/1", name:"one"}]

  const [LabeElements,setLabeElements] = useState([])

  useEffect(() => {
    fetch("//projectList")
    .then(res => res.json())
    .then(
        (result) => {
            console.log(result);
            setLabeElements(result.response);
        }
    )
  },[])

  return (
    <div>
      <Menu items={GetMenuItems()}/>
      {
        LabeElements.map((el) => <LabElement name={el.name} url={el.name}/>)
      }
    </div>
  )
}
