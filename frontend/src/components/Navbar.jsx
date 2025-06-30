import React from 'react';
import styled from 'styled-components';
import { Link, useLocation } from 'react-router-dom';

// Importe sua imagem da logo
import SmartPetLogo from '../imgs/logo.png'; // Ajuste o caminho conforme onde sua imagem estiver

const NavContainer = styled.div`
  display: flex;
  flex-direction: column;
  width: 280px;
  height: 100vh;
  background: linear-gradient(to bottom, #e0f7fa, #bbdefb); /* Azul claro suave para o fundo */
  border-right: 1px solid #a7d9f7; /* Borda mais suave */
  padding: 20px;
  box-sizing: border-box;
  box-shadow: 2px 0 10px rgba(0, 0, 0, 0.1); /* Sombra sutil para profundidade */
`;

const LogoContainer = styled.div`
  display: flex;
  justify-content: center;
  align-items: center;
  margin-bottom: 40px; /* Mais espaço abaixo da logo */
  padding: 10px;
  background-color: #ffffff;
  border-radius: 10px;
  box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1); /* Sombra para o container da logo */
`;

const LogoImage = styled.img`
  width: 150px; /* Ajuste o tamanho conforme sua logo */
  height: auto;
`;

const NavButton = styled(Link)`
  width: 100%;
  padding: 15px 10px; /* Padding ajustado */
  margin-bottom: 15px; /* Mais espaço entre os botões */
  background-color: ${props => props.active ? '#81d4fa' : '#e3f2fd'}; /* Azuis mais vibrantes para os estados */
  color: ${props => props.active ? '#ffffff' : '#0d214f'}; /* Cor do texto */
  text-decoration: none;
  border: none; /* Removendo a borda */
  border-radius: 8px; /* Bordas mais suaves */
  font-size: 1.1rem;
  font-weight: 600; /* Um pouco mais encorpado */
  text-align: left;
  cursor: pointer;
  transition: all 0.3s ease; /* Transição suave para hover e active */
  box-shadow: ${props => props.active ? '0 4px 10px rgba(0, 0, 0, 0.2)' : 'none'}; /* Sombra ao ativo */

  &:hover {
    background-color: #4fc3f7; /* Azul mais escuro no hover */
    color: #ffffff;
    transform: translateY(-2px); /* Efeito de levantar no hover */
  }

  &:active {
    transform: translateY(0); /* Retorna à posição normal ao clicar */
    box-shadow: inset 0 2px 5px rgba(0, 0, 0, 0.2); /* Sombra interna para feedback de clique */
  }
`;

function Navbar() {
  return (
    <NavContainer>
      <LogoContainer>
        <LogoImage src={SmartPetLogo} alt="SmartPet Logo" />
      </LogoContainer>

      <NavButton to="/" active={location.pathname === '/'}>Início</NavButton>

      <NavButton to="/fila-atendimento" active={location.pathname === '/fila-atendimento'}>Fila de Atendimento</NavButton>
      
      <NavButton to="/clientes-e-animais" active={location.pathname === '/clientes-e-animais'}>Clientes e Animais</NavButton>
    
    </NavContainer>
  );
}

export default Navbar;