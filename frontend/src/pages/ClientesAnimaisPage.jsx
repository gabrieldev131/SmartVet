import React, { useState } from 'react';
import styled from 'styled-components';
import ClientCard from '../components/ClientCard';

// Dados de exemplo (mock data) para popular a tela
const mockClients = [
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
];

const PageWrapper = styled.div`
  padding: 40px;
  font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;
`;

const Header = styled.div`
  display: flex;
  justify-content: space-between;
  align-items: center;
  margin-bottom: 30px;
`;

const Title = styled.h1`
  font-family: 'Gochi Hand', cursive;
  font-size: 3rem;
  color: #333;
`;

const ActionButtons = styled.div`
  display: flex;
  gap: 15px;
`;

const Button = styled.button`
  padding: 15px 30px;
  border-radius: 15px;
  border: 3px solid #333;
  font-weight: bold;
  font-size: 1rem;
  cursor: pointer;

  &.new-client {
    background-color: #d4edda; /* Verde claro */
  }
  &.new-animal {
    background-color: #fff3cd; /* Amarelo claro */
  }
`;

const SearchInput = styled.input`
  width: 100%;
  padding: 15px;
  border: 2px solid #333;
  border-radius: 15px;
  font-size: 1rem;
  margin-bottom: 30px;
`;

function ClientesAnimaisPage() {
  const [searchTerm, setSearchTerm] = useState('');
  
  // Lógica simples de filtro
  const filteredClients = mockClients.filter(client => 
    client.nome.toLowerCase().includes(searchTerm.toLowerCase()) ||
    client.cpf.includes(searchTerm)
  );

  return (
    <PageWrapper>
      <Header>
        <Title>CLIENTES E ANIMAIS</Title>
        <ActionButtons>
          <Button className="new-client">Novo Cliente</Button>
          <Button className="new-animal">Novo Animal</Button>
        </ActionButtons>
      </Header>

      <SearchInput 
        type="text"
        placeholder="Buscar Usuário ou Animal..."
        value={searchTerm}
        onChange={(e) => setSearchTerm(e.target.value)}
      />

      <div>
        {filteredClients.map(client => (
          <ClientCard key={client.id} client={client} />
        ))}
      </div>
    </PageWrapper>
  );
}

export default ClientesAnimaisPage;