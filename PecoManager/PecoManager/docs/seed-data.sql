USE PecoDB;
GO

-- Date de test: Stații PECO
INSERT INTO StatiePeco (Denumire, Adresa, Oras, NrPompe, Status) VALUES
('Peco Nord',        'Str. Ștefan cel Mare 12',   'Chișinău',  6, 'Activa'),
('Peco Sud',         'Bd. Dacia 45',               'Chișinău',  4, 'Activa'),
('Peco Bălți',       'Str. Independenței 7',       'Bălți',     5, 'Activa'),
('Peco Orhei',       'Str. Vasile Lupu 23',        'Orhei',     3, 'Activa'),
('Peco Cahul',       'Str. Republicii 89',         'Cahul',     4, 'Activa'),
('Peco Tiraspol',    'Str. Lenin 15',              'Tiraspol',  6, 'Inactiva');
GO

-- Date de test: Combustibili
INSERT INTO Combustibil (Tip, PretPerLitru, StocLitri) VALUES
('Benzina 95',   22.50, 5000.00),
('Motorina',     21.80, 8000.00),
('GPL',          11.20, 3000.00);
GO

-- Date de test: Tranzacții
INSERT INTO Tranzactie (IdStatie, IdCombustibil, DataOra, CantitateaLitri, SumaTotala, ModPlata) VALUES
(1, 1, '2026-04-01 08:30:00', 40.00,  900.00,  'Card'),
(1, 2, '2026-04-01 09:15:00', 60.00,  1308.00, 'Numerar'),
(2, 1, '2026-04-02 10:00:00', 35.00,  787.50,  'Card'),
(2, 3, '2026-04-02 11:30:00', 20.00,  224.00,  'Numerar'),
(3, 2, '2026-04-03 07:45:00', 80.00,  1744.00, 'Card'),
(3, 1, '2026-04-03 13:00:00', 45.00,  1012.50, 'Card'),
(4, 2, '2026-04-04 08:00:00', 55.00,  1199.00, 'Numerar'),
(4, 3, '2026-04-04 15:30:00', 30.00,  336.00,  'Card'),
(5, 1, '2026-04-05 09:00:00', 50.00,  1125.00, 'Numerar'),
(5, 2, '2026-04-05 16:00:00', 70.00,  1526.00, 'Card');
GO