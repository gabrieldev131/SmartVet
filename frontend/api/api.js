import axios from "axios";

const api = axios.create({
  baseURL: "http://localhost:3001", // URL da sua API ou JSON Server
});

export default api;