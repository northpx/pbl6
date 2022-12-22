import React, { useState } from 'react'
import { Navbar } from '../../Components/Navbar/Navbar'
import { Header } from '../../Components/Header/Header'
import "./List.css"
import { useLocation } from 'react-router-dom'
import  {format} from "date-fns"
import { DateRange } from 'react-date-range'
import { SearchItem } from '../../Components/SearchItem/SearchItem'

export const List = () => {

  const location = useLocation();
  const [date, setDate] = useState(location.state.date)
  const [openDate, setOpendate] = useState(false)

  const [Options, setOptions] = useState(location.state.Options)
  
  return (
    <div>
      <Navbar/>
      <div className="ListContainer">
        <div className="ListWrapper">
          <div className="ListSearch">
            <h1 className="ListTile">Search</h1>
            <div className="ListItem">
              <label>Check-in Date</label>
              {<span onClick={()=>setOpendate(!openDate)}>{`${format(date[0].startDate, "MM/dd/yyyy")} to ${format(date[0].endDate, "MM/dd/yyy")}` }</span>}
              {openDate && (<DateRange onChange={(item)=> setDate([item.selection])} minDate={new Date()} ranges={date}/>)}
            </div>
            <div className="ListItem">
              <label>Options</label>
              <div className="ListOption">
                <div className="ListOptionItem">
                  <span className="ListOptionText">
                    Adult
                  </span>
                  <input type="number" min = {1} className="ListOptionInput" placeholder={Options.adult}/>
                </div>
                <div className="ListOptionItem">
                  <span className="ListOptionText">
                    Children
                  </span>
                  <input type="number" min = {0} className="ListOptionInput" placeholder={Options.children}/>
                </div>
                <div className="ListOptionItem">
                  <span className="ListOptionText">
                    Room
                  </span>
                  <input type="number" min = {1} className="ListOptionInput" placeholder={Options.room}/>
                </div>
              </div>
            </div>
            <button>Search</button>
          </div>
          <div className="ListResults">
            <SearchItem/>
            <SearchItem/>
            <SearchItem/>
            <SearchItem/>
            <SearchItem/>
            <SearchItem/>
            <SearchItem/>
          </div>
        </div>
      </div>
    </div>
  )
}
