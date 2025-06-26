import React from 'react';
import styled from 'styled-components';
import Navbar from '../components/Navbar';

const LayoutContainer = styled.div`
  display: flex;
  background-color: #f0f4f8; /* Fundo cinza claro como no login */
`;

const Content = styled.main`
  flex-grow: 1; /* Ocupa o espaço restante */
  height: 100vh;
  overflow-y: auto; /* Adiciona scroll se o conteúdo for grande */
`;

function MainLayout({ children }) {
  return (
    <LayoutContainer>
      <Navbar />
      <Content>{children}</Content>
    </LayoutContainer>
  );
}

export default MainLayout;