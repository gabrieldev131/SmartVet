import  { useState, useEffect } from 'react';
import styled from 'styled-components';
import {AtendimentoButton} from './AtendimentoStyle';
import { AtendimentoGetAll } from '../../services/AtendimentoService'; 
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

const QueueListContainer = styled.div`
  margin-top: 50px;
  background-color: ${colors.lightGrayBg};
  border-radius: 12px;
  padding: 30px;
  box-shadow: 0 8px 20px rgba(0, 0, 0, 0.08);
`;

const QueueListHeader = styled.div`
  display: flex;
  justify-content: space-between;
  align-items: center;
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



export function AtendimentoList() {
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

  const [atendimentos, setAtendimentos] = useState([]);
  const [loading, setLoading] = useState(true);
  useEffect(() => {
      const fetchAtendimentos = async () => {
        try {
          const data = await AtendimentoGetAll();
          setAtendimentos(data);                         // atualiza o estado
        } catch (error) {
          console.error('Erro ao buscar atendimentos:', error);
        } finally {
          setLoading(false);
        }
      };
  
      fetchAtendimentos();
    }, []);


  const handleNovoAtendimento = () => {

  }

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
    <QueueListContainer>
      <QueueListHeader>
        <QueueListTitle>Animais na Fila ({queue.length})</QueueListTitle>
        <AtendimentoButton className='new-atendimento' onClick={handleNovoAtendimento}> Novo Atendimento </AtendimentoButton>
        </QueueListHeader>
        
        {queue.length === 0 ? (
          <EmptyQueueMessage>
            A fila de atendimento está vazia no momento. Adicione um atendimento!
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
  );
}

export default AtendimentoList;