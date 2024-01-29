import React from 'react'
//import './Navbar.scss'
import './App.css'
import Destinations from './Components/Destinations/Destinations'
import Home from './Components/Home/Home'
import Middle from './Components/Middle/Middle'
import Navbar from './Components/Navbar/Navbar'
import Portifolio from './Components/Portifolio/Portifolio'
import Questions from './Components/Questions/Questions'
import Review from './Components/Review/Review'
import Subscribe from './Components/Subscribe/Subscribe'
import Footer from './Components/Footer/Footer'
 
function App() {

  return (
    <div>
      <Navbar/>
      <Home/>
      <Middle/>
      <Destinations/>
      <Portifolio/>
      <Review/>
      <Questions/>
      <Subscribe/>
      <Footer/>
    </div>
  )
}

export default App
