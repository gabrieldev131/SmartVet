import React from 'react';
import styled from 'styled-components';

// Importe sua imagem da logo
import SmartPetLogo from '../imgs/logo.png'; // Ajuste o caminho se sua logo estiver em outro lugar

// Paleta de cores (para consistência)
const colors = {
  primaryBlue: '#3498db', // Azul vibrante
  secondaryOrange: '#e67e22', // Laranja energético
  darkGray: '#333',
  mediumGray: '#555',
  lightGrayBg: '#f0f2f5', // Um cinza bem claro para fundos secundários
};

const HomePageWrapper = styled.div`
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  min-height: calc(100vh - 80px); /* Ajusta a altura para ocupar o restante da tela */
  background-color: white; /* Fundo branco como solicitado */
  padding: 40px;
  box-sizing: border-box;
  text-align: center;
  font-family: 'Inter', 'Segoe UI', Roboto, 'Helvetica Neue', Arial, sans-serif;
`;

const LogoContainer = styled.div`
  margin-bottom: 40px;
  animation: fadeIn 1s ease-out; /* Animação de fade-in */

  @keyframes fadeIn {
    from {
      opacity: 0;
      transform: translateY(-20px);
    }
    to {
      opacity: 1;
      transform: translateY(0);
    }
  }
`;

const LogoImage = styled.img`
  width: 250px; /* Tamanho maior para destaque na home */
  height: auto;
`;

const WelcomeTitle = styled.h1`
  font-size: 4.5rem; /* Título bem grande */
  color: ${colors.primaryBlue};
  margin-bottom: 20px;
  letter-spacing: 2px;
  text-shadow: 3px 3px 6px rgba(0, 0, 0, 0.1);
  animation: slideInLeft 1s ease-out forwards; /* Animação de deslize da esquerda */
  opacity: 0; /* Começa invisível para a animação */

  @keyframes slideInLeft {
    from {
      opacity: 0;
      transform: translateX(-50px);
    }
    to {
      opacity: 1;
      transform: translateX(0);
    }
  }
`;

const WelcomeText = styled.p`
  font-size: 1.5rem;
  color: ${colors.mediumGray};
  line-height: 1.6;
  max-width: 700px;
  margin-bottom: 50px;
  animation: fadeIn 1.5s ease-out 0.5s forwards; /* Animação de fade-in com delay */
  opacity: 0; /* Começa invisível para a animação */
`;

const CallToAction = styled.a`
  background-color: ${colors.secondaryOrange};
  color: white;
  padding: 18px 40px;
  border-radius: 30px; /* Botão em formato de pílula */
  text-decoration: none;
  font-size: 1.2rem;
  font-weight: 700;
  transition: all 0.3s ease;
  box-shadow: 0 5px 15px rgba(0, 0, 0, 0.1);
  
  &:hover {
    background-color: #d35400; /* Laranja mais escuro no hover */
    transform: translateY(-3px); /* Efeito de levantar */
    box-shadow: 0 8px 20px rgba(0, 0, 0, 0.15);
  }
  &:active {
    transform: translateY(0);
    box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1);
  }
  animation: fadeIn 1.5s ease-out 1s forwards; /* Animação de fade-in com delay maior */
  opacity: 0; /* Começa invisível para a animação */
`;

function HomePage() {
  return (
    <HomePageWrapper>
      <LogoContainer>
        <LogoImage src={SmartPetLogo} alt="SmartPet Logo" />
      </LogoContainer>
      <WelcomeTitle>Bem-vindo ao SmartVet!</WelcomeTitle>
      <WelcomeText>
        Sua plataforma completa para gerenciar atendimentos veterinários.
        Simplifique o cadastro de clientes, acompanhe a saúde dos animais e organize
        sua fila de atendimento com facilidade.
      </WelcomeText>
      {/* Exemplo de botão que leva para a página de clientes, use Link do react-router-dom se estiver usando */}
      <CallToAction href="/clientes-e-animais">Começar Agora</CallToAction>
    </HomePageWrapper>
  );
}

export default HomePage;