import React ,{useEffect}from 'react'
import './Destinations.css'
import {MdLocationPin} from 'react-icons/md'
import {BsFillCreditCardFill} from 'react-icons/bs'
import {BsFillCalendarDateFill} from 'react-icons/bs'
import {BiSearchAlt} from 'react-icons/bi'
import {TiLocation} from 'react-icons/ti'
import Aos from 'aos'
import 'aos/dist/aos.css'


import Img1 from '../../Assets/Img1.jpg'
import Img02 from '../../Assets/Img02.jpg'
import Img03 from '../../Assets/Img03.jpg'
import Img04 from '../../Assets/Img04.jpg'
import Img05 from '../../Assets/Img05.jpg'
import Img06 from '../../Assets/Img06.jpg'
import Img07 from '../../Assets/Img07.jpg'
import Img08 from '../../Assets/Img08.jpg'
 


const destinations=[
    {
        id: 1,
        img: Img1,
        name: 'Cazanele Dunarii',
        location: 'Caras-Severin',
        rating: 4.7,
    },
    {
        id: 2,
        img: Img02,
        name: 'UNTOLD Cluj-Napoca',
        location: 'Cluj',
        rating: 4.4,
    },
    {
        id: 3,
        img: Img03,
        name: 'Masivul Bucegi',
        location: 'Busteni, Prahova',
        rating: 4.7,
    },
    {
        id: 4,
        img: Img04,
        name: 'Vama Veche',
        location: 'Constanta',
        rating: 4.7,
    },
    {
        id: 5,
        img: Img05,
        name: 'Delta Dunarii',
        location: 'Tulcea',
        rating: 4.7,
    },
    {
        id: 6,
        img: Img06,
        name: 'Bucuresti',
        location: 'Bucuresti',
        rating: 4.7,
    },
    {
        id: 7,
        img: Img07,
        name: 'Maramures',
        location: 'Maramures',
        rating: 4.7,
    },
    {
        id: 8,
        img: Img08,
        name: 'Rosia Montana',
        location: 'Alba',
        rating: 4.7,
    }
]
const Destinations=()=>{
    useEffect(()=>{
        Aos.init({duration:2000})
    },[])
    return <div className='destination section container
    '>
    <div className="secContianer">

        <div className="secTitle">
            <span className ="redText" data-aos='fade-up'>
                EXPLORE NOW
            </span>
            <h3 data-aos='fade-up'>Find Your Dream Destination</h3>
            <p data-aos='fade-up'>
                Fill in the fields below to find the best 
                spot for your next tour.
            </p>
        </div>

        <div className="searchField grid">
            <div className="inputField flex" data-aos='fade-up'>
            <MdLocationPin className='icon'/>
            <input type="text" placeholder='Location'/>    
            </div>

            <div className="inputField flex" data-aos='fade-up'>
            <BsFillCreditCardFill className='icon'/>
            <input type="text" placeholder='Budget'/>    
            </div>

            <div className="inputField flex" data-aos='fade-up'>
            <BsFillCalendarDateFill className='icon'/>
            <input type="text" placeholder='Date'/>    
            </div>

            <button className='btn flex' data-aos='fade-up'>
            <BiSearchAlt className='icon'/>
            Search
            </button>
        </div>

        <div className="secMenu">
            <ul className="flex" data-aos='fade-up'>
                <li className="active">All</li>
                <li>Recomnded</li>
                <li>Beach</li>
                <li>Park</li>
                <li>Nature</li>
                <li>Mountain</li>

            </ul>
        </div>

        <div className="destinationContainer grid">
            {destinations.map(destination=>{
                return (
                    <div className="singleDestination" key={destination.id} data-aos='fade-up'>
                <div className="imgDiv" data-aos='fade-up'>
                    <img src={destination.img} alt="Destination Image" />
                    <div className="descInfo flex">
                        <div className="text">
                            <span className="name">{destination.name}</span>
                            <p className='flex'><TiLocation className='icon'/>
                            {destination.location}
                            </p>
                        </ div>
                            <span className="rating">
                                {destination.rating}
                            </span>
                    </div>
                </div>


            </div>
                )
            })}
            

        </div>
        
        
    </div>
    </div>
};

export default Destinations;
