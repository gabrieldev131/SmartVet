import { useState } from 'react'
import './App.css'
import { BrowserRouter as Router, Routes, Route, Link } from "react-router-dom";
import Usuarios from "../pages/Usuarios";
import Animais from "../pages/Animais";

export default function App() {
  return (
    <Router>
      <nav>
        <Link to="/usuarios">Usuários</Link>
        <Link to="/animais">Pets</Link>
      </nav>
      <Routes>
        <Route path="/usuarios" element={<Usuarios />} />
        <Route path="/animais" element={<Animais />} /> 
      </Routes>
    </Router>
  );
}S