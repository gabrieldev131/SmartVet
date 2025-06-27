import React, { useState } from 'react';
import styled from 'styled-components';

// Mock de dados de clientes e animais para simular a seleção
// Em um sistema real, você buscaria isso do backend ou de um estado global
const mockClientsWithAnimals = [
  {
    id: 1,
    nome: 'Robson Ferreira',
    animais: [
      { id: 101, nome: 'Rex (Cachorro)', especie: 'Canina' },
      { id: 102, nome: 'Miau (Gato)', especie: 'Felina' },
    ],
  },
  {
    id: 2,
    nome: 'Maria Souza',
    animais: [
      { id: 103, nome: 'Bolinha (Coelho)', especie: 'Lagomorfa' },
    ],
  },
  {
    id: 3,
    nome: 'Pedro Alvares',
    animais: [
      { id: 104, nome: 'Mel (Pássaro)', especie: 'Ave' },
      { id: 105, nome: 'Thor (Cachorro)', especie: 'Canina' },
    ],
  },
];

// Paleta de cores (para consistência com as outras páginas)
const colors = {
  primaryBlue: '#3498db', // Azul vibrante
  secondaryOrange: '#e67e22', // Laranja energético
  lightBlue: '#81d4fa', // Azul mais claro
  darkGray: '#333',
  mediumGray: '#555',
  lightGrayBg: '#f0f2f5',
  successGreen: '#2ecc71',
  errorRed: '#e74c3c',
  neutralGray: '#95a5a6', // Um cinza neutro para ações secundárias
  infoBlue: '#3498db', // Azul para informações
};

const PageWrapper = styled.div`
  padding: 40px;
  background-color: white; /* Fundo branco como solicitado */
  min-height: calc(100vh - 80px);
  box-sizing: border-box;
  font-family: 'Inter', 'Segoe UI', Roboto, 'Helvetica Neue', Arial, sans-serif;
`;

const Header = styled.div`
  display: flex;
  justify-content: space-between;
  align-items: center;
  margin-bottom: 40px;
`;

const Title = styled.h1`
  font-size: 3.5rem;
  color: ${colors.darkGray};
  letter-spacing: 1px;
  text-shadow: 2px 2px 4px rgba(0, 0, 0, 0.05);
`;

const QueueControls = styled.div`
  display: flex;
  gap: 20px;
  align-items: flex-end; /* Alinha o dropdown com o botão */
`;

const SelectContainer = styled.div`
  display: flex;
  flex-direction: column;
`;

const Label = styled.label`
  font-size: 1rem;
  color: ${colors.mediumGray};
  margin-bottom: 8px;
  font-weight: 600;
`;

const Select = styled.select`
  padding: 12px 15px;
  border: 1px solid #ddd;
  border-radius: 8px;
  font-size: 1rem;
  background-color: white;
  cursor: pointer;
  appearance: none; /* Remove seta padrão do select */
  background-image: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' fill='%23555555'%3E%3Cpath d='M7 10l5 5 5-5z'/%3E%3C/svg%3E"); /* Adiciona seta customizada */
  background-repeat: no-repeat;
  background-position: right 15px center;
  background-size: 20px;
  min-width: 250px;
  box-shadow: 0 2px 5px rgba(0,0,0,0.05);

  &:focus {
    outline: none;
    border-color: ${colors.primaryBlue};
    box-shadow: 0 0 0 3px rgba(52, 152, 219, 0.2);
  }
`;

const AddToQueueButton = styled.button`
  padding: 15px 30px;
  border-radius: 8px;
  border: none;
  font-weight: 600;
  font-size: 1.05rem;
  cursor: pointer;
  transition: all 0.3s ease;
  box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
  background-color: ${colors.primaryBlue};
  color: white;

  &:hover {
    background-color: #2980b9;
    transform: translateY(-2px);
    box-shadow: 0 6px 12px rgba(0, 0, 0, 0.15);
  }
  &:active {
    transform: translateY(0);
    box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
  }
  &:disabled {
    background-color: #ccc;
    cursor: not-allowed;
    transform: none;
    box-shadow: none;
  }
`;

const QueueListContainer = styled.div`
  margin-top: 50px;
  background-color: ${colors.lightGrayBg};
  border-radius: 12px;
  padding: 30px;
  box-shadow: 0 8px 20px rgba(0, 0, 0, 0.08);
`;

const QueueListTitle = styled.h2`
  color: ${colors.darkGray};
  font-size: 2.2rem;
  margin-bottom: 25px;
  text-align: center;
  font-weight: 700;
`;

const QueueItem = styled.div`
  background-color: white;
  border: 1px solid ${colors.lightBlue};
  border-radius: 10px;
  padding: 20px 25px;
  margin-bottom: 15px;
  display: flex;
  justify-content: space-between;
  align-items: center;
  box-shadow: 0 4px 10px rgba(0, 0, 0, 0.05);
  transition: transform 0.2s ease;

  &:hover {
    transform: translateY(-3px);
    box-shadow: 0 6px 15px rgba(0, 0, 0, 0.1);
  }

  &:last-child {
    margin-bottom: 0;
  }
`;

const AnimalInfo = styled.div`
  flex-grow: 1; /* Ocupa o espaço restante */
`;

const AnimalName = styled.p`
  font-size: 1.3rem;
  font-weight: 700;
  color: ${colors.primaryBlue};
  margin: 0;
`;

const ClientName = styled.p`
  font-size: 0.95rem;
  color: ${colors.mediumGray};
  margin: 5px 0 0 0;
`;

const QueueActions = styled.div`
  display: flex;
  gap: 10px;
`;

const ActionButton = styled.button`
  padding: 10px 18px;
  border: none;
  border-radius: 8px;
  font-size: 0.95rem;
  font-weight: 600;
  cursor: pointer;
  transition: background-color 0.2s ease, transform 0.2s ease;
  box-shadow: 0 2px 5px rgba(0, 0, 0, 0.08);

  &.attended {
    background-color: ${colors.successGreen};
    color: white;
    &:hover {
      background-color: #27ae60;
      transform: translateY(-1px);
    }
  }

  &.gave-up {
    background-color: ${colors.errorRed};
    color: white;
    &:hover {
      background-color: #c0392b;
      transform: translateY(-1px);
    }
  }
`;

const EmptyQueueMessage = styled.p`
  text-align: center;
  font-size: 1.2rem;
  color: ${colors.mediumGray};
  padding: 30px;
  border: 2px dashed ${colors.lightBlue};
  border-radius: 10px;
  background-color: #f0f8ff; /* Fundo azul bem clarinho */
`;

function QueuePage() {
  const [selectedAnimalId, setSelectedAnimalId] = useState('');
  // Estado da fila: armazena objetos com { animal, client }
  const [queue, setQueue] = useState([]);

  // Função para pegar o animal e cliente selecionados no dropdown
  const getSelectedAnimalAndClient = () => {
    if (!selectedAnimalId) return null;

    for (const client of mockClientsWithAnimals) {
      const animal = client.animais.find(a => a.id === parseInt(selectedAnimalId));
      if (animal) {
        return { animal, client };
      }
    }
    return null;
  };

  const handleAddToQueue = () => {
    const selected = getSelectedAnimalAndClient();
    if (selected) {
      // Verifica se o animal já está na fila para evitar duplicatas simples
      const isAlreadyInQueue = queue.some(item => item.animal.id === selected.animal.id);
      if (isAlreadyInQueue) {
        alert('Este animal já está na fila!');
        return;
      }
      setQueue(prevQueue => [...prevQueue, selected]);
      setSelectedAnimalId(''); // Limpa a seleção após adicionar
    }
  };

  const handleRemoveFromQueue = (animalId) => {
    setQueue(prevQueue => prevQueue.filter(item => item.animal.id !== animalId));
  };

  return (
    <PageWrapper>
      <Header>
        <Title>Fila de Atendimento</Title>
        <QueueControls>
          <SelectContainer>
            <Label htmlFor="select-animal">Adicionar à Fila:</Label>
            <Select
              id="select-animal"
              value={selectedAnimalId}
              onChange={(e) => setSelectedAnimalId(e.target.value)}
            >
              <option value="">Selecione um cliente/animal</option>
              {mockClientsWithAnimals.map(client => (
                <optgroup key={client.id} label={client.nome}>
                  {client.animais.map(animal => (
                    <option key={animal.id} value={animal.id}>
                      {animal.nome}
                    </option>
                  ))}
                </optgroup>
              ))}
            </Select>
          </SelectContainer>
          <AddToQueueButton 
            onClick={handleAddToQueue}
            disabled={!selectedAnimalId} // Desabilita se nada estiver selecionado
          >
            Adicionar à Fila
          </AddToQueueButton>
        </QueueControls>
      </Header>

      <QueueListContainer>
        <QueueListTitle>Animais na Fila ({queue.length})</QueueListTitle>
        {queue.length === 0 ? (
          <EmptyQueueMessage>
            A fila de atendimento está vazia no momento. Adicione um animal!
          </EmptyQueueMessage>
        ) : (
          queue.map(item => (
            <QueueItem key={item.animal.id}>
              <AnimalInfo>
                <AnimalName>{item.animal.nome}</AnimalName>
                <ClientName>Cliente: {item.client.nome}</ClientName>
              </AnimalInfo>
              <QueueActions>
                <ActionButton 
                  className="attended" 
                  onClick={() => handleRemoveFromQueue(item.animal.id)}
                >
                  Atendido
                </ActionButton>
                <ActionButton 
                  className="gave-up" 
                  onClick={() => handleRemoveFromQueue(item.animal.id)}
                >
                  Desistiu
                </ActionButton>
              </QueueActions>
            </QueueItem>
          ))
        )}
      </QueueListContainer>
    </PageWrapper>
  );
}

export default QueuePage;