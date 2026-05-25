# TEXT ADIȚIONAL — RAPORT FuelSmart WEB
# Copie acest text în Word, la locațiile indicate

==============================================================
INTRODUCERE — după paragraful viziunii (după lista cu bullets)
==============================================================

Proiectul FuelSmart Web Portal se înscrie astfel într-un context de digitalizare accelerată a serviciilor cotidiene, urmând tendința globală de a pune la dispoziția cetățenilor instrumente digitale accesibile, gratuite și ușor de utilizat. Spre deosebire de aplicațiile de tip nativ care impun instalare și actualizări periodice, portalul web reprezintă o soluție zero-friction — utilizatorul deschide browserul, accesează adresa și are imediat acces la toate funcționalitățile, indiferent de sistemul de operare sau dispozitivul utilizat. Această accesibilitate universală este esențială pentru adoptarea pe scară largă în contextul moldovenesc, unde diversitatea dispozitivelor utilizate de conducătorii auto este mare. Arhitectura aleasă — fișiere HTML5/CSS3/JavaScript servite din directorul wwwroot al API-ului ASP.NET Core — elimină complet necesitatea unui server web separat (nginx, Apache), reducând costurile de infrastructură și simplificând procesul de deployment la un singur proiect Visual Studio.


==============================================================
CAPITOL 1 — înainte de secțiunea 1.1 (după titlul capitolului)
==============================================================

Capitolul de față realizează o analiză cuprinzătoare a domeniului în care se înscrie portalul web FuelSmart, examinând atât contextul economic și social care justifică necesitatea acestuia, cât și peisajul soluțiilor digitale existente pe plan internațional și local. Înțelegerea profundă a domeniului de studiu constituie fundația pe care se construiesc toate deciziile de proiectare și implementare — de la alegerea tehnologiilor la definirea cerințelor funcționale și la prioritizarea funcționalităților. Analiza s-a bazat pe studiul literaturii de specialitate, pe evaluarea directă a platformelor similare și pe înțelegerea nevoilor specifice ale pieței moldovenești de combustibil, caracterizată prin prețuri reglementate de ANRE și actualizate săptămânal.


==============================================================
1.1 Importanța temei — după paragraful final al secțiunii
==============================================================

Relevanța platformei web FuelSmart depășește simpla dimensiune a economiilor financiare individuale. Dintr-o perspectivă macroeconomică, digitalizarea pieței combustibililor contribuie la creșterea transparenței prețurilor și la stimularea concurenței loiale între distribuitori. Atunci când consumatorii au acces facil la comparații de prețuri în timp real, furnizorii sunt motivați să mențină prețuri competitive, efectul de piață generând beneficii sistemice pentru toți participanții. Din punct de vedere academic, proiectul demonstrează aplicabilitatea practică a conceptelor moderne de dezvoltare web — REST API, autentificare stateless prin cookie-uri, ORM Code-First, design responsiv — într-un context real, cu date reale și utilizatori reali, transformând teoria în soluție funcțională testabilă și măsurabilă.


==============================================================
FIGURA 1.1 (Evoluția prețurilor ANRE) — text DUPĂ figura 1.1
==============================================================

Figura 1.1 ilustrează evoluția prețurilor la principalele tipuri de combustibil comercializate în Republica Moldova pe parcursul anului 2024-2025, conform datelor publicate de Agenția Națională pentru Reglementare în Energetică (ANRE). Se poate observa cu claritate caracterul fluctuant al prețurilor, determinate de cotațiile internaționale ale petrolului, de cursul de schimb valutar și de politica de reglementare a ANRE. Variațiile săptămânale, vizibile în grafic, confirmă necesitatea unui instrument digital care să centralizeze și să prezinte aceste informații într-un format accesibil și ușor de interpretat pentru conducătorul auto obișnuit, care nu urmărește în mod regulat buletinele oficiale ANRE. Portalul FuelSmart adresează exact această nevoie, oferind date actualizate în timp real prin intermediul panoului de administrare.


==============================================================
1.2 Sisteme similare — după paragraful introductiv al secțiunii
==============================================================

Metodologia analizei comparative a urmărit evaluarea sistemelor existente pe baza a șase criterii esențiale: existența unui portal web accesibil din browser, acoperirea geografică a pieței moldovenești, disponibilitatea funcționalităților de jurnal personal al consumului, calitatea interfeței de administrare a datelor, modelul de business (gratuit vs. plătit) și nivelul de securitate al datelor utilizatorilor. Această grilă de evaluare a permis identificarea clară a avantajelor competitive ale soluției FuelSmart Web Portal față de alternativele existente și a fundamentat deciziile de design luate în faza de proiectare.


==============================================================
FIGURA 1.2 (GasBuddy) — text DUPĂ figura 1.2
==============================================================

Figura 1.2 prezintă interfața principală a portalului web GasBuddy, liderul global în segmentul aplicațiilor de monitorizare a prețurilor la combustibil. Analiza vizuală a interfeței evidențiază mai multe elemente de design relevante pentru proiectul FuelSmart: utilizarea hărții interactive ca element central al experienței utilizatorului, afișarea prețurilor direct pe marker-ele hărții pentru acces rapid la informație și structura de navigare simplă, axată pe funcțiile principale. Deși GasBuddy demonstrează maturitatea conceptuală a domeniului, absența completă a acoperirii pentru Republica Moldova face această platformă irelevantă pentru piața locală, confirmând oportunitatea și necesitatea dezvoltării unei soluții dedicate contextului moldovenesc.


==============================================================
FIGURA 1.3 (Peco.md) — text DUPĂ figura 1.3
==============================================================

Figura 1.3 prezintă interfața platformei web Peco.md, singura soluție web locală care oferă date despre prețurile combustibililor în Republica Moldova. Analiza comparativă cu portalul FuelSmart evidențiază diferențele fundamentale de abordare: Peco.md funcționează ca un agregator static de prețuri, fără autentificare, fără jurnal personal și fără funcționalități interactive. Interfața, deși funcțională din perspectiva informației brute, nu oferă utilizatorului niciun instrument de analiză personalizată sau de management al cheltuielilor cu combustibilul. FuelSmart Web Portal depășește această limitare prin integrarea unui dashboard personalizat, a hărții interactive, a calculatorului de eficiență și a jurnalului de alimentări — transformând informația statică într-un instrument activ de decizie și economisire.


==============================================================
FIGURA 1.4 (Fuelio) — text DUPĂ figura 1.4
==============================================================

Figura 1.4 ilustrează interfața aplicației mobile Fuelio, una dintre cele mai apreciate soluții de jurnal auto la nivel internațional. Aplicația excelează în urmărirea consumului personal și în generarea rapoartelor detaliate de eficiență, demonstrând valoarea acestor funcționalități pentru utilizatorii preocupați de costurile cu combustibilul. Portalul web FuelSmart preia și integrează conceptele dovedite ale Fuelio — jurnalul de alimentări cu calcul automat de consum, statisticile pe perioade de timp, comparația față de referințe — și le completează cu elemente esențiale pentru piața locală: harta cu cele 28 de stații din Republica Moldova, prețurile actualizate în timp real și panoul de administrare centralizat.


==============================================================
Tabelul 1.1 (Comparativ sisteme) — text DUPĂ tabel
==============================================================

Analiza sintetică din Tabelul 1.1 confirmă poziționarea unică a portalului web FuelSmart pe piața soluțiilor digitale pentru monitorizarea combustibilului: este singura platformă care combină accesibilitatea web (fără instalare), acoperirea completă a pieței moldovenești (28 de stații reale), funcționalitățile de jurnal personal și calculul eficienței cu un sistem de administrare centralizat operabil de administratori. Această combinație de caracteristici nu este întâlnită la niciuna dintre soluțiile analizate, demonstrând că FuelSmart ocupă o nișă neacoperită pe piața locală și răspunde unor nevoi reale ale conducătorilor auto și ale administratorilor de stații din Republica Moldova.


==============================================================
1.3 Scopul, obiectivele și cerințele — după paragraful de scop
==============================================================

Definirea clară a scopului și obiectivelor a constituit etapa fundamentală a procesului de proiectare, asigurând că toate deciziile tehnice ulterioare — alegerea tehnologiilor, structura bazei de date, design-ul interfeței — sunt aliniate cu nevoia reală a utilizatorilor finali. Abordarea adoptată urmează metodologia analizei SMART (Specific, Measurable, Achievable, Relevant, Time-bound) pentru definirea obiectivelor, asigurând că fiecare funcționalitate implementată are o justificare clară și un criteriu de acceptanță verificabil. Cerințele funcționale și non-funcționale au fost extrase din analiza domeniului și din studiul comparativ al soluțiilor existente, reprezentând sinteza nevoilor identificate la utilizatorii potențiali ai platformei.


==============================================================
Tabelul 1.2 (Cerințe funcționale) — text DUPĂ tabel
==============================================================

Tabelul 1.2 prezintă cerințele funcționale ale portalului web FuelSmart, clasificate după prioritate și actor responsabil. Prioritizarea cerințelor ca „Critic" sau „Important" reflectă valoarea de business a fiecărei funcționalități: cerințele critice reprezintă funcționalitățile fără de care sistemul nu poate opera în parametrii definiți în scop, în timp ce cerințele importante aduc valoare adăugată semnificativă dar nu blochează operarea de bază. Această ierarhizare a ghidat procesul de implementare, asigurând că funcționalitățile esențiale (autentificarea, dashboard-ul, harta, administrarea) au fost finalizate prioritar, înaintea celor cu prioritate secundară.


==============================================================
Tabelul 1.3 (Cerințe non-funcționale) — text DUPĂ tabel
==============================================================

Cerințele non-funcționale definite în Tabelul 1.3 au reprezentat constrângerile de calitate care au influențat deciziile de arhitectură ale sistemului. Cerința de performanță (timp de răspuns sub 2 secunde) a orientat decizia de a servi fișierele statice direct din wwwroot, eliminând un nivel de procesare intermediar. Cerința de securitate a dictat alegerea cookie-urilor HttpOnly față de alternativa JWT Bearer, protejând sesiunile utilizatorilor împotriva atacurilor XSS. Cerința de compatibilitate cu browsere multiple a influențat decizia de a evita framework-uri frontend cu suport limitat, optând pentru HTML5/CSS3/JavaScript standard. Toate aceste cerințe au fost verificate sistematic prin testare manuală înainte de declararea proiectului ca finalizat.


==============================================================
CAPITOL 2 — înainte de 2.1 (după titlul capitolului)
==============================================================

Capitolul al doilea este dedicat modelării și proiectării sistemului FuelSmart Web Portal, etapă fundamentală care transformă cerințele identificate în capitolul anterior în reprezentări formale, testabile și implementabile. Procesul de modelare a urmat standardele UML (Unified Modeling Language), utilizând patru tipuri de diagrame complementare — Use Case, Activitate, Stări și Clase — fiecare surprinzând o dimensiune diferită a comportamentului și structurii sistemului. Diagramele au fost generate cu PlantUML și Mermaid, instrumente open-source care permit descrierea diagramelor în text și generarea automată a reprezentărilor grafice, facilitând mentenanța și actualizarea documentației de proiectare pe parcursul dezvoltării.


==============================================================
2.1.1 Imaginea generală — DUPĂ paragraful introductiv
==============================================================

Diagrama Use Case capturează ansamblul funcționalităților din perspectiva utilizatorilor sistemului, definind granița sistemului (system boundary) și relațiile dintre actori și cazurile de utilizare. Sistemul FuelSmart Web Portal implică doi actori principali: Utilizatorul autentificat, care are acces la funcționalitățile standard (dashboard, hartă, jurnal, eficiență, favorite), și Administratorul, care moștenește toate drepturile utilizatorului și are acces suplimentar la panoul de administrare a stațiilor și prețurilor. Relațiile de tip «include» și «extend» modelează dependențele și extensiile opționale dintre cazurile de utilizare: calculul eficienței include obligatoriu accesul la jurnalul de alimentări, iar afișarea popup-ului cu prețuri extinde funcționalitatea de bază a vizualizării hărții.


==============================================================
FIGURA 2.1 (Use Case) — text DUPĂ figura 2.1
==============================================================

Figura 2.1 prezintă diagrama Use Case a portalului web FuelSmart, generată cu PlantUML. Diagrama evidențiază cele două niveluri de acces ale sistemului: nivelul User, cu șase cazuri de utilizare standard accesibile oricărui utilizator autentificat, și nivelul Admin, cu două cazuri de utilizare suplimentare protejate prin controlul de acces bazat pe roluri. Relația de generalizare dintre actori (Admin moștenește toate drepturile User) reflectă principiul minimal privilege — administratorul primește drepturi extinse strict necesar pentru rolul său, fără ca aceasta să modifice experiența utilizatorilor obișnuiți. Endpoint-urile API corespunzătoare fiecărui caz de utilizare (POST /api/Auth/Login, GET /api/Stations, POST /api/FuelLogs etc.) sunt mapate direct la controller-ele ASP.NET Core, asigurând trasabilitatea completă de la cerință la implementare.


==============================================================
2.1.2 Modelarea vizuală a fluxurilor — DUPĂ paragraful introductiv
==============================================================

Diagrama de Activitate modelează fluxul de control și de date prin sistem, cu accent pe secvențele de acțiuni, deciziile condiționale și activitățile paralele. Spre deosebire de diagrama Use Case care descrie ce face sistemul, diagrama de Activitate descrie cum — secvența exactă de pași care duce de la declanșarea unui eveniment la obținerea unui rezultat. Fluxul principal modelat acoperă ciclul complet de utilizare a portalului: de la accesarea URL-ului și verificarea sesiunii, prin autentificare și navigare în funcționalitățile principale, până la deconectarea securizată. Ramificările condiționale (cookie valid / cookie absent, rol User / rol Admin) sunt reprezentate prin noduri de decizie cu tranziții etichetate clar, facilitând înțelegerea logicii de acces la nivel de sistem.


==============================================================
FIGURA 2.2 (Diagrama Activitate) — text DUPĂ figura 2.2
==============================================================

Figura 2.2 prezintă diagrama de Activitate a fluxului principal al portalului web FuelSmart. Analiza diagramei evidențiază trei zone funcționale distincte: zona de autentificare (verificarea cookie-ului, formularul de login, setarea sesiunii), zona de navigare standard (dashboard, hartă, jurnal, eficiență, favorite) și zona de administrare (accesibilă exclusiv cu rol Admin). Decizia centrală de ramificare — „Cookie valid?" — determină traseul utilizatorului la accesarea oricărei pagini protejate, implementând un mecanism consistent de control al accesului aplicat uniform pe întreaga arhitectură. Acțiunile marcate cu cerere HTTP (POST, GET, DELETE) corespund direct apelurilor fetch() din codul JavaScript al fiecărei pagini, asigurând corespondența între modelul UML și implementarea efectivă.


==============================================================
2.1.3 Stările de tranzacție — DUPĂ paragraful introductiv
==============================================================

Diagrama de Stări modelează ciclul de viață al sesiunii de utilizator, capturând toate stările posibile ale sistemului din perspectiva autentificării și a nivelului de acces. Modelul de stări ale sesiunii este esențial pentru înțelegerea comportamentului sistemului în scenarii de eroare și de expirare: ce se întâmplă când cookie-ul expiră în timp ce utilizatorul navighează activ, cum se gestionează tentativele de acces la resurse protejate fără sesiune validă și cum tranziționează sistemul între stările User și Admin la schimbarea rolului. Aceste tranziții sunt gestionate de ASP.NET Core Identity la nivel de middleware, interceptând automat cererile HTTP neautorizate și returnând codurile HTTP corespunzătoare (401 Unauthorized, 403 Forbidden).


==============================================================
FIGURA 2.3 (Diagrama Stări) — text DUPĂ figura 2.3
==============================================================

Figura 2.3 prezintă diagrama de Stări a ciclului de viață al sesiunii în portalul web FuelSmart. Starea inițială (Neautentificat) este starea implicită la prima accesare sau după expirarea sesiunii — în această stare, orice tentativă de accesare a unei pagini protejate declanșează redirecționarea automată la login.html. Tranziția spre starea Autentificat User se produce la primirea răspunsului HTTP 200 de la /api/Auth/Login, moment în care browser-ul stochează cookie-ul HttpOnly. Tranziția suplimentară spre starea Autentificat Admin se produce când câmpul „role" din răspunsul JSON conține valoarea „Admin", declanșând afișarea vizibilă a linkului spre admin.html în bara de navigare. Starea finală (Sesiune expirată) este atinsă automat după 7 zile de inactivitate sau la apelul explicit al endpoint-ului /api/Auth/Logout.


==============================================================
2.2 Descrierea structurală — DUPĂ paragraful cu lista de tehnologii
==============================================================

Alegerea acestui stack tehnologic nu a fost întâmplătoare, ci a rezultat din evaluarea atentă a compatibilității componentelor, a maturității ecosistemelor și a experienței echipei de dezvoltare. ASP.NET Core 8.0 și Entity Framework Core 8.0 formează o pereche nativă, cu suport oficial Microsoft și documentație extinsă, garantând stabilitate pe termen lung. Combinația HTML5/CSS3/JavaScript fără framework reduce semnificativ complexitatea proiectului, eliminând etapele de build și transpilare și permițând debug direct în browserul de dezvoltare. SQL Server LocalDB este soluția optimă pentru mediul de dezvoltare și evaluare academică, oferind toate funcționalitățile SQL Server complet fără costuri de licențiere sau configurare complexă.


==============================================================
2.2.1 Descrierea structurii statice — DUPĂ paragraful cu lista entităților
==============================================================

Structura de date a sistemului FuelSmart respectă principiile normalizării relaționale (până la forma normală 3NF), eliminând redundanța și asigurând consistența datelor. Entitatea centrală a modelului este Station — toate celelalte entități de conținut (FuelPrice, FuelLog, UserFavorite) referențiază stațiile prin chei externe, ceea ce reflectă rolul pivotal al stațiilor de alimentare în logica de business a sistemului. Entitatea ApplicationUser extinde clasa IdentityUser furnizată de ASP.NET Core Identity, adăugând câmpurile specifice aplicației (FirstName, LastName) fără a duplica funcționalitățile de autentificare deja implementate de framework. Această abordare de extensie, față de crearea unui model custom de la zero, reduce riscul de vulnerabilități de securitate și simplifică implementarea autentificării.


==============================================================
FIGURA 2.4 (Diagrama Clase) — text DUPĂ figura 2.4
==============================================================

Figura 2.4 prezintă diagrama de Clase a entităților sistemului FuelSmart și relațiile configurate prin Entity Framework Core. Multiplicitățile relațiilor (1:N, N:M) sunt vizibile pe conexiunile dintre clase, confirmând corectitudinea modelului relațional implementat în baza de date. Cascading behavior-ul relațiilor — configurat prin EF Core Fluent API în ApplicationDbContext — determină comportamentul la ștergere: ștergerea unei stații declanșează ștergerea în cascadă a tuturor prețurilor, jurnalelor și favoritelor asociate, menținând integritatea referențială a bazei de date. Tipurile de date ale proprietăților reflectă alegeri deliberate: decimal pentru sume financiare (evitând erorile de rotunjire ale tipului float), int pentru kilometraj (valorile întregi sunt suficiente), DateTime pentru timestampuri (cu timezone support în SQL Server).


==============================================================
2.2.2 Relațiile de dependență — DUPĂ paragraful cu lista relațiilor
==============================================================

Configurarea relațiilor prin EF Core Fluent API, în locul convențiilor implicite sau al adnotărilor Data Annotations, oferă un control granular asupra comportamentului bazei de date: poate fi specificat cascade delete per relație, rename-ul coloanelor de cheie externă, composite primary keys și indexuri suplimentare pentru optimizarea query-urilor frecvente. Un exemplu concret este indexul compus pe (UserId, StationId) în tabela UserFavorites — acesta accelerează semnificativ query-ul „verifică dacă utilizatorul X a marcat stația Y ca favorit", o operațiune frecventă la afișarea hărții.


==============================================================
FIGURA 2.5 (Arhitectura 3 niveluri) — text DUPĂ figura 2.5
==============================================================

Figura 2.5 ilustrează arhitectura pe trei niveluri a portalului web FuelSmart, vizualizând fluxul de date de la Browser (nivelul de prezentare) prin API-ul ASP.NET Core (nivelul de logică aplicativă) până la SQL Server LocalDB (nivelul de date). Această separare în trei niveluri distincte — prezentare, logică aplicativă și date — este o bună practică arhitecturală consacrată, care asigură independența nivelurilor, facilitează testarea și permite scalarea independentă a fiecărui nivel. În implementarea concretă a proiectului FuelSmart, separarea este clară: fișierele HTML/CSS/JS din wwwroot nu conțin niciun cod de acces la baza de date (totul trece prin API), iar API-ul nu include HTML sau logică de prezentare (toate acestea sunt în wwwroot). Această disciplină arhitecturală asigură mentenanța pe termen lung a codului și posibilitatea înlocuirii oricărui nivel fără a afecta celelalte.


==============================================================
CAPITOL 3 — înainte de 3.1 (după titlul capitolului)
==============================================================

Capitolul al treilea detaliază procesul de realizare efectivă a portalului web FuelSmart, prezentând tehnologiile utilizate, deciziile de implementare și codul sursă relevant pentru principalele componente ale sistemului. Fiecare secțiune tratează o tehnologie sau un modul funcțional distinct, explicând nu doar cum a fost implementat, ci și de ce — motivând deciziile tehnice prin raportare la cerințele sistemului și la bunele practici din industrie. Implementarea a urmat principiul iterativ: a fost construit mai întâi scheletul backend-ului (API cu autentificare), urmat de modelul de date și migrațiile EF Core, și în final paginile frontend, în ordinea priorității cerințelor funcționale critice.


==============================================================
3.1 ASP.NET Core — DUPĂ paragraful existent
==============================================================

Configurarea aplicației în Program.cs urmează modelul minimal API introdus în .NET 6 și consolidat în .NET 8, înlocuind clasa Startup.cs tradițională cu o abordare mai concisă și mai lizibilă. Serviciile sunt înregistrate în containerul de Dependency Injection (DI) al framework-ului prin metoda builder.Services.Add*(), iar middleware-ul este configurat în pipeline-ul HTTP prin metoda app.Use*(). Ordinea middleware-ului este critică: UseAuthentication() trebuie să precede UseAuthorization(), care trebuie să precede MapControllers() — orice deviere de la această ordine poate genera comportamente imprevizibile în autorizare. CORS este configurat permisiv în mediul de dezvoltare (AllowAnyOrigin, AllowAnyMethod, AllowAnyHeader, AllowCredentials) pentru a facilita testarea, urmând să fie restricționat la originile specifice în mediul de producție.


==============================================================
3.2 SQL Server LocalDB și EF Core — DUPĂ paragraful de cod
==============================================================

Schema bazei de date este creată și menținută prin sistemul de migrații al Entity Framework Core. Comanda dotnet ef migrations add InitialCreate generează fișierele de migrație care descriu modificările de schemă în cod C#, iar dotnet ef database update aplică aceste modificări pe instanța LocalDB. Această abordare Code-First elimină necesitatea scrierii manuale a scripturilor SQL DDL și asigură că schema bazei de date este întotdeauna sincronizată cu modelul de date C#. Seeding-ul datelor inițiale — cele 28 de stații reale din Republica Moldova cu coordonatele GPS exacte, prețurile inițiale și credențialele contului Admin (admin@fuelsmart.md / Admin123!) — este realizat în metoda OnModelCreating a ApplicationDbContext, asigurând că baza de date conține date funcționale imediat după prima rulare.


==============================================================
3.3 Securitatea portalului — DUPĂ paragraful existent
==============================================================

Implementarea autentificării prin cookie-uri HttpOnly, în locul alternativei populare JWT Bearer transmis în localStorage, este o decizie de securitate deliberată. Cookie-urile HttpOnly sunt inaccesibile din JavaScript, eliminând vulnerabilitatea principală a JWT-urilor stocate în localStorage față de atacurile XSS (Cross-Site Scripting). Atributul SameSite=Lax al cookie-ului de sesiune protejează împotriva atacurilor CSRF (Cross-Site Request Forgery) în scenariile de navigare normală. Parola nu este stocată niciodată în format text clar în baza de date — ASP.NET Core Identity aplică automat algoritmul PBKDF2 cu salt aleator la înregistrare și verifică hash-ul la autentificare, respectând standardele OWASP pentru stocarea securizată a parolelor.


==============================================================
3.4 Frontend-ul web — DUPĂ paragraful existent
==============================================================

Arhitectura JavaScript a portalului urmează principiul Single Responsibility — fiecare pagină HTML are propriul bloc de cod JavaScript dedicat exclusiv logicii acelei pagini, fără dependențe globale complexe sau framework-uri de state management. Apelurile API utilizează fetch() cu async/await pentru o sintaxă clară și lizibilă, cu gestionarea erorilor prin try/catch și afișarea mesajelor de feedback utilizatorului prin elemente DOM dedicate. Funcțiile sunt structurate pe principiul „un apel fetch per responsabilitate" — funcția loadDashboardStats() apelează /api/Efficiency/Stats, funcția loadFuelLogs() apelează /api/FuelLogs, fiecare gestionând independent starea de loading și erorile. Această granularitate facilitează debugging-ul și permite refactorizarea independentă a oricărei funcționalități fără a afecta restul paginii.


==============================================================
3.5 Google Maps API — DUPĂ paragraful existent
==============================================================

Integrarea Google Maps JavaScript API a necesitat obținerea unui API Key din Google Cloud Console și restricționarea acestuia la HTTP referrer-ul specific al aplicației (localhost:5064 în mediul de dezvoltare), prevenind utilizarea neautorizată a cheii. Harta este inițializată cu centrul pe coordonatele Chișinăului (47.0245, 28.8322) și zoom level 8, care permite vizualizarea simultaneă a majorității celor 28 de stații din întreaga Republică Moldova. Marker-ele personalizate utilizează iconițe SVG colorate în funcție de rețeaua de distribuție (Petrom, Bemol, Lukoil etc.), facilitând identificarea vizuală rapidă a brandurilor preferate de utilizator. InfoWindow-ul (popup-ul) afișat la click pe marker este generat dinamic din datele returnate de API, asigurând că prețurile afișate sunt întotdeauna actuale.


==============================================================
FIGURA 3.1 (Harta map.html) — text DUPĂ figura 3.1
==============================================================

Figura 3.1 ilustrează pagina de hartă (map.html) a portalului FuelSmart, cu un InfoWindow deschis pe stația selectată. Se poate observa structura completă a popup-ului: denumirea stației, adresa exactă și prețurile curente pentru Benzin 95, Motorină și GPL, prezentate clar și ierarhic. Harta utilizează tile-urile standard Google Maps, oferind utilizatorului posibilitatea de a comuta între vizualizarea rutieră, satelitară și hibridă. Filtrele de brand disponibile în bara superioară permit utilizatorului să afișeze exclusiv stațiile rețelei preferate, reducând vizual aglomerarea markerelor în zonele urbane dense. Butonul „Adaugă la Favorite" din popup este funcțional exclusiv pentru utilizatorii autentificați, implementând verificarea sesiunii direct în handler-ul click-ului, fără a necesita reîncărcarea paginii.


==============================================================
3.6 Panoul de Administrare — DUPĂ paragraful existent
==============================================================

Implementarea panoului de administrare a urmat principiul separation of concerns la nivel JavaScript: funcțiile de citire (GET), creare (POST), actualizare (PUT) și ștergere (DELETE) sunt implementate ca funcții JavaScript independente, apelate din handler-ele evenimentelor de click și submit ale interfeței. Validarea datelor este realizată pe două niveluri: la nivel client (JavaScript) pentru feedback instant utilizatorului, și la nivel server (model validation ASP.NET Core) pentru garantarea integrității datelor, indiferent de sursa cererii. Operațiunile de ștergere sunt protejate printr-un dialog de confirmare, prevenind ștergerile accidentale ale datelor critice. Răspunsurile API (HTTP 200 OK, 400 Bad Request, 404 Not Found) sunt gestionate explicit în cod, cu afișarea mesajelor de eroare relevante pentru operatorul admin.


==============================================================
FIGURA 3.2 (Admin panel) — text DUPĂ figura 3.2
==============================================================

Figura 3.2 prezintă panoul de administrare (admin.html) cu lista stațiilor de alimentare și butoanele de acțiune asociate. Interfața urmează convențiile standard de design pentru panouri administrative: tabel cu rânduri alternante pentru lizibilitate, butoanele de acțiune grupate în ultima coloană și un header cu acțiunile globale (Adaugă stație nouă). Câmpurile de editare inline permit modificarea denumirii și adresei stației direct în tabel, fără a deschide un formular separat, reducând numărul de interacțiuni necesare pentru operațiunile frecvente. Butonul Delete este stilizat în roșu (convențional pentru acțiuni distructive) și necesită confirmare explicită înainte de execuție, conform bunelor practici de UX pentru prevenirea erorilor operatorului.


==============================================================
3.7 Swagger și testarea API — DUPĂ paragraful existent
==============================================================

	


==============================================================
CAPITOL 4 — înainte de 4.1 (după titlul capitolului)
==============================================================

Capitolul al patrulea documentează produsul finalizat al portalului web FuelSmart, prezentând interfețele grafice ale fiecărei pagini, fluxurile de utilizare și analiza funcționalităților implementate raportate la cerințele inițiale. Documentarea produsului realizat servește un dublu scop: pe de o parte, confirmă că toate cerințele funcționale și non-funcționale au fost implementate și verificate; pe de altă parte, constituie manualul de utilizare al portalului pentru utilizatorii finali și ghidul de referință pentru viitorii dezvoltatori care vor continua sau extinde proiectul. Capturile de ecran prezentate în acest capitol au fost realizate pe instanța locală a aplicației, cu date reale de test introduse prin seeding-ul EF Core și prin testarea manuală a fluxurilor de utilizare.


==============================================================
4.1 Funcțional general — DUPĂ paragraful introductiv
==============================================================

Navigarea între paginile portalului este asigurată de o bară de navigare persistentă, prezentă pe toate paginile post-autentificare, care afișează linkurile spre modulele principale: Dashboard, Hartă, Jurnal, Eficiență, Favorite și (condiționat, pentru Admin) Administrare. Bara de navigare afișează și identitatea utilizatorului autentificat (email sau prenume) și butonul de deconectare. Responsivitatea interfeței — testată pe rezoluții de la 1920×1080 (desktop) la 375×812 (iPhone SE) — este asigurată prin CSS Grid și Flexbox, cu breakpoint-uri la 768px și 1024px, garantând utilizabilitatea pe orice dispozitiv fără a necesita instalarea unui client nativ.


==============================================================
FIGURA 4.1 (login.html) — text DUPĂ figura 4.1
==============================================================

Figura 4.1 prezintă pagina de autentificare (login.html) a portalului FuelSmart. Design-ul urmează principiul minimalismului funcțional: formularul este centrat pe ecran, cu un singur obiectiv vizual — autentificarea utilizatorului. Câmpurile de input au placeholder-uri descriptive și validare HTML5 (type=email pentru câmpul de email, required pentru ambele câmpuri), oferind feedback imediat utilizatorului fără a necesita submit-ul formularului. Butonul „Autentifică-te" este dezactivat în timpul cererii HTTP (prevenind submit-uri multiple) și reactivat la primirea răspunsului, indiferent de succes sau eroare. Linkul spre pagina de înregistrare (Înregistrează-te) permite utilizatorilor noi să creeze un cont fără a fi nevoie să revină la o pagină de start, menținând fluxul de utilizare lin și intuitiv.


==============================================================
FIGURA 4.2 (Dashboard carduri) — text DUPĂ figura 4.2
==============================================================

Figura 4.2 prezintă secțiunea de carduri cu statistici a dashboard-ului principal (index.html). Cele patru carduri principale afișează informațiile esențiale despre activitatea utilizatorului: numărul total de alimentări înregistrate, suma totală cheltuită pe combustibil în MDL, consumul mediu calculat în litri per 100 de kilometri și costul mediu per kilometru. Fiecare card are o iconă reprezentativă și un gradient de culoare distinct, facilitând identificarea vizuală rapidă a metricii dorite. Valorile sunt calculate pe server de EfficiencyController pe baza tuturor înregistrărilor din jurnalul utilizatorului autentificat, garantând că statisticile sunt personalizate și nu includ datele altor utilizatori.


==============================================================
FIGURA 4.3 (Dashboard ultimele alimentări) — text DUPĂ figura 4.3
==============================================================

Figura 4.3 prezintă secțiunea inferioară a dashboard-ului, care afișează ultimele alimentări înregistrate și lista stațiilor favorite ale utilizatorului. Tabelul de alimentări recent afișează data, stația, numărul de litri și costul fiecărei alimentări în ordine cronologică inversă (cele mai recente prima), permițând utilizatorului să verifice rapid corectitudinea ultimelor înregistrări. Secțiunea de favorite afișează carduri compact pentru fiecare stație marcată ca preferată, cu denumirea și prețul curent al benzinei 95 — cel mai relevant indicator pentru decizia de alimentare. Un buton quick-access „Adaugă alimentare" plasat în colțul superior-dreapta permite înregistrarea rapidă a unei noi alimentări direct din dashboard, fără navigarea la pagina dedicată.


==============================================================
FIGURA 4.4 (Harta vedere generală) — text DUPĂ figura 4.4
==============================================================

Figura 4.4 prezintă pagina de hartă (map.html) în vederea generală, cu toate cele 28 de markere ale stațiilor de alimentare vizibile simultan pe harta Republicii Moldova. Distribuția geografică a markerelor reflectă realitatea rețelei de distribuție combustibili din țară: concentrare mai mare în Chișinău și municipiile principale (Bălți, Cahul, Tiraspol), cu stații individuale în localitățile de-a lungul axelor rutiere principale. Clustering-ul automat al markerelor, activat la nivel de zoom scăzut, previne suprapunerea vizuală în zonele dense și se dezactivează automat la zoom crescut, permițând accesarea markerelor individuale. Bara de filtrare din partea superioară a paginii permite filtrarea rapidă după brand, afișând exclusiv markere ale rețelei selectate.


==============================================================
FIGURA 4.5 (Eficiență) — text DUPĂ figura 4.5
==============================================================

Figura 4.5 prezintă pagina calculatorului de eficiență (efficiency.html), cu statisticile de consum calculate pe baza jurnalului de alimentări al utilizatorului. Consumul mediu afișat (l/100km) este calculat prin metoda „full-to-full" — raportul dintre suma litrilor alimentați și suma kilometrilor parcurși între alimentări consecutive, pe baza valorilor odometrului înregistrate. Această metodă, considerată standardul de aur pentru calculul consumului real, elimină erorile introduse de calculele parțiale sau aproximative. Comparația față de media utilizatorilor platformei oferă un benchmark relevant pentru evaluarea eficienței vehiculului propriu în raport cu flota similară din Moldova, motivând adopția unui stil de condus mai economic.


==============================================================
FIGURA 4.6 (Admin formular editare) — text DUPĂ prima figura 4.6
==============================================================

Figura 4.6 prezintă formularul de editare a stației și prețurilor din panoul de administrare (admin.html). Formularul este organizat în două secțiuni logice: datele stației (denumire, adresă, coordonate GPS) și prețurile combustibililor (Benzin 95, Motorină, GPL), cu câmpuri numerice cu precizie de două zecimale pentru prețuri. Câmpurile de coordonate GPS (latitudine, longitudine) sunt pre-populate cu valorile curente ale stației, permițând corecții minore fără a fi nevoie să se introducă manual coordonatele complete. Butonul „Salvează" execută un apel HTTP PUT la /api/Admin/Stations/{id} cu body JSON, iar răspunsul actualizează imediat lista stațiilor din tabel, confirmând vizual succesul operațiunii fără reîncărcarea paginii.


==============================================================
Tabelul 4.1 (Status cerințe) — text DUPĂ tabel
==============================================================

Tabelul 4.1 confirmă implementarea completă a tuturor celor nouă cerințe funcționale critice și importante definite în capitolul 1. Verificarea fiecărei cerințe a fost realizată prin testare manuală sistematică, urmând un script de test predefinit care a acoperit scenariile de succes (happy path) și scenariile de eroare (edge cases): credențiale invalide la autentificare, acces neautorizat la resurse protejate, date invalide în formulare, stații fără prețuri configurate. Toate cerințele non-funcționale — performanță (timp răspuns sub 2 secunde verificat cu DevTools Network tab), securitate (testare XSS și CSRF prin inspecție manuală), compatibilitate (testare în Chrome, Firefox și Edge) — au fost de asemenea verificate și respectate.


==============================================================
FIGURA 4.6 (Lista stații) — text DUPĂ a doua figura 4.6
==============================================================

Figura 4.6 prezintă lista completă a stațiilor de alimentare disponibile în portalul FuelSmart, afișată în pagina de hartă sau în panoul de administrare. Lista cuprinde cele 28 de stații reale din Republica Moldova, cu datele complete: denumire, adresă, coordonate GPS și prețurile actuale per tip de combustibil. Această bază de date a fost constituită prin cercetare directă, verificând coordonatele GPS ale fiecărei stații prin Google Maps și actualizând prețurile conform tarifelor ANRE publicate la data realizării proiectului. Mecanismul de actualizare a prețurilor prin panoul Admin permite mentenanța ușoară a bazei de date pe termen lung, fără a necesita modificări de cod sau reporniri ale serverului.


==============================================================
CONCLUZII — după paragraful „Rezultate obținute" (înainte de Direcții viitoare)
==============================================================

Procesul de dezvoltare al portalului web FuelSmart a generat, pe lângă produsul software propriu-zis, o serie de lecții practice valoroase privind arhitectura sistemelor web moderne. Integrarea frontend-ului HTML5/JS cu un backend ASP.NET Core prin REST API a demonstrat că separarea clară a responsabilităților între niveluri simplifică semnificativ debugging-ul și permite modificarea independentă a oricărui nivel. Sistemul de autentificare prin cookie-uri HttpOnly, deși inițial perceput ca mai complex decât JWT Bearer, s-a dovedit robust și ușor de integrat cu mecanismele native ale browserului. Proiectul confirmă fezabilitatea construirii unui portal web funcțional, sigur și performant utilizând exclusiv tehnologii open-source din ecosistemul Microsoft .NET, fără costuri de licențiere și cu suport oficial pe termen lung din partea Microsoft.
