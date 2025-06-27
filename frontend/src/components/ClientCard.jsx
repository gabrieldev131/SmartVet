import React from 'react';
import styled from 'styled-components';

const colors = {
  primaryBlue: '#3498db',
  secondaryOrange: '#e67e22',
  darkGray: '#333',
  mediumGray: '#555',
  lightGrayBg: '#f8f9fa',
  borderLight: '#e0e0e0',
};

const Card = styled.div`
  background-color: #ffffff;
  border-radius: 12px; /* Cantos arredondados */
  box-shadow: 0 6px 15px rgba(0, 0, 0, 0.08); /* Sombra mais pronunciada */
  padding: 25px;
  display: flex;
  flex-direction: column;
  transition: transform 0.2s ease, box-shadow 0.2s ease; /* Transição suave no hover */
  border: 1px solid ${colors.borderLight}; /* Borda sutil */

  &:hover {
    transform: translateY(-5px); /* Efeito de levantar */
    box-shadow: 0 10px 25px rgba(0, 0, 0, 0.12);
  }
`;

const ClientInfo = styled.div`
  margin-bottom: 15px;
  border-bottom: 1px dashed ${colors.borderLight}; /* Linha tracejada suave */
  padding-bottom: 15px;
`;

const ClientName = styled.h3`
  color: ${colors.primaryBlue};
  font-size: 1.7rem;
  margin: 0 0 5px 0;
  font-weight: 700;
`;

const ClientCpf = styled.p`
  color: ${colors.mediumGray};
  font-size: 0.95rem;
  margin: 0;
`;

const AnimalsSection = styled.div`
  h4 {
    color: ${colors.darkGray};
    font-size: 1.1rem;
    margin-top: 0;
    margin-bottom: 10px;
    font-weight: 600;
  }
`;

const AnimalList = styled.ul`
  list-style: none;
  padding: 0;
  margin: 0;
`;

const AnimalItem = styled.li`
  background-color: ${colors.lightGrayBg};
  padding: 8px 12px;
  border-radius: 6px;
  margin-bottom: 8px;
  display: flex;
  justify-content: space-between;
  align-items: center;
  color: ${colors.mediumGray};
  font-size: 0.9rem;
  font-weight: 500;
  border: 1px solid #eee; /* Borda mais fina */

  &:last-child {
    margin-bottom: 0;
  }
`;

const AnimalName = styled.span`
  color: ${colors.darkGray};
`;

const Actions = styled.div`
  margin-top: 20px;
  display: flex;
  gap: 10px;
  justify-content: flex-end; /* Alinha botões à direita */
`;

const CardButton = styled.button`
  padding: 8px 15px;
  border: none;
  border-radius: 6px;
  cursor: pointer;
  font-size: 0.9rem;
  font-weight: 600;
  transition: background-color 0.2s ease, transform 0.2s ease;

  &.edit {
    background-color: ${colors.lightBlue};
    color: white;
    &:hover {
      background-color: #5ac5ee;
      transform: translateY(-1px);
    }
  }

  &.delete {
    background-color: #e74c3c; /* Vermelho para deletar */
    color: white;
    &:hover {
      background-color: #c0392b;
      transform: translateY(-1px);
    }
  }
`;

function ClientCard({ client }) {
  return (
    <Card>
      <ClientInfo>
        <ClientName>{client.nome}</ClientName>
        <ClientCpf>CPF: {client.cpf}</ClientCpf>
      </ClientInfo>

      <AnimalsSection>
        <h4>Animais:</h4>
        {client.animais && client.animais.length > 0 ? (
          <AnimalList>
            {client.animais.map(animal => (
              <AnimalItem key={animal.id}>
                <AnimalName>{animal.nome}</AnimalName>
                {/* Aqui você poderia adicionar um ícone ou ação para o animal específico */}
              </AnimalItem>
            ))}
          </AnimalList>
        ) : (
          <p>Nenhum animal cadastrado.</p>
        )}
      </AnimalsSection>

      <Actions>
        <CardButton className="edit">Editar Cliente</CardButton>
        <CardButton className="delete">Excluir Cliente</CardButton>
      </Actions>
    </Card>
  );
}

export default ClientCard;