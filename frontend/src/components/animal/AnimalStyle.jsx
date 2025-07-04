import styled from "styled-components";

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
  padding: 8px 12px;
  border: none;
  border-radius: 4px;
  cursor: pointer;

  &.edit {
    background-color: #4caf50;
    color: white;
  }

  &.delete {
    background-color: #f44336;
    color: white;
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