import api from "./api"

const endpoint = `/SmartVet/Animal`

export const animalService = {
    getAll: () => api.get(endpoint),

    getById: id => api.get(`${endpoint}/${id}`),

    create: payload => api.post(endpoint, payload),

    update: (id, payload) => api.put(`${endpoint}/${id}`, payload),

    delete: id => api.delete(`${endpoint}/${id}`)
}

// exemplo de uso
// { data, status } = animalService.getAll()
// { data, status } = animalService.getById(id)
// { data, status } = animalService.create(payload)
// { data, status } = animalService.update(id, payload)
// { data, status } = animalService.delete(id)

// OBS: id e payload devem ser no formato especificado no Swagger