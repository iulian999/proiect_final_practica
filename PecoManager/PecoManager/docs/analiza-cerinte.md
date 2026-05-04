# Analiza Cerințelor — PecoManager

## Descrierea proiectului
Aplicație desktop WinForms pentru gestionarea stațiilor PECO.
Permite gestionarea stațiilor, tipurilor de combustibil și tranzacțiilor de alimentare.

## Tehnologii utilizate
- C# Windows Forms (.NET 8)
- SQL Server Express
- Microsoft.Data.SqlClient

## Cerințe funcționale obligatorii

### 1. Gestionarea stațiilor PECO
- **Descriere:** Adăugarea, modificarea, ștergerea și vizualizarea stațiilor
- **Input:** Denumire, Adresă, Oraș, Nr. Pompe, Status
- **Output:** Listă stații în DataGridView
- **Reguli:** O stație nu poate fi ștearsă dacă are tranzacții asociate

### 2. Gestionarea combustibililor
- **Descriere:** Gestionarea tipurilor de combustibil și prețurilor
- **Input:** Tip (Benzină/Motorină/GPL), Preț/Litru, Stoc
- **Output:** Listă combustibili în DataGridView
- **Reguli:** Prețul trebuie să fie mai mare decât 0

### 3. Gestionarea tranzacțiilor
- **Descriere:** Înregistrarea fiecărei alimentări la o stație
- **Input:** Stație, Combustibil, Cantitate litri, Mod plată
- **Output:** Listă tranzacții cu suma totală calculată automat
- **Reguli:** Cantitatea trebuie să fie mai mare decât 0

### 4. Căutare și filtrare
- **Descriere:** Căutarea stațiilor după oraș, filtrarea tranzacțiilor după dată
- **Input:** Text căutare / interval dată
- **Output:** Rezultate filtrate în DataGridView

### 5. Raport sumar
- **Descriere:** Raport cu totalul vânzărilor per stație
- **Input:** Selectare perioadă
- **Output:** Fereastră separată cu stație, nr. tranzacții, total încasat

### 6. Validarea datelor
- **Descriere:** Verificarea câmpurilor înainte de salvare
- **Reguli:** Câmpuri obligatorii completate, preț > 0, format valid

### 7. Interfața aplicației
- Meniu principal de navigare (MenuStrip)
- Formulare separate pentru fiecare modul
- DataGridView pentru afișarea datelor

## Cerințe bonus
- Export raport în TXT
- Statistici generale: total tranzacții, total încasat, media per stație
- Validare: stație duplicată nu poate fi adăugată