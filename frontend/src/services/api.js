import axios from 'axios';
import { useNavigate } from 'react-router-dom';

const api = axios.create({
  baseURL: 'http://localhost:8080/api',
});

api.interceptors.request.use((config) => {
  const token = sessionStorage.getItem('token');
  if (token) {
    config.headers.Authorization = `Bearer ${token}`;
  }
  return config;
});

api.interceptors.response.use(
  (response) => response,
  (error) => {
    if (error.response) {
      const { status } = error.response;

      // token inválido ou expirado
      if (status === 401) {
        sessionStorage.removeItem('token');        // limpa o token
        useNavigate('/')
      }

      // acesso não autorizado a recurso
      if (status === 403) {
        alert(`Acesso não autorizado`)
      }
    }

    // propagação do erro para tratamento
    return Promise.reject(error);
  }
);

export default api;