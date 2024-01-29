import React ,{useEffect}from 'react'
import './Portifolio.css'
import icon1 from '../../Assets/Icon-safety.png'
import icon2 from '../../Assets/icon-various.jpg'
import icon3 from '../../Assets/icon-customer.png'
import icon4 from '../../Assets/image-sun.jpg'
import Aos from 'aos'
import 'aos/dist/aos.css'

const Portifolio=()=>{
    useEffect(()=>{
        Aos.init({duration:2000})
    },[])
    return <div className="portifolio section container">
        <div className="secContainer grid">
            <div className="leftContent">
                <div className="secHeading">
                    <h3 data-aos='fade-up'>Why Should You Choose Us</h3>
                    <p data-aos='fade-up'> 
                        We have extensive knowledge and experience
                        in the travel industry.
                    </p>
                </div>
                    
                <div className="grid">
                    <div className="singlePortifolio flex" data-aos='fade-up'>
                        <div className="iconDiv">

                            <img src={icon1} alt="Icon image"/>
                        </div>

                        <div className="infor" data-aos='fade-up'>
                            <h4 data-aos='fade-up'>Safety and support</h4>
                            <p data-aos='fade-up'>
                                Our top priority is the safety and
                                well-being of our clients.
                                We mantain high safety standards and
                                have emergency support
                                available during the trip.
                            </p>
                        </div>
                    </div>


                    <div className="singlePortifolio flex" data-aos='fade-up'>
                        <div className="iconDiv">

                            <img src={icon2} alt="Icon image"/>
                        </div>

                        <div className="infor">
                            <h4>Diverse Range of Destinations</h4>
                            <p>
                                Whether it's a chill tour or an
                                party trip, we cover a wide range of
                                destinations to cater to different.
                            </p>
                        </div>
                    </div>
                    <div className="singlePortifolio flex" data-aos='fade-up'>
                        <div className="iconDiv">

                            <img src={icon3} alt="Icon image"/>
                        </div>

                        <div className="infor">
                            <h4>Customer Support</h4>
                            <p>
                                Our dedicated customer support team is
                                available round the
                                clock to address any queries or
                                concerns before, during, and
                                after the trip.
                            </p>
                        </div>
                    </div>
                </div>
            </div>

            <div className="rightContent" data-aos='fade-up'>
                <img src={icon4} alt="Image" />
            </div>
        </div>
    </div>
};

export default Portifolio;
