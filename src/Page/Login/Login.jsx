import React, { useState } from 'react'
import Video from './Pexels Videos 1542008.mp4';
import { Link } from 'react-router-dom';
import "./Login.css"
import { FormInput } from '../../Components/FormInput/FormInput';

export const Login = () => {
  const [values, setValues] = useState({
    email:"",
    password:"",
  });

  const inputs = [
    {
      id:1,
      name:"email",
      type: "email",
      placeholder:'Enter your email',
      errorMessage:"It should be a valid email address",
      label:"Email",
      required: true
    },
    {
      id:2,
      name:"password",
      type: "password",
      placeholder:'Enter your password',
      errorMessage:"Incorrect password",
      label:"Password",
      required: true
    }
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
    <div className="LoginContainer">
      <div className="Overlay"></div>      
      <video src={Video} autoPlay loop muted />
      <div className="LoginForm">
        <h1 className="LoginTitle">Login</h1>
        <div className="LoginItem" onSubmit={handleSubmit}>
          {/* <label className='LoginInputTitle'>Email</label> */}
          {inputs.map((input) => (
            <FormInput key={input.id}  {...input} value={values[input.name]} onChange={onChange}/>
          ))}
          {/* <FormInput name="email" className='Input' type="email" placeholder='Enter your email'/>
          <label className='LoginInputTitle'>Password</label>
          <FormInput name="password" className='Input' type="password" placeholder='Enter your password' /> */}
          <label><input type="checkbox"/>Remember me</label>
          <button className='LoginButton'>Log in</button>
          <small>Don't have account yet? <Link to="/signup">Sign up</Link></small>
          <small><Link to="/">Forget password</Link></small>
        </div>
        
      </div>
    </div>
  )
}
