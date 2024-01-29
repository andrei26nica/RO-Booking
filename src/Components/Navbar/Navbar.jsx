import React, { useState } from 'react'
import './Navbar.css'
//import Navbar from './Components/Navbar/Navbar'
//Imported Icons
import {BiLogoMediumOld} from 'react-icons/bi'
import {AiFillCloseCircle} from 'react-icons/ai'
import {PiDotsNineBold} from 'react-icons/pi'

const Navbar=()=>{

    const [navBar,setNavBar]=useState('menu');
    //function to show navbar
    const showNavBar= ()=>{
        setNavBar("menu showNavBar");
    };

    //function to remove navBar
    const removeNavBar= ()=>{
        setNavBar("menu");
    };
    return <div className="navBar">
        <div className="logoDiv">
        <BiLogoMediumOld className='icon'/>
        <span>OU-trips</span>
        </div>
        
        <div className={navBar}>
            <ul>
                <li className="navList">
                    Destination
                </li>
                <li className="navList">
                    About Us
                </li>
                <li className="navList">
                    Testimonial
                </li>
                <li className="navList">
                    Gallery
                </li>
                
            </ul>
            {/*Icon to remove Navbar*/}
            <AiFillCloseCircle className='icon' onClick={removeNavBar}/>
        </div>
        <button className="btn">Sign Up</button>
        {/*Icon to toggle Navbar*/}
        <PiDotsNineBold className='icon' onClick={showNavBar}/>

    </div>
};

export default Navbar;
