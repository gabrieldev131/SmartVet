import React from 'react';
import { BrowserRouter as Router, Routes, Route, Navigate } from 'react-router-dom';
import MainLayout from './layouts/MainLayout';
import LoginPage from './pages/LoginPage';
import ClientesAnimaisPage from './pages/ClientesAnimaisPage';
import HomePage from './pages/InicioPage';

// Componente simples para a página inicial
function App() {
  return (
    <Router>
      <Routes>
        {/* Rota de Login não tem a Navbar */}
        <Route path="/login" element={<LoginPage />} />

        {/* Rotas dentro do MainLayout (com a Navbar) */}
        <Route path="/" element={
          <MainLayout>
            <HomePage />
          </MainLayout>
        } />
        <Route path="/clientes-e-animais" element={
          <MainLayout>
            <ClientesAnimaisPage />
          </MainLayout>
        } />

        {/* Redireciona qualquer outra rota para a página inicial */}
        <Route path="*" element={<Navigate to="/" />} />
      </Routes>
    </Router>
  );
}

export default App;