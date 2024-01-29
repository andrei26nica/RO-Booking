import React ,{useEffect }from 'react'
import './Subscribe.css'
import image from '../../Assets/image.jpg'
import Aos from 'aos'
import 'aos/dist/aos.css'

const Subscribe=()=>{
    useEffect(()=>{
        Aos.init({duration:2000})
    },[])
    return <div className='subscribe section container'>
        <div className="secContainer grid" data-aos='fade-up'>
            <img src={image} alt="Div Image" />

            <div className="textDiv">
                <h4 data-aos='fade-up'>Best Way To Start Your Journey</h4>
                <p data-aos='fade-up'>
                    We offer personalized itineraries tailored to
                    individual preferences and interests.
                </p>
                <button data-aos='fade-up' className='btn'>Start Here </button>
            </div>
        </div>
    </div>
};

export default Subscribe;
