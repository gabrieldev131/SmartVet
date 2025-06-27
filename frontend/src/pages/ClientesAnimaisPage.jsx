import React, { useState } from 'react';
import styled from 'styled-components';
import ClientCard from '../components/ClientCard'; // Certifique-se de que o ClientCard está no lugar certo

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

// Paleta de cores para consistência
const colors = {
  primaryBlue: '#3498db', // Azul vibrante
  secondaryOrange: '#e67e22', // Laranja energético
  lightBlue: '#81d4fa', // Azul mais claro para botões ou destaques
  lightOrange: '#ffcc80', // Laranja mais claro
  darkGray: '#333',
  lightGray: '#f0f2f5', // Um cinza bem claro para fundos secundários
  successGreen: '#2ecc71', // Verde para sucesso
  warningYellow: '#f1c40f', // Amarelo para atenção
};

const PageWrapper = styled.div`
  padding: 40px;
  background-color: white; /* Fundo branco como solicitado */
  min-height: calc(100vh - 80px); /* Ajusta a altura mínima para ocupar a tela */
  box-sizing: border-box; /* Garante que padding não aumente o tamanho */
  font-family: 'Inter', 'Segoe UI', Roboto, 'Helvetica Neue', Arial, sans-serif; /* Fonte moderna e limpa */
`;

const Header = styled.div`
  display: flex;
  justify-content: space-between;
  align-items: center;
  margin-bottom: 40px; /* Mais espaço para o cabeçalho */
`;

const Title = styled.h1`
  font-size: 3.5rem; /* Título maior */
  color: ${colors.darkGray};
  letter-spacing: 1px;
  text-shadow: 2px 2px 4px rgba(0, 0, 0, 0.05); /* Sombra suave para profundidade */
`;

const ActionButtons = styled.div`
  display: flex;
  gap: 20px; /* Mais espaço entre os botões */
`;

const Button = styled.button`
  padding: 15px 30px;
  border-radius: 8px; /* Cantos mais arredondados */
  border: none; /* Sem borda para um look mais limpo */
  font-weight: 600; /* Texto mais encorpado */
  font-size: 1.05rem;
  cursor: pointer;
  transition: all 0.3s ease; /* Transição suave para hover */
  box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1); /* Sombra padrão para todos os botões */

  &.new-client {
    background-color: ${colors.primaryBlue};
    color: white;
    &:hover {
      background-color: #2980b9; /* Azul um pouco mais escuro no hover */
      transform: translateY(-2px); /* Efeito de "levantar" */
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
      background-color: #d35400; /* Laranja um pouco mais escuro no hover */
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
  margin-bottom: 40px; /* Mais espaço abaixo da busca */
`;

const SearchInput = styled.input`
  width: 100%;
  padding: 15px 20px; /* Mais padding para conforto */
  padding-left: 50px; /* Espaço para o ícone de busca */
  border: 1px solid #ddd; /* Borda mais suave */
  border-radius: 25px; /* Mais arredondado (pílula) */
  font-size: 1.1rem;
  box-shadow: 0 2px 5px rgba(0, 0, 0, 0.05); /* Sombra sutil */
  transition: border-color 0.3s ease, box-shadow 0.3s ease;

  &:focus {
    outline: none;
    border-color: ${colors.lightBlue}; /* Borda azul no foco */
    box-shadow: 0 0 0 3px rgba(129, 212, 250, 0.3); /* Sombra de foco azul */
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
  /* Use um ícone real aqui, por exemplo, de uma biblioteca como FontAwesome */
  /* Para este exemplo, vou usar um "lupa" textual */
  content: "🔍"; /* Caractere de lupa unicode */
`;


const ClientList = styled.div`
  display: grid;
  grid-template-columns: repeat(auto-fill, minmax(300px, 1fr)); /* Layout responsivo com grid */
  gap: 25px; /* Espaço entre os cards */
`;

function ClientesAnimaisPage() {
  const [searchTerm, setSearchTerm] = useState('');
  
  // Lógica simples de filtro
  const filteredClients = mockClients.filter(client => 
    client.nome.toLowerCase().includes(searchTerm.toLowerCase()) ||
    client.cpf.includes(searchTerm) ||
    client.animais.some(animal => animal.nome.toLowerCase().includes(searchTerm.toLowerCase()))
  );

  return (
    <PageWrapper>
      <Header>
        <Title>Clientes e Animais</Title>
        <ActionButtons>
          <Button className="new-client">Novo Cliente</Button>
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
        <SearchIcon>🔍</SearchIcon> {/* Ícone de lupa */}
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
    </PageWrapper>
  );
}

export default ClientesAnimaisPage;