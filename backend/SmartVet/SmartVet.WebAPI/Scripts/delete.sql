-- Desabilitar constraints de chave estrangeira
ALTER TABLE Animal NOCHECK CONSTRAINT ALL;
ALTER TABLE Apointment NOCHECK CONSTRAINT ALL;

-- Deletar dados das tabelas
DELETE FROM Animal;
DELETE FROM Apointment;

-- Habilitar constraints de chave estrangeira
ALTER TABLE Animal WITH CHECK CHECK CONSTRAINT ALL;
ALTER TABLE Apointment WITH CHECK CHECK CONSTRAINT ALL;