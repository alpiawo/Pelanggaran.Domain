import React from 'react';
import { BrowserRouter as Router, Routes, Route } from "react-router-dom"; 
import Home from './pages';
import JurusanHome from './pages/Jurusan';
import { Navbar } from './components/Navbar';

function App() {
  return (
    <div className="App flex">
      <Router>
        <Navbar />
        <div className="w-full p-4 ml-0 sm:ml-64">
          <Routes>
            <Route path="/" exact element={<Home />} />
            <Route path="/jurusan" element={<JurusanHome />} />
          </Routes>
        </div>
      </Router>
    </div>
  );
}

export default App;
