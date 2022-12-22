import React from 'react'
import "./Room.css"
import { Navbar } from "../../Components/Navbar/Navbar";
import axios from 'axios';
import { Component } from 'react';

const baseApi = "https://636388b337f2167d6f7bdf13.mockapi.io/hotel/hotel"

export const Room = () => {
  const Photos = [
    {
      src:"https://static01.nyt.com/images/2019/03/24/travel/24trending-shophotels1/24trending-shophotels1-superJumbo.jpg"
    },
  ]
  
    return (
      <div>
        <Navbar/>
        <div className="RoomContainer">
          <div className="RoomWrapper">
            <h1 className="RoomTitle">Babylon Room</h1> 
            <div className="RoomImages">
              {Photos.map(photo=>(
                <div className="RoomImageWrapper">
                  { <img src={photo.src} alt="" className="RoomImg" /> }
                </div>
              ))}
            </div>
            <div className="RoomDetails">
              <div className="RoomDetailsTexts">
                <h2 className="RoomTitle">Enjoy your trip</h2>
                <p className="RoomDesc">
                Minimalistic, modern and sophisticated, Babylon rooms meet the most essential needs for a complete vacation for families or couples. Covered by the green color from the hanging tree garden to the clear water of the outdoor swimming pool, you will completely immerse yourself in a calm, peaceful space, leaving behind all the pressure from the daily life.
                </p>
              </div>
              <div className="RoomDetailsPrice">
                <h2>Perfect for a 6-night stay!</h2>
                <span>
                  Had the view of infinitive pool 
                </span>
                <h3>
                  <b>3,032</b><small> triệu/VNĐ</small> (1 night)
                </h3>
                <button className="BookNow">Book now!</button>
              </div>
            </div>
          </div>
        </div>
      </div>
    )
 
}
