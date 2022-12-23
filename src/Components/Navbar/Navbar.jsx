import "./Navbar.css"
import * as React from "react";
import { useNavigate } from "react-router-dom";
import { Link } from 'react-router-dom';
import { Login } from "../../Page/Login/Login";
import { Route } from "react-router-dom";

export const Navbar = () => {
  const [date, setDate] = React.useState([
    {
      startDate: new Date(),
      endDate: new Date(),
      key: 'selection'
    }
  ]);
  const [Options, setOptions] = React.useState({
    adult:1,
    children:0,
    room:1,
   });
  const handleHome = () =>{
    navigate("/");
 }
 const navigate = useNavigate()
 const handleRoom = () =>{
  navigate("/room",{state:{date,Options}});
}
const handleLogin = () =>{
  navigate("/login")
}
const handleSignup = () =>{
  navigate("/signup")
}

  return (
    <div className="NavBar"> 
        <div className="NavContainer">
          <div className="NavList">
            <div className="NavPage">
              <span onClick={handleHome}>Home</span>
            </div>
            <div className="NavPage">
              <span onClick={handleRoom}>Room</span>
            </div>
          </div>
          <span className="Logo">
            <img src="https://www.namanretreat.com/static/images/logoNaman.png" alt="Naman" onClick={handleHome}/>
          </span>
          <div className="NavCTA">
            <button className="NavButton" onClick={handleSignup}>Sing Up</button>
            <button className="NavButton" onClick={handleLogin}>Login</button>
          </div>
        </div>

    </div>
  )
}
