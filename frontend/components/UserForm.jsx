import { useState, useEffect } from "react";
import api from "../api/api";

export default function UserForm({ fetchUsers, selectedUser, clearSelection }) {
  const [formData, setFormData] = useState({ nome: "", email: "", telefone: "" });

  useEffect(() => {
    if (selectedUser) setFormData(selectedUser);
  }, [selectedUser]);

  function handleChange(e) {
    setFormData({ ...formData, [e.target.name]: e.target.value });
  }

  async function handleSubmit(e) {
    e.preventDefault();
    if (selectedUser) {
      await api.put(`/usuarios/${selectedUser.id}`, formData);
      clearSelection();
    } else {
      await api.post("/usuarios", formData);
    }
    setFormData({ nome: "", email: "", telefone: "" });
    fetchUsers();
  }

  return (
    <form onSubmit={handleSubmit}>
      <input name="nome" placeholder="Nome" value={formData.nome} onChange={handleChange} />
      <input name="email" placeholder="Email" value={formData.email} onChange={handleChange} />
      <input name="telefone" placeholder="Telefone" value={formData.telefone} onChange={handleChange} />
      <button type="submit">{selectedUser ? "Atualizar" : "Cadastrar"}</button>
      {selectedUser && <button onClick={clearSelection}>Cancelar</button>}
    </form>
  );
}
