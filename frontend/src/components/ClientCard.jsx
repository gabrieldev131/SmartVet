import React from 'react';
import styled from 'styled-components';

const CardContainer = styled.div`
  background-color: white;
  border: 2px solid #333;
  border-radius: 15px;
  padding: 20px;
  margin-bottom: 20px;
`;

const ClientInfo = styled.div`
  display: flex;
  justify-content: space-between;
  align-items: center;
  padding-bottom: 15px;
  border-bottom: 2px solid #eee;
`;

const ClientName = styled.span`
  font-weight: bold;
  font-size: 1.2rem;
`;

const ClientActions = styled.div`
  display: flex;
  gap: 10px;
`;

const ActionButton = styled.button`
  padding: 10px 20px;
  border-radius: 10px;
  border: 2px solid #333;
  font-weight: bold;
  cursor: pointer;

  &.view {
    background-color: #cce5ff; /* Azul claro */
  }
  &.link-animal {
    background-color: #fff3cd; /* Amarelo claro */
  }
`;

const AnimalList = styled.ul`
  list-style-type: none;
  padding-top: 15px;
`;

const AnimalItem = styled.li`
  display: flex;
  justify-content: space-between;
  align-items: center;
  padding: 10px;
  border-radius: 10px;
  
  &:nth-child(odd) {
    background-color: #f8f9fa;
  }
`;

const StatusIndicator = styled.div`
  width: 20px;
  height: 20px;
  background-color: #d4edda; /* Verde */
  border: 2px solid #333;
  border-radius: 5px;
`;

function ClientCard({ client }) {
  return (
    <CardContainer>
      <ClientInfo>
        <div>
          <ClientName>{client.nome}</ClientName>
          <p>CPF: {client.cpf}</p>
        </div>
        <ClientActions>
          <ActionButton className="view">Visualizar</ActionButton>
          <ActionButton className="link-animal">Vincular Animal</ActionButton>
        </ClientActions>
      </ClientInfo>

      <AnimalList>
        {client.animais.map(animal => (
          <AnimalItem key={animal.id}>
            <span>{animal.nome}</span>
            <StatusIndicator />
          </AnimalItem>
        ))}
      </AnimalList>
    </CardContainer>
  );
}

export default ClientCard;