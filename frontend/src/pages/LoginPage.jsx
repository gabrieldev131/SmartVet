import React, { useState } from 'react';
import styled from 'styled-components';

// -------------------- STYLES --------------------
// (Estilos criados com styled-components para replicar o protótipo)

const PageContainer = styled.div`
  display: flex;
  justify-content: center;
  align-items: center;
  height: 100vh;
  background-color: #f0f4f8;
  font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;
`;

const LoginWrapper = styled.div`
  display: flex;
  background-color: white;

  border-radius: 25px;
  box-shadow: 10px 10px 0px rgba(0, 0, 0, 0.1);
  overflow: hidden;
`;

const FormPanel = styled.div`
  flex: 1;
  padding: 40px 60px;
  display: flex;
  flex-direction: column;
  justify-content: center;
`;

const Title = styled.h1`
  font-size: 3.5rem;
  font-weight: 400;
  margin:auto;
  margin-bottom: 30px;
  color: #333;
`;

const Input = styled.input`
  width: 100%;
  padding: 15px;
  margin-bottom: 20px;
  border: 2px solid #333;
  border-radius: 15px;
  font-size: 1rem;

  &:focus {
    outline: none;
    border-color: #007bff;
  }
`;

const OptionsWrapper = styled.div`
  display: flex;
  justify-content: space-between;
  align-items: center;
  margin-bottom: 25px;
`;

const CheckboxWrapper = styled.label`
  display: flex;
  align-items: center;
  cursor: pointer;
  
  input {
    margin-right: 8px;
  }
`;

const StyledLink = styled.a`
  color: #007bff;
  text-decoration: none;
  font-weight: 500;

  &:hover {
    text-decoration: underline;
  }
`;

const LoginButton = styled.button`
  width: 100%;
  padding: 15px;
  background-color: #e0f7ff;
  border-radius: 15px;
  font-size: 1.2rem;
  font-weight: bold;
  cursor: pointer;
  transition: background-color 0.2s;
  
  &:hover {
    background-color: #b3e5fc;
  }
`;

const SignUpText = styled.p`
  margin-top: 30px;
  text-align: center;
  color: #555;
`;

const GraphicPanel = styled.div`
  flex: 1;
  background-color: #b3e5fc;
  display: flex;
  justify-content: center;
  align-items: center;
`;

const CatIcon = styled.div`
  width: 150px;
  height: 150px;
  background-color: #ffb74d;
  border-radius: 50%;
  position: relative;
  
  /* As "orelhas" do gato/logo */
  &::before, &::after {
    content: '';
    position: absolute;
    width: 0;
    height: 0;
    border-left: 40px solid transparent;
    border-right: 40px solid transparent;
    border-bottom: 60px solid #ff9800;
    top: -30px;
  }

  &::before {
    transform: rotate(-45deg);
    left: -15px;
  }

  &::after {
    transform: rotate(45deg);
    right: -15px;
  }
`;

// -------------------- COMPONENT --------------------

function LoginPage() {
  const [email, setEmail] = useState('');
  const [senha, setSenha] = useState('');

  const handleLogin = (e) => {
    e.preventDefault();
    // Futuramente, a lógica de login com a API virá aqui
    alert(`Login tentado com:\nEmail: ${email}\nSenha: ${senha}`);
  };

  return (
    <PageContainer>
      <LoginWrapper>
        <FormPanel>
          <Title>Bem Vindo!</Title>
          <form onSubmit={handleLogin}>
            <Input 
              type="email" 
              placeholder="Email"
              value={email}
              onChange={(e) => setEmail(e.target.value)} 
            />
            <Input 
              type="password" 
              placeholder="Senha" 
              value={senha}
              onChange={(e) => setSenha(e.target.value)}
            />
            <OptionsWrapper>
              <StyledLink href="#">Esqueceu a senha?</StyledLink>
            </OptionsWrapper>
            <LoginButton type="submit">Login</LoginButton>
          </form>
          {/* <SignUpText>
            Novo por aqui? <StyledLink href="#">Cadastre-se</StyledLink>
          </SignUpText> */}
        </FormPanel>
        
        <GraphicPanel>
          <CatIcon />
        </GraphicPanel>

      </LoginWrapper>
    </PageContainer>
  );
}

export default LoginPage;