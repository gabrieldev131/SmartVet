// src/components/Layout.jsx

import React from 'react';
import { Outlet, NavLink } from 'react-router-dom'; // Trocado Link por NavLink
import styled, { createGlobalStyle } from 'styled-components';

// CORREÇÃO: `createGlobalStyle` com 'S' maiúsculo.
const GlobalStyle = createGlobalStyle`
  body {
    margin: 0;
    font-family: 'Poppins', sans-serif;
    background-color: #f4f7fa;
    color: #333;
  }
  * {
    box-sizing: border-box;
  }
`;

const colors = {
  primary: '#0A3D62',
  accent: '#FF8C00',
  white: '#FFFFFF',
};

const AppWrapper = styled.div`
  display: flex;
  flex-direction: column;
  min-height: 100vh;
`;

const Header = styled.header`
  background-color: ${colors.white};
  padding: 1rem 2.5rem;
  box-shadow: 0 2px 8px rgba(0, 0, 0, 0.05);
  display: flex;
  justify-content: space-between;
  align-items: center;
  position: sticky;
  top: 0;
  z-index: 10;
`;

// Usando NavLink direto no seletor para o link não ter decoração
const LogoLink = styled(NavLink)`
    text-decoration: none;
`;

const Logo = styled.h1`
  font-size: 2rem;
  font-weight: 700;
  color: ${colors.primary};
  margin: 0;
  cursor: pointer;

  span {
    color: ${colors.accent};
  }
`;

const Nav = styled.nav`
  display: flex;
  gap: 1.5rem;

  // CORREÇÃO: O estilo .active é aplicado pelo NavLink
  a {
    text-decoration: none;
    color: #333;
    font-weight: 600;
    padding: 0.5rem;
    border-bottom: 3px solid transparent;
    transition: border-bottom-color 0.3s, color 0.3s;

    &:hover {
      color: ${colors.accent};
    }

    &.active {
      color: ${colors.primary};
      border-bottom-color: ${colors.accent};
    }
  }
`;

const MainContent = styled.main`
  flex-grow: 1;
  padding: 2.5rem;
  max-width: 1400px;
  width: 100%;
  margin: 0 auto;
`;


const Layout = () => {
  return (
    <>
      <GlobalStyle />
      <AppWrapper>
        <Header>
          <LogoLink to="/">
            <Logo>Smart<span>Pet</span></Logo>
          </LogoLink>
          <Nav>
            <NavLink to="/">Atendimento</NavLink>
            <NavLink to="/usuarios">Usuários</NavLink>
            <NavLink to="/animais">Animais</NavLink>
          </Nav>
        </Header>
        <MainContent>
          <Outlet />
        </MainContent>
      </AppWrapper>
    </>
  );
};

export default Layout;