import { useEffect, useState } from "react";
import UserForm from "../components/UserForm";
import UserList from "../components/UserList";
import api from "../api/api";

export default function Usuarios() {
  const [users, setUsers] = useState([]);
  const [selectedUser, setSelectedUser] = useState(null);

  async function fetchUsers() {
    const res = await api.get("/usuarios");
    setUsers(res.data);
  }

  useEffect(() => {
    fetchUsers();
  }, []);

  return (
    <div>
      <h2>Usuários</h2>
      <UserForm
        fetchUsers={fetchUsers}
        selectedUser={selectedUser}
        clearSelection={() => setSelectedUser(null)}
      />
      <UserList users={users} fetchUsers={fetchUsers} setSelectedUser={setSelectedUser} />
    </div>
  );
}
