import { useNavigate } from "react-router-dom";
import api from "./api"

const endpoint = `/Account/login`

const loginService = {
    async Login(login) {
        try {
            const payload = login.toJson()
            const response = await api.post(endpoint, payload);
            sessionStorage.setItem("token", response.data.token);
            return response.data;
        } catch (error) {
            console.error("Erro no login:", error);
        }
    }
}

export class Login {
    email
    password

    constructor({email, password}) {
        this.email = email
        this.password = password
    }

    toJson() {
        return {
            email: this.email,
            password: this.password
        }
    }
}

export async function LoginAttempt(login) {
    const res = await loginService.Login(login)
    return res
}

export function LogOut() {
  sessionStorage.removeItem('token');
  useNavigate('/');
}