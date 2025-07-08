import React, { useState } from 'react';
import styled from 'styled-components';

function AtendimentoForm({ animals, onSave, onCancel }) {
  const [form, setForm] = useState({
    scheduled_date: '',
    urgency: '',
    result_description: '',
    animalId: '',
  });

  const handleChange = (e) => {
    setForm({ ...form, [e.target.name]: e.target.value });
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    onSave(form);
  };

  return (
    <form onSubmit={handleSubmit}>
      <label>Animal:</label>
      <select name="animalId" onChange={handleChange} value={form.animalId} required>
        <option value="">Selecione um animal</option>
        {animals.map((a) => (
          <option key={a.id} value={a.id}>{a.animal_name}</option>
        ))}
      </select>

      <label>Urgência:</label>
      <select name="urgency" onChange={handleChange} value={form.urgency} required>
        <option value="">Selecione a urgência</option>
        <option value={0}>Baixa</option>
        <option value={1}>Média</option>
        <option value={2}>Alta</option>
        <option value={3}>Urgente</option>
      </select>

      <label>Data do Atendimento:</label>
      <input type="datetime-local" name="scheduled_date" onChange={handleChange} value={form.scheduled_date} required />

      <label>Descrição do resultado (opcional):</label>
      <textarea name="result_description" onChange={handleChange} value={form.result_description} />

      <br />
      <button type="submit">Salvar</button>
      <button type="button" onClick={onCancel}>Cancelar</button>
    </form>
  );
}

export default AtendimentoForm;