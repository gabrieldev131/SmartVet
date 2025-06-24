// src/App.jsx

import { BrowserRouter as Router, Routes, Route, Link } from 'react-router-dom';
import Atendimento from '../pages/Atendimento';
import Usuarios from '../pages/Usuarios';
import Animais from '../pages/Animais';
// Você pode criar um componente de Navegação/Layout para não repetir o menu
// import Navbar from './components/Navbar';

function App() {
  return (
    <Router>
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