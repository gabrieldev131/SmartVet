import React, { useEffect, useMemo, useState } from 'react';
import { Animal, AnimalCreate, AnimalGetAll } from '../../services/AnimalService';
import { AnimalCard } from './AnimalCard';
import { CardButton, FormInput } from './AnimalStyle';
import AnimalCreateForm from './AnimalCreateCard'

function AnimalList() {
  const [animals, setAnimals] = useState([]);     // aqui o estado que o React observa
  const [loading, setLoading] = useState(true);
  const [creating, setCreating] = useState(false);
  const [filterInputs, setFilterInputs] = useState({
    name: '',
    breed: '',
    specie: '',
    birth_year: '',
    weight: ''
  })
  const [filters, setFilters] = useState({
    name: '',
    breed: '',
    specie: '',
    birth_year: '',
    weight: ''
  });

  useEffect(() => {
    const fetchAnimals = async () => {
      try {
        const data = await AnimalGetAll();
        setAnimals(data);                         // atualiza o estado
      } catch (error) {
        console.error('Erro ao buscar animais:', error);
      } finally {
        setLoading(false);
      }
    };

    fetchAnimals();
  }, []);

  const filteredAnimals = useMemo(() => {
    return animals.filter((a) =>
      (!filters.name ||
        a.animal_name.toLowerCase().includes(filters.name.toLowerCase())) &&
      (!filters.breed ||
        a.breed.toLowerCase().includes(filters.breed.toLowerCase())) &&
      (!filters.specie ||
        a.specie.toLowerCase().includes(filters.specie.toLowerCase())) &&
      (!filters.birth_year ||
        String(a.birth_year) === String(filters.birth_year)) &&
      (!filters.weight || String(a.weight) === String(filters.weight))
    );
  }, [animals, filters]);

  if (loading) return <p>Carregando...</p>;

  const handleUpdated = (updated) =>
    setAnimals((prev) =>
      prev.map((a) => (a.id === updated.id ? updated : a))
    );

  const handleDeleted = (id) =>
    setAnimals((prev) => prev.filter((a) => a.id !== id));

  const handleCreated = async (createdAnimal) => {
    try {
      const animal = new Animal({id: createdAnimal.id, animal_name: createdAnimal.animal_name, specie: createdAnimal.specie, breed: createdAnimal.breed, birth_year: createdAnimal.birth_year, weight: createdAnimal.weight})
      await AnimalCreate(animal);
      const data = await AnimalGetAll();
      setAnimals(data);
      setCreating(false);
    } catch (err) {
      console.error('Erro ao criar animal', err);
    }
  };

  const handleFilterChange = (e) =>
    setFilters((prev) => ({ ...prev, [e.target.name]: e.target.value }));

  const handleInputChange = (e) =>
    setFilterInputs((prev) => ({
      ...prev,
      [e.target.name]: e.target.value
    }));

  const handleApplyFilters = () => {
    setFilters(filterInputs);
  };

  const handleClearFilters = () => {
    setFilterInputs({
      name: '',
      breed: '',
      specie: '',
      birth_year: '',
      weight: ''
    });
    setFilters({
      name: '',
      breed: '',
      specie: '',
      birth_year: '',
      weight: ''
    });

  }

  return (
    <div>
      <div>
        <FormInput
          name="name"
          placeholder="Nome"
          value={filters.name}
          onChange={handleFilterChange}
          className="input"
        />
        <FormInput
          name="breed"
          placeholder="Raça"
          value={filters.breed}
          onChange={handleFilterChange}
          className="input"
        />
        <FormInput
          name="specie"
          placeholder="Espécie"
          value={filters.specie}
          onChange={handleFilterChange}
          className="input"
        />
        <FormInput
          name="birth_year"
          placeholder="Ano de nascimento"
          type="number"
          value={filters.birth_year}
          onChange={handleFilterChange}
          className="input"
        />
        <FormInput
          name="weight"
          placeholder="Peso (kg)"
          type="number"
          value={filters.weight}
          onChange={handleFilterChange}
          className="input"
        />

        <CardButton className="delete" onClick={handleClearFilters}>
            Limpar filtros
        </CardButton>
      </div>

      <CardButton className="edit" onClick={() => setCreating(true)}>
        Novo Animal
      </CardButton>

      {creating && (
        <AnimalCreateForm
          onSave={handleCreated}
          onCancel={() => setCreating(false)}
        />
      )}

      {/* {animals.map((animal) => (
        <AnimalCard key={animal.id} animal={animal} onUpdate={handleUpdated} onDelete={handleDeleted} />
      ))} */}

      {filteredAnimals.length === 0 ? (
        <p>Nenhum animal encontrado.</p>
      ) : (
        filteredAnimals.map((animal) => (
          <AnimalCard
            key={animal.id}
            animal={animal}
            onUpdate={handleUpdated}
            onDelete={handleDeleted}
          />
        ))
      )}
    </div>
  );
}

export default AnimalList;