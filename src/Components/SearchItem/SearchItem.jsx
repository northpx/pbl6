import React from 'react'
import "./SearchItem.css"
import { useNavigate } from 'react-router-dom';

export const SearchItem = () => {
  const navigate = useNavigate()
  const handleDetail = () =>{
    navigate ("/room/:id")
  };

  return (
    <div className="SearchItem">
        <img src="https://cache.marriott.com/content/dam/marriott-renditions/MSPOS/mspos-guest-room-0328-hor-wide.jpg?output-quality=70&interpolation=progressive-bilinear&downsize=1336px:*" 
        alt="" className="siImg" />
        <div className="siDescription">
            <h1 className="siTitle">#P102 | Babylon Room</h1>
            <span className="siOptions">1 Adult</span>
            <span className="siOptions">0 Children</span>
        </div>
        <div className="siDetails">
            <div className="siPrice">3,032 <small>triệu/VND</small></div>
            <div className="siTax">Includes taxes and fees</div>
            <button className="siCheckButton" onClick={handleDetail}>Detail</button>
        </div>
    </div>
  )
}
