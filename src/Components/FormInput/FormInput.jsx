import React from 'react'
import "./FormInput.css"
import { useState } from 'react';

export const FormInput = (props) => {
  const [focused, setFocused] =useState(false);
  const {label, errorMessage, onChange, id, ...inputProps} = props
  const handleFocus= (e) => {
    setFocused(true);
  };
  return (
    <div className='FormInput'>
        <label >{label}</label>
        <input className='InputField'{...inputProps} onChange={onChange} 
        onBlur={handleFocus} 
        onFocus={()=>inputProps.name==="confirmpassword" && setFocused(true)} 
        focused={focused.toString()}/>
        <span className='ErrorMessage'>{errorMessage}</span>
    </div>
  )
}
