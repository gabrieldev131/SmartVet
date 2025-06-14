import { useState, useEffect } from "react";
import api from "../api/api";

export default function UserForm({ fetchUsers, selectedUser, clearSelection }) {
  const [formData, setFormData] = useState({ nome: "", especie: "", idade: "" });

  useEffect(() => {
    if (selectedUser) setFormData(selectedUser);
  }, [selectedUser]);

  function handleChange(e) {
    setFormData({ ...formData, [e.target.name]: e.target.value });
  }

  async function handleSubmit(e) {
    e.preventDefault();
    if (selectedUser) {
      await api.put(`/animais/${selectedUser.id}`, formData);
      clearSelection();
    } else {
      await api.post("/animais", formData);
    }
    setFormData({ nome: "", especie: "", idade: "" });
    fetchUsers();
  }

  return (
    <form onSubmit={handleSubmit}>
      <input name="nome" placeholder="Nome" value={formData.nome} onChange={handleChange} />
      <input name="email" placeholder="Espécie" value={formData.especie} onChange={handleChange} />
      <input name="telefone" placeholder="Idade" value={formData.idade} onChange={handleChange} />
      <button type="submit">{selectedUser ? "Atualizar" : "Cadastrar"}</button>
      {selectedUser && <button onClick={clearSelection}>Cancelar</button>}
    </form>
  );
}
