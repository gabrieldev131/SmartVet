// src/pages/Atendimento.jsx

import React, { useState, useEffect } from 'react';
import styled, { createGlobalStyle } from 'styled-components';
// Usando react-icons para ícones modernos e fáceis de usar
import { FiClipboard, FiPlus, FiChevronsRight, FiX, FiUsers, FiHeart } from 'react-icons/fi';

// Importe sua API (quando estiver pronta)
// import * as api from '../api/api.js';

// --- ESTILOS GLOBAIS ---
// Você pode manter os estilos de fonte e reset no seu `index.css`
// ou usar o createGlobalStyle para garantir que a página tenha a fonte correta.
const GlobalStyle = createGlobalStyle`
  body {
    font-family: 'Poppins', sans-serif; // Garante a fonte moderna
    background-color: #f4f7fa;
  }
`;

// --- PALETA DE CORES ---
const colors = {
    primary: '#0A3D62',
    secondary: '#0c5b9e',
    accent: '#FF8C00',
    accentHover: '#FFA500',
    white: '#FFFFFF',
    text: '#333',
    lightGray: '#f4f7fa',
    danger: '#E74C3C',
    success: '#2ECC71',
};

// --- COMPONENTES ESTILIZADOS ---
const PageWrapper = styled.div`
  padding: 2rem;
  max-width: 1200px;
  margin: 0 auto;
`;

const Header = styled.header`
  display: flex;
  justify-content: space-between;
  align-items: center;
  margin-bottom: 2rem;
`;

const Logo = styled.h1`
  font-size: 2.5rem;
  font-weight: 700;
  color: ${colors.primary};

  span {
    color: ${colors.accent};
  }
`;

const MainGrid = styled.div`
  display: grid;
  grid-template-columns: 2fr 1fr; // Coluna da fila maior que a de ações
  gap: 2rem;

  @media (max-width: 900px) {
    grid-template-columns: 1fr; // Empilha em telas menores
  }
`;

const Card = styled.div`
  background-color: ${colors.white};
  border-radius: 8px;
  box-shadow: 0 4px 12px rgba(0, 0, 0, 0.05);
  padding: 1.5rem 2rem;
  display: flex;
  flex-direction: column;

  h3 {
    color: ${colors.secondary};
    margin-bottom: 1.5rem;
    display: flex;
    align-items: center;
    gap: 0.8rem;
    font-size: 1.4rem;
  }
`;

const QueueList = styled.ul`
  list-style: none;
  height: 400px; // Altura fixa para permitir scroll
  overflow-y: auto;
`;

const QueueItem = styled.li`
  display: flex;
  justify-content: space-between;
  align-items: center;
  padding: 1rem;
  border-bottom: 1px solid #eee;
  transition: background-color 0.2s ease;

  &:hover {
    background-color: #fafafa;
  }

  span {
    font-weight: 600;
    color: ${colors.text};
  }
`;

const ActionButtons = styled.div`
  display: flex;
  gap: 0.8rem;
`;

const IconButton = styled.button`
  background: none;
  border: none;
  color: ${props => props.color || colors.text};
  font-size: 1.3rem;
  cursor: pointer;
  transition: transform 0.2s, color 0.2s;

  &:hover {
    transform: scale(1.2);
    color: ${props => (props.color === colors.success ? '#27AE60' : props.color === colors.danger ? '#C0392B' : colors.accent)};
  }
`;

const PrimaryButton = styled.button`
  background-color: ${colors.accent};
  color: ${colors.white};
  border: none;
  border-radius: 5px;
  padding: 0.8rem 1.5rem;
  font-size: 1rem;
  font-weight: 600;
  cursor: pointer;
  display: flex;
  align-items: center;
  justify-content: center;
  gap: 0.5rem;
  transition: background-color 0.3s ease;
  width: 100%;
  margin-top: 1rem;

  &:hover {
    background-color: ${colors.accentHover};
  }
`;

// --- COMPONENTE PRINCIPAL ---
const Atendimento = () => {
    // No futuro, estes dados virão da sua API
    // useEffect(() => {
    //   api.getAnimaisNaFila().then(response => setFila(response.data));
    // }, []);
    const [fila, setFila] = useState([
        { id: 1, nome: 'Thor', dono: 'Ana Silva' },
        { id: 2, nome: 'Luna', dono: 'Carlos Souza' },
        { id: 3, nome: 'Simba', dono: 'Mariana Lima' },
        { id: 4, nome: 'Mel', dono: 'Jorge Pereira' },
    ]);

    const handleAction = (id, action) => {
        const animal = fila.find(a => a.id === id);
        alert(`Ação: ${action} para o animal ${animal.nome}`);
        // Aqui você chamaria sua API:
        // api.updateStatusAtendimento(id, action).then(() => { ... });
        setFila(fila.filter(a => a.id !== id));
    };

    return (
        <>
            <GlobalStyle />
            <PageWrapper>
                <Header>
                    <Logo>Smart<span>Pet</span></Logo>
                </Header>
                <MainGrid>
                    <Card>
                        <h3>
                            <FiClipboard />
                            Fila de Atendimento
                        </h3>
                        <QueueList>
                            {fila.length > 0 ? (
                                fila.map((animal) => (
                                    <QueueItem key={animal.id}>
                                        <div>
                                            <span>{animal.nome}</span>
                                            <p style={{ color: '#777', fontSize: '0.9rem' }}>Dono(a): {animal.dono}</p>
                                        </div>
                                        <ActionButtons>
                                            <IconButton
                                                title="Atender"
                                                color={colors.success}
                                                onClick={() => handleAction(animal.id, 'Atendido')}
                                            >
                                                <FiChevronsRight />
                                            </IconButton>
                                            <IconButton
                                                title="Desistiu"
                                                color={colors.danger}
                                                onClick={() => handleAction(animal.id, 'Desistiu')}
                                            >
                                                <FiX />
                                            </IconButton>
                                        </ActionButtons>
                                    </QueueItem>
                                ))
                            ) : (
                                <p style={{textAlign: 'center', color: '#888', marginTop: '2rem'}}>A fila de atendimento está vazia.</p>
                            )}
                        </QueueList>
                    </Card>

                    <Card>
                        <h3>
                            <FiUsers />
                            Ações Rápidas
                        </h3>
                        {/* No futuro, este botão abrirá o seu AnimalForm em um modal ou em outra página */}
                        <PrimaryButton onClick={() => alert('Abrir formulário para adicionar novo animal na fila!')}>
                            <FiPlus />
                            Adicionar na Fila
                        </PrimaryButton>

                        {/* Aqui você pode adicionar links para as outras páginas */}
                        <h3 style={{marginTop: '2rem'}}>
                            <FiHeart />
                            Gerenciar
                        </h3>
                        <p>Acesse as áreas de gestão do sistema.</p>
                        {/* Exemplo de como você pode linkar para suas outras páginas com react-router-dom */}
                        {/* <Link to="/usuarios">Gerenciar Usuários</Link> */}
                        {/* <Link to="/animais">Gerenciar Animais</Link> */}
                    </Card>
                </MainGrid>
            </PageWrapper>
        </>
    );
};

export default Atendimento;