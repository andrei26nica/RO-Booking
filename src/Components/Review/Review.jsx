import React ,{useEffect}from 'react'
import './Review.css'
import {AiFillStar} from 'react-icons/ai'
import user1 from '../../Assets/user1.jpg'
import user2 from '../../Assets/user2.jpg'
import user3 from '../../Assets/user3.jpg'
import user4 from '../../Assets/user4.jpg'
import img5 from '../../Assets/rapita.jpg'
import Aos from 'aos'
import 'aos/dist/aos.css'

const Review=()=>{
    useEffect(()=>{
        Aos.init({duration:2000})
    },[])
    return <div className="review section container">
        <div className="secContainer grid">
            <div className="textDiv">
                <span className="redText" data-aos='fade-up'>
                    FROM OUR CLIENTS
                </span>
                <h3 data-aos='fade-up'>
                    Real Travel History From Our Beloved
                    Clients
                </h3>
                <p data-aos='fade-up'>
                    By choosing us as their tour agency,
                    customers can expect an
                    enriching and enjoyable travel experience,
                    filled with unforgettable
                    memories that will last a lifetime.
                </p>

                <span className="stars flex" data-aos='fade-up'>
                <AiFillStar className='icon'/>
                <AiFillStar className='icon'/>
                <AiFillStar className='icon'/>
                <AiFillStar className='icon'/>
                <AiFillStar className='icon'/>

                </span>

                <div className="clientsImages flex" data-aos='fade-up'>
                    <img src={user1} alt="Client Image" />
                    <img src={user2} alt="Client Image" />
                    <img src={user3} alt="Client Image" />
                    <img src={user4} alt="Client Image" />

                </div>
            </div>
            <div className="imgDiv" data-aos='fade-up'>
                <img src={img5} alt="Div image" />
            </div>
        </div>

    </div>
};

export default Review;
