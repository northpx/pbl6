import "./Header.css"
import { Navbar } from "../../Components/Navbar/Navbar"
import { BsArrowDown } from 'react-icons/bs';
import { BsCalendarRange } from 'react-icons/bs';
import { BsPerson } from 'react-icons/bs';
import Video from './Pexels Videos 2732784.mp4';
import 'react-date-range/dist/styles.css'; // main css file
import 'react-date-range/dist/theme/default.css'; // theme css file
import { DateRange } from "react-date-range";
import {useState} from 'react'
import  {format} from "date-fns"
import { useNavigate } from "react-router-dom";

export const Header = ({type}) => {
  const [openDate, setOpenDate] = useState(false)
  const [date, setDate] = useState([
     {
       startDate: new Date(),
       endDate: new Date(),
       key: 'selection'
     }
   ]);
   const [openOptions, setOpenOptions] = useState(false)
   const [Options, setOptions] = useState({
    adult:1,
    children:0,
    room:1,
   });

   const navigate = useNavigate()

   const handleOption = (name, operation) =>{
    setOptions((prev) => {
      return {
      ...prev, 
      [name]: operation === "i" ? Options[name] + 1 : Options[name] - 1,
    };
  });
   };

   const handleSearch = () =>{
      navigate("/room", {state:{date, Options}});
   }
  return (
    <div className="Header">
      <Navbar/>
        <div className="Overlay"></div>      
      <video src={Video} autoPlay loop muted />
      <div className="HeaderContainer">
        <h1 className="Title">A quiet symphony of sensory pleasures to rejuvenate you</h1>
        <button className="HeaderButton"> Discover more <BsArrowDown /> </button>
        <div className="HeaderSearch">
           <div className="HeaderItem">
            <BsCalendarRange />
            <span onClick={()=>setOpenDate(!openDate)} className="HeaderSearchText">
              {`${format(date[0].startDate, "MM/dd/yyyy")} to ${format(date[0].endDate, "MM/dd/yyy")}` }
  </span>
            {openDate && <DateRange
              editableDateInputs={true}
              onChange={item => setDate([item.selection])}
              moveRangeOnFirstSelection={false}
              ranges={date}
              className="Date"
              minDate={new Date()}
            /> }
           </div>
           <div className="HeaderItem">
            <BsPerson />
            <span onClick={()=>setOpenOptions(!openOptions)} className="HeaderSearchText">
              {`${Options.adult} adult . ${Options.children} children . ${Options.room} room`}
            </span>
           {openOptions && <div className="Options">
            <div className="OptionItem">
              <span className="OptionText">Adult</span>
              <div className="OptionCounter">
                <button 
                disabled={Options.adult <= 1}
                className="OptionCounterButton" onClick={()=>handleOption("adult", "d")}>-</button>
                <span className="OptionCounterNumber">{Options.adult}</span>
                <button className="OptionCounterButton" onClick={()=>handleOption("adult", "i")}>+</button>
              </div>
            </div>
            <div className="OptionItem">
              <span className="OptionText">Children</span>
              <div className="OptionCounter">
                <button 
                disabled={Options.children <= 0}
                className="OptionCounterButton" onClick={()=>handleOption("children", "d")}>-</button>
                <span className="OptionCounterNumber">{Options.children}</span>
                <button className="OptionCounterButton" onClick={()=>handleOption("children", "i")}>+</button>
              </div>
            </div>
            <div className="OptionItem">
              <span className="OptionText">Room</span>
              <div className="OptionCounter">
                <button 
                disabled={Options.room <= 1}
                className="OptionCounterButton" onClick={()=>handleOption("room", "d")}>-</button>
                <span className="OptionCounterNumber">{Options.room}</span>
                <button className="OptionCounterButton" onClick={()=>handleOption("room", "i")}>+</button>
              </div>
            </div>
            </div>}
           </div>
           <div className="HeaderItem">
            <button className="HeaderButton" onClick={handleSearch}> Check Available <BsArrowDown /> </button>
           </div>
         </div>
      </div>
    </div>
  );
};
