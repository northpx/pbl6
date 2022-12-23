import {
    BrowserRouter as Router,
    Routes,
    Route,  
  } from "react-router-dom";
  import { Home } from "../Page/Home/Home";
  import { List } from "../Page/List/List";
  import { Login } from "../Page/Login/Login";
  import { Room } from "../Page/Room/Room";
  import {Signup} from "../Page/Signup/Signup";
  import React from "react";
  
const Routers=() => {
    return (
    
          <Routes>
            <Route path="/" element={<Home/>}/>
            <Route path="/room" element={<List/>}/>
            <Route path="/room/:id" element={<Room/>}/>
            <Route path="/login" element={<Login/>}/>
            <Route path="/signup" element={<Signup/>}/>
          </Routes>

    );
  }
  
  export default Routers;