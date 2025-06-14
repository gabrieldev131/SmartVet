import api from "../api/api";

export default function UserList({ users, fetchUsers, setSelectedUser }) {
  async function deleteUser(id) {
    await api.delete(`/usuarios/${id}`);
    fetchUsers();
  }

  return (
    <ul>
      {users.map((u) => (
        <li key={u.id}>
          {u.nome} - {u.email} - {u.telefone}
          <button onClick={() => setSelectedUser(u)}>Editar</button>
          <button onClick={() => deleteUser(u.id)}>Excluir</button>
        </li>
      ))}
    </ul>
  );
}
