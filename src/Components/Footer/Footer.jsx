import React ,{useEffect }from 'react'
import './Footer.css'
import {BiLogoMediumOld} from 'react-icons/bi'
import {ImFacebook} from 'react-icons/im'
import {RiTwitterXFill} from 'react-icons/ri'
import {AiFillInstagram} from 'react-icons/ai'
import Aos from 'aos'
import 'aos/dist/aos.css'

const Footer=()=>{
    useEffect(()=>{
        Aos.init({duration:2000})
    },[])
    return <div className='footer'>
        <div className="secContainer container grid">
            <div className="logoDiv">
                <div className="footerLogo" data-aos='fade-up'>
                <BiLogoMediumOld className='icon'/>
                <span data-aos='fade-up'>OU-Trips</span>
                </div>
                <div className="socials flex" data-aos='fade-up'>
                <ImFacebook data-aos='fade-up' className='icon'/>
                <RiTwitterXFill  data-aos='fade-up'className='icon'/>
                <AiFillInstagram  data-aos='fade-up'className='icon'/>
                </div>
                </div>
                

                <div data-aos='fade-up' className="footerLinks">
                    <span className="linkTitle" >
                        Information
                    </span>
                    <li >
                        <a href="#">Home</a>
                    </li>
                    <li >
                        <a href="#">Explore</a>
                    </li>
                    <li >
                        <a href="#">Travel</a>
                    </li>
                    <li>
                        <a href="#">Blog</a>
                    </li>
                </div>

                <div data-aos='fade-up' className="footerLinks">
                    <span className="linkTitle">
                        Helpful Links
                    </span>
                    <li>
                        <a href="#">Destination</a>
                    </li>
                    <li >
                        <a href="#">Support</a>
                    </li>
                    <li >
                        <a href="#">Travel & Conditions</a>
                    </li>
                    <li > 
                        <a href="#">Privacy</a>
                    </li>
                </div>

                <div data-aos='fade-up'className="footerLinks">
                    <span  className="linkTitle">Contact Details </span>
                    <span  className="phone">0744 103 199</span>
                    <span  className="email">nicaandrei20@stud.ase.ro</span>

                    
                </div>
                
            </div>
        
    </div>
};

export default Footer;
