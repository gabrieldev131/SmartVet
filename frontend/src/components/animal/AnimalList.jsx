import React, { useEffect, useState } from 'react';
import { AnimalCreate, AnimalGetAll } from '../../services/AnimalService';
import { AnimalCard } from './AnimalCard';
import { CardButton } from './AnimalStyle';
import { AnimalCreateForm } from './AnimalCreateCard'

function AnimalList() {
  const [animals, setAnimals] = useState([]);     // aqui o estado que o React observa
  const [loading, setLoading] = useState(true);
  const [creating, setCreating] = useState(false);

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

  if (loading) return <p>Carregando...</p>;

  const handleUpdated = (updated) =>
    setAnimals((prev) =>
      prev.map((a) => (a.id === updated.id ? updated : a))
    );

  const handleDeleted = (id) =>
    setAnimals((prev) => prev.filter((a) => a.id !== id));

  const handleCreated = async (formData) => {
    try {
      const newAnimal = await AnimalCreate(formData);
      setAnimals(prev => [...prev, newAnimal]);
      setCreating(false);
    } catch (err) {
      console.error('Erro ao criar animal', err);
    }
  };

  return (
    <div>
      <CardButton className="edit" onClick={() => setCreating(true)}>
        Novo Animal
      </CardButton>

      {creating && (
        <AnimalCreateForm
          onSave={handleCreated}
          onCancel={() => setCreating(false)}
        />
      )}

      {animals.map((animal) => (
        <AnimalCard key={animal.id} animal={animal} onUpdate={handleUpdated} onDelete={handleDeleted} />
      ))}
    </div>
  );
}

export default AnimalList;