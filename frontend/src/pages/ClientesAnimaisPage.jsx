import React, { useState } from 'react';
import styled from 'styled-components';
import ClientCard from '../components/ClientCard';
import Modal from '../components/Modal'; // Importe o Modal
import NewClientForm from '../components/NovoClienteForm'; // Importe o formulário

// Dados de exemplo (mock data) - Tornamos mutável para adicionar novos clientes
const initialMockClients = [
  {
    id: 1,
    nome: 'Robson Ferreira',
    cpf: '123.456.789-00',
    animais: [
      { id: 101, nome: 'Animal 1' },
      { id: 102, nome: 'Animal 2' },
    ],
  },
  {
    id: 2,
    nome: 'Maria Souza',
    cpf: '987.654.321-99',
    animais: [{ id: 103, nome: 'Bolinha' }],
  },
  {
    id: 3,
    nome: 'Pedro Alvares',
    cpf: '111.222.333-44',
    animais: [{ id: 104, nome: 'Mel' }, { id: 105, nome: 'Thor' }],
  },
  {
    id: 4,
    nome: 'Ana Paula',
    cpf: '555.666.777-88',
    animais: [{ id: 106, nome: 'Luna' }],
  },
];

const colors = {
  primaryBlue: '#3498db',
  secondaryOrange: '#e67e22',
  lightBlue: '#81d4fa',
  lightOrange: '#ffcc80',
  darkGray: '#333',
  lightGray: '#f0f2f5',
  successGreen: '#2ecc71',
  warningYellow: '#f1c40f',
};

const PageWrapper = styled.div`
  padding: 40px;
  background-color: white;
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

const ActionButtons = styled.div`
  display: flex;
  gap: 20px;
`;

const Button = styled.button`
  padding: 15px 30px;
  border-radius: 8px;
  border: none;
  font-weight: 600;
  font-size: 1.05rem;
  cursor: pointer;
  transition: all 0.3s ease;
  box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);

  &.new-client {
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
  }

  &.new-animal {
    background-color: ${colors.secondaryOrange};
    color: white;
    &:hover {
      background-color: #d35400;
      transform: translateY(-2px);
      box-shadow: 0 6px 12px rgba(0, 0, 0, 0.15);
    }
    &:active {
      transform: translateY(0);
      box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
    }
  }
`;

const SearchContainer = styled.div`
  position: relative;
  margin-bottom: 40px;
`;

const SearchInput = styled.input`
  width: 100%;
  box-sizing: border-box;
  padding: 15px 20px;
  padding-left: 50px;
  border: 1px solid #ddd;
  border-radius: 25px;
  font-size: 1.1rem;
  box-shadow: 0 2px 5px rgba(0, 0, 0, 0.05);
  transition: border-color 0.3s ease, box-shadow 0.3s ease;

  &:focus {
    outline: none;
    border-color: ${colors.lightBlue};
    box-shadow: 0 0 0 3px rgba(129, 212, 250, 0.3);
  }

  &::placeholder {
    color: #999;
  }
`;

const SearchIcon = styled.span`
  position: absolute;
  left: 20px;
  top: 50%;
  transform: translateY(-50%);
  color: #999;
  font-size: 1.2rem;
  content: "🔍";
`;

const ClientList = styled.div`
  display: grid;
  grid-template-columns: repeat(auto-fill, minmax(300px, 1fr));
  gap: 25px;
`;

function ClientesAnimaisPage() {
  const [searchTerm, setSearchTerm] = useState('');
  const [isModalOpen, setIsModalOpen] = useState(false); // Estado para controlar o modal
  const [clients, setClients] = useState(initialMockClients); // Usar um estado mutável para clientes

  // Lógica simples de filtro
  const filteredClients = clients.filter(client => 
    client.nome.toLowerCase().includes(searchTerm.toLowerCase()) ||
    client.cpf.includes(searchTerm) ||
    client.animais.some(animal => animal.nome.toLowerCase().includes(searchTerm.toLowerCase()))
  );

  const handleOpenModal = () => {
    setIsModalOpen(true);
  };

  const handleCloseModal = () => {
    setIsModalOpen(false);
  };

  const handleAddClient = (newClient) => {
    setClients(prevClients => [...prevClients, newClient]); // Adiciona o novo cliente à lista
  };

  return (
    <PageWrapper>
      <Header>
        <Title>Clientes e Animais</Title>
        <ActionButtons>
          <Button className="new-client" onClick={handleOpenModal}>Novo Cliente</Button>
          <Button className="new-animal">Novo Animal</Button>
        </ActionButtons>
      </Header>

      <SearchContainer>
        <SearchInput 
          type="text"
          placeholder="Buscar Usuário, CPF ou Animal..."
          value={searchTerm}
          onChange={(e) => setSearchTerm(e.target.value)}
        />
        <SearchIcon>🔍</SearchIcon>
      </SearchContainer>

      <ClientList>
        {filteredClients.length > 0 ? (
          filteredClients.map(client => (
            <ClientCard key={client.id} client={client} />
          ))
        ) : (
          <p>Nenhum cliente ou animal encontrado.</p>
        )}
      </ClientList>

      {/* O Modal é renderizado aqui, com o formulário como seu filho */}
      <Modal isOpen={isModalOpen} onClose={handleCloseModal}>
        <NewClientForm onClientAdded={handleAddClient} onClose={handleCloseModal} />
      </Modal>
    </PageWrapper>
  );
}

export default ClientesAnimaisPage;