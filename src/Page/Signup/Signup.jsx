import React from 'react'
import "./Signup.css"
import Video from './Pexels Videos 1542008.mp4';
import { Link } from 'react-router-dom';
import { FormInput } from '../../Components/FormInput/FormInput';
import { useState } from 'react';
  

export const Signup = () => {
  const [values, setValues] = useState({
    email:"",
    firstname:"",
    lastname:"",
    password:"",
    confirmpassword:"",
  });

  const inputs = [
    {
      id:1,
      name:"email",
      type: "email",
      placeholder:'Enter your email',
      label:"Email",
      errorMessage:"It should be a valid email address",
      required: true
    },
    {
    
      id:2,
      name:"firstname",
      type: "firstname",
      placeholder:'Enter your first name',
      label:"First Name",
      errorMessage:"It shouldn't inlcude any special character",
      pattern: "^[A-Za-z]{8-20}$",
      required: true
    },
    {
      
      id:3,
      name:"lastname",
      type: "lastname",
      placeholder:'Enter your last name',
      label:"Last Name",
      errorMessage:"It shouldn't inlcude any special character",
      pattern: "^[A-Za-z]{8-20}$",
      required: true
    },
    {
      id:4,
      name:"password",
      type: "password",
      placeholder:'Enter your password',
      label:"Password",
      errorMessage:"Password should be 8-20 characters",
      required: true,
      pattern: '^[A-Za-z0-9!@#$%^&*]{8,20}$'
    },
    {
      id:5,
      name:"confirmpassword",
      type: "password",
      placeholder:'Confirm your password',
      label:"Confirm Password",
      errorMessage:"Password don't match",
      required: true,
      pattern: values.password
    },
  ]

  console.log("re-rendered")

  const handleSubmit = (e)=>{
    e.preventDefault();
  };

  const onChange = (e)=>{
    setValues({...values, [e.target.name]: e.target.value})
  };

  console.log(values)
  return (
    <div className="SignupContainer">
      <div className="Overlay"></div>      
      <video src={Video} autoPlay loop muted />
      <div className="SignupForm">
        <h1 className="SignupTitle">Sign Up</h1>
        <div className="SignupItem">
        {inputs.map((input) => (
            <FormInput key={input.id}  {...input} value={values[input.name]} onChange={onChange}/>
        ))}
          {/* <label className='SignupInputTitle'>Email</label>
          <FormInput className='Input' type="email" placeholder='Enter your email' />
          <div className="NameInputItem">
            <div className="SignupNameItem">
              <label className='SignupInputTitle'>First Name</label>
              <FormInput className='Input' type="text" placeholder='Enter your first name' />
            </div>
            <div className="SignupNameItem">
              <label className='SignupInputTitle'>Last Name</label>
              <FormInput className='Input' type="text" placeholder='Enter your last name' />
            </div>
          </div>
          <label className='SignupInputTitle'>Password</label>
          <FormInput className='Input' type="password" placeholder='Enter your password' />
          <label className='SignupInputTitle'>Confirm Password</label>
          <FormInput className='Input' type="password" placeholder='Confirm your password' /> */}
          <button className='SignupButton'>Create account</button>
          <small>Already have account <Link to="/login">Login</Link></small>
        </div>
      </div>
    </div>
  )
}
