import React, { useState,useEffect } from 'react'
import './Questions.css'
import Accordion from './Accordion';
import Aos from 'aos'
import 'aos/dist/aos.css'

const Questions=()=>{
    useEffect(()=>{
        Aos.init({duration:2000})
    },[])
    const[active, setActive]=useState('How do I choose the right travel destination for me?')
    return <div className="questions section container">
        <div className="secHeading">
            <h3 data-aos='fade-up'>Frequently Asked Questions</h3>
        </div>
        <div className="secContainer grid" data-aos='fade-up'>
            <div className="accordion grid" >
            <Accordion 
            data-aos='fade-up' title="How do I choose the right travel destination for me?"
            desc="Consider your interests, budget, desired,
            experiences, and the type of
            enviroment you enjoy. Reasearch destinations that
            align with your
            preferences and offer attractions or activities
            you find appealing."
             active={active} setActive={setActive}/>
            

            <Accordion title="What are the best times to visit specific destinations?"
            desc="Research weather patterns and peak tourist seasons of the
            destination you're interested in. Opt for the shoulder seasons when
            the weather is pleasent, and crowds are fewer, if possible."
             active={active} setActive={setActive}/>

<Accordion title="How can I find budget-friendly travel option and deals?"
            desc="Consider using travel apps or websites that offer
            competitive prices. Being flexible with your travel dates
            can also help you find better deals."
             active={active} setActive={setActive}/>

<Accordion title="What essential items should I pack for my adventure?"
            desc="Pack appropriate clothing, toiletries, travel documents,
            essential medications and any specific gear needed for
            your adventure."
             active={active} setActive={setActive}/>
            
            </div>

            <div className="form">
            <div className="secHeading">
            <h4 data-aos='fade-up'>Do you have any specific question?</h4>
            <p data-aos='fade-up'>
                Please fill the form below and our
                dedicated team will get intouch
                whtih you as soon as possible.
            </p>
        </div>

        <div className="formContent grid">
            <input data-aos='fade-up'type="email" placeholder='Enter email address' />
            <textarea data-aos='fade-up'placeholder='Enter your question here'></textarea>
            <button data-aos='fade-up'className='btn'>Submit Inquiry</button>
        </div>
            </div>
        </div>
    </div>
};

export default Questions;
