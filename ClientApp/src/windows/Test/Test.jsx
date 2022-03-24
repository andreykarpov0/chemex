import React, { useEffect, useState } from 'react'

import './Test.css';

export default function Test() {

    const [ListData,setListData] = useState([])

    useEffect(() => {
        fetch("/gtlist")
        .then(res => res.json())
        .then(
            (result) => {
                console.log(result);
                setListData(result.response);
            }
        )
    },[])

    if(ListData.length > 0){
        return (
            <div>
                {
                    ListData.map((elem) => <div>{elem}</div>)
                }
            </div>
        )
    } else {
        return (
        <div>Загрузка данных..</div>
        )
    }
}
