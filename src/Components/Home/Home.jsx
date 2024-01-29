import React,{useEffect} from 'react'
import './Home.css'


//Imported Assets
import Video from '../../Assets/mountains_-_57482 (1080p).mp4'
import Aos from 'aos'
import 'aos/dist/aos.css'
//Import icon
import {AiOutlineSwapRight} from 'react-icons/ai'
const Home=()=>{

    useEffect(()=>{
        Aos.init({duration:2000})
    },[])
    return <div className="Home">
        <div className="videoBg">
        <video src={Video} autoPlay loop muted></video>
    </div>
    <div className="sectionText">
    <h1 data-aos='fade-up'>Unlock Your Tarevl Dream with Us</h1>
    <p data-aos='fade-up'>
        Discover the Romanian's most beautiful view, life is so short
        for a trip.
    </p>
    <button className="btn flex" data-aos='fade-up'>
        GET STARTED<AiOutlineSwapRight className
    ='icon'/></button>
    </div>

    <div className="popularPlaces">
        <div className="content">
            <h3 data-aos='fade-up'>Popular Places</h3>
            <div className="images flex" data-aos='fade-up'>
                <img src="" alt="" />
                <img src="" alt="" />
                <img src="" alt="" />
                <img src="" alt="" />

            </div>
        </div>
    </div>

    </div>
};

export default Home;
