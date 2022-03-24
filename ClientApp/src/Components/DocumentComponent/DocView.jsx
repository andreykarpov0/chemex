import React from 'react'

import DocElement from 'DocElement'

export default function DocView({List, ...props}) {
  return (
    <div>
        {
          List.map((el) => <DocElement name={el.name} dateEdit={el.dateEdit} id={el.id} key={el.key.toString()}/>)
        }
    </div>
  )
}
