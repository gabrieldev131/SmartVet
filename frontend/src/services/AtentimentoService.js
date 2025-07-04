import api from "./api"

const endpoint = `/SmartVet/Apointment`

export const atendimentoService = {
    getAll: () => api.get(endpoint),

    getById: id => api.get(`${endpoint}/${id}`),

    create: payload => api.post(endpoint, payload),

    update: (id, payload) => api.put(`${endpoint}/${id}`, payload),

    delete: id => api.delete(`${endpoint}/${id}`)
}

// exemplo de uso
// { data, status } = atendimentoService.getAll()
// { data, status } = atendimentoService.getById(id)
// { data, status } = atendimentoService.create(payload)
// { data, status } = atendimentoService.update(id, payload)
// { data, status } = atendimentoService.delete(id)

// OBS: id e payload devem ser no formato especificado no Swagger