import React from 'react';
import styled from 'styled-components';

const NavContainer = styled.div`
  display: flex;
  flex-direction: column;
  width: 280px;
  height: 100vh;
  background-color: #ffffff;
  border-right: 3px solid #333;
  padding: 20px;
  box-sizing: border-box; /* Garante que o padding não aumente a largura */
`;

const Logo = styled.h1`
  font-family: 'Gochi Hand', cursive;
  font-size: 2.5rem;
  border: 3px solid #333;
  border-radius: 15px;
  padding: 15px;
  text-align: center;
  margin-bottom: 30px;
`;

const NavButton = styled.button`
  width: 100%;
  padding: 20px;
  margin-bottom: 10px;
  background-color: ${props => props.active ? '#e0f7ff' : '#f8f9fa'};
  border: 2px solid #333;
  border-radius: 15px;
  font-size: 1.1rem;
  font-weight: bold;
  text-align: left;
  cursor: pointer;
  
  &:hover {
    background-color: #e0f7ff;
  }
`;

function Navbar() {
  // Neste exemplo, "Clientes e Animais" está sempre ativo
  return (
    <NavContainer>
      <Logo>SmartPet</Logo>
      <NavButton active>Clientes e Animais</NavButton>
      {/* Outros botões podem ser adicionados aqui no futuro */}
    </NavContainer>
  );
}

export default Navbar;