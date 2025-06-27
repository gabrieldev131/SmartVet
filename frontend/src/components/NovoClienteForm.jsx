import React, { useState } from 'react';
import styled from 'styled-components';

const colors = {
  primaryBlue: '#3498db',
  secondaryOrange: '#e67e22',
  darkGray: '#333',
  mediumGray: '#555',
  successGreen: '#2ecc71',
  errorRed: '#e74c3c',
};

const FormTitle = styled.h2`
  color: ${colors.darkGray};
  font-size: 2rem;
  margin-bottom: 25px;
  text-align: center;
  font-family: 'Inter', sans-serif; /* Usando a fonte da sua página */
`;

const Form = styled.form`
  display: flex;
  flex-direction: column;
  gap: 18px; /* Espaço entre os campos */
`;

const FormGroup = styled.div`
  display: flex;
  flex-direction: column;
`;

const Label = styled.label`
  font-size: 1rem;
  color: ${colors.mediumGray};
  margin-bottom: 8px;
  font-weight: 600;
`;

const Input = styled.input`
  padding: 12px 15px;
  border: 1px solid #ccc;
  border-radius: 8px;
  font-size: 1rem;
  transition: border-color 0.2s ease, box-shadow 0.2s ease;

  &:focus {
    outline: none;
    border-color: ${colors.primaryBlue};
    box-shadow: 0 0 0 3px rgba(52, 152, 219, 0.2);
  }
`;

const TextArea = styled.textarea`
  padding: 12px 15px;
  border: 1px solid #ccc;
  border-radius: 8px;
  font-size: 1rem;
  min-height: 80px;
  resize: vertical;
  transition: border-color 0.2s ease, box-shadow 0.2s ease;

  &:focus {
    outline: none;
    border-color: ${colors.primaryBlue};
    box-shadow: 0 0 0 3px rgba(52, 152, 219, 0.2);
  }
`;

const SubmitButton = styled.button`
  background-color: ${colors.successGreen};
  color: white;
  padding: 15px 25px;
  border: none;
  border-radius: 8px;
  font-size: 1.1rem;
  font-weight: 700;
  cursor: pointer;
  margin-top: 25px;
  transition: background-color 0.2s ease, transform 0.2s ease, box-shadow 0.2s ease;
  box-shadow: 0 4px 10px rgba(46, 204, 113, 0.2);

  &:hover {
    background-color: #27ae60;
    transform: translateY(-2px);
    box-shadow: 0 6px 15px rgba(46, 204, 113, 0.3);
  }

  &:active {
    transform: translateY(0);
    box-shadow: 0 2px 5px rgba(46, 204, 113, 0.1);
  }
`;

const Message = styled.p`
  text-align: center;
  margin-top: 15px;
  font-weight: 600;
  color: ${props => props.type === 'success' ? colors.successGreen : colors.errorRed};
`;

function NewClientForm({ onClientAdded, onClose }) {
  const [clientData, setClientData] = useState({
    nome: '',
    cpf: '',
    telefone: '',
    email: '',
    endereco: '',
  });
  const [message, setMessage] = useState('');
  const [messageType, setMessageType] = useState('');

  const handleChange = (e) => {
    const { name, value } = e.target;
    setClientData(prevData => ({
      ...prevData,
      [name]: value,
    }));
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    // Simulação de validação e envio
    if (!clientData.nome || !clientData.cpf || !clientData.telefone) {
      setMessageType('error');
      setMessage('Por favor, preencha todos os campos obrigatórios (Nome, CPF, Telefone).');
      return;
    }

    // AQUI VOCÊ FARIA A CHAMADA PARA O BACKEND
    // Ex: axios.post('/api/clients', clientData)
    // Por enquanto, apenas simulamos o sucesso
    console.log('Dados do novo cliente (simulado):', clientData);
    setMessageType('success');
    setMessage('Cliente cadastrado com sucesso (simulado)!');
    // Você pode chamar uma função para adicionar o cliente à lista na página pai
    if (onClientAdded) {
      onClientAdded({ ...clientData, id: Date.now() }); // Gera um ID simples para o mock
    }
    
    // Opcional: Limpar formulário ou fechar modal após um tempo
    setTimeout(() => {
      setClientData({ nome: '', cpf: '', telefone: '', email: '', endereco: '' });
      setMessage('');
      if (onClose) onClose(); // Fecha o modal
    }, 1500); // Fecha após 1.5 segundos
  };

  return (
    <>
      <FormTitle>Novo Cliente</FormTitle>
      <Form onSubmit={handleSubmit}>
        <FormGroup>
          <Label htmlFor="nome">Nome Completo:</Label>
          <Input
            type="text"
            id="nome"
            name="nome"
            value={clientData.nome}
            onChange={handleChange}
            placeholder="Nome completo do cliente"
            required
          />
        </FormGroup>
        <FormGroup>
          <Label htmlFor="cpf">CPF:</Label>
          <Input
            type="text"
            id="cpf"
            name="cpf"
            value={clientData.cpf}
            onChange={handleChange}
            placeholder="Ex: 123.456.789-00"
            required
          />
        </FormGroup>
        <FormGroup>
          <Label htmlFor="telefone">Telefone:</Label>
          <Input
            type="text"
            id="telefone"
            name="telefone"
            value={clientData.telefone}
            onChange={handleChange}
            placeholder="Ex: (XX) XXXX-XXXX"
            required
          />
        </FormGroup>
        <FormGroup>
          <Label htmlFor="email">Email:</Label>
          <Input
            type="email"
            id="email"
            name="email"
            value={clientData.email}
            onChange={handleChange}
            placeholder="email@exemplo.com"
          />
        </FormGroup>
        <FormGroup>
          <Label htmlFor="endereco">Endereço:</Label>
          <TextArea
            id="endereco"
            name="endereco"
            value={clientData.endereco}
            onChange={handleChange}
            placeholder="Rua, número, bairro, cidade..."
          />
        </FormGroup>
        <SubmitButton type="submit">Cadastrar Cliente</SubmitButton>
        {message && <Message type={messageType}>{message}</Message>}
      </Form>
    </>
  );
}

export default NewClientForm;