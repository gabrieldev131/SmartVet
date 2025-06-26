<<<<<<< Updated upstream
// src/App.jsx

import { BrowserRouter as Router, Routes, Route, Link } from 'react-router-dom';
import Atendimento from '../pages/Atendimento';
import Usuarios from '../pages/Usuarios';
import Animais from '../pages/Animais';
// Você pode criar um componente de Navegação/Layout para não repetir o menu
// import Navbar from './components/Navbar';
=======
import React from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import LoginPage from './pages/LoginPage';
>>>>>>> Stashed changes

function App() {
  return (
    <Router>
<<<<<<< Updated upstream
      {/* <Navbar /> */}
      {/* Exemplo de menu simples: */}
      <nav style={{padding: '1rem', backgroundColor: '#eee'}}>
        <Link to="/" style={{marginRight: '1rem'}}>Atendimento</Link>
        <Link to="/usuarios" style={{marginRight: '1rem'}}>Usuários</Link>
        <Link to="/animais">Animais</Link>
      </nav>

      <Routes>
        <Route path="/" element={<Atendimento />} />
        <Route path="/usuarios" element={<Usuarios />} />
        <Route path="/animais" element={<Animais />} />
      </Routes>
    </Router>
  )
}

export default App
=======
      <Routes>
        <Route path="/login" element={<LoginPage />} />
        {/* Adicione outras rotas aqui, ex: <Route path="/" element={<HomePage />} /> */}
      </Routes>
    </Router>
  );
}

export default App;
>>>>>>> Stashed changes
