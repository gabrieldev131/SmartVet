import styled from "styled-components";

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

export const Card = styled.div`
  border: 1px solid #ccc;
  padding: 16px;
  border-radius: 8px;
  margin-bottom: 16px;
  background: #fdfdfd;
`;

export const AnimalInfo = styled.div`
  margin-bottom: 12px;
`;

export const AnimalName = styled.h3`
  margin: 0;
`;

export const AnimalSpecie = styled.p`
  margin: 4px 0;
`;

export const AnimalBreed = styled.p`
  margin: 4px 0;
`;

export const AnimalWeight = styled.p`
  margin: 4px 0;
`;

export const AnimalBirthYear = styled.p`
  margin: 4px 0;
`;

export const Actions = styled.div`
  display: flex;
  justify-content: flex-end;
  gap: 8px;
`;

export const CardButton = styled.button`
  padding: 15px 30px;
  border-radius: 8px;
  border: none;
  font-weight: 600;
  font-size: 1.05rem;
  cursor: pointer;
  transition: all 0.3s ease;
  box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);

  &.edit {
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

  &.delete {
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

export const FormRow = styled.div`
  display: flex;
  flex-direction: column;
  margin-bottom: 8px;
`;

export const FormLabel = styled.label`
  font-size: 0.9rem;
  margin-bottom: 4px;
`;

export const FormInput = styled.input`
  padding: 6px 8px;
  border: 1px solid #ccc;
  border-radius: 4px;
`;

export const FilterInput = styled.input`
`