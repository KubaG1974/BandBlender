# Band Blender

Band Blender to platforma stworzona dla muzyków, umożliwiająca im kontakt, współpracę przy projektach muzycznych oraz eksplorację nowych możliwości w świecie muzyki. Projekt skupia się na łatwym i efektywnym tworzeniu zespołów, wymianie pomysłów oraz organizowaniu wspólnych sesji.

## Funkcje

- **Rejestracja i logowanie**: Użytkownicy mogą utworzyć konto lub zalogować się za pomocą swoich danych.
- **Profil użytkownika**: Każdy użytkownik ma swój profil, gdzie może dodawać informacje o sobie, umieszczać linki do swoich utworów i prezentować swoje umiejętności.
- **Wyszukiwanie użytkowników i zespołów**: Użytkownicy mogą przeglądać profile innych użytkowników oraz zespołów i nawiązywać kontakt.
- **Tworzenie zespołów**: Użytkownicy mogą tworzyć zespoły muzyczne, dodawać członków i wspólnie pracować nad projektami.
- **Wymiana plików muzycznych**: Zespoły mogą wymieniać się nagraniami, nutami i innymi plikami muzycznymi.
- **Harmonogram sesji**: Możliwość planowania sesji, prób i koncertów oraz synchronizacji kalendarza między członkami zespołu.

## Technologie

- **Backend**: Zbudowany w języku C# przy użyciu frameworku ASP.NET Core.
- **Frontend**: Wykorzystuje bibliotekę React.js do budowy interfejsu użytkownika.
- **Baza danych**: PostgreSQL.

## Instalacja

1. Sklonuj repozytorium: `git clone https://github.com/TWOJA_NAZWA_UŻYTKOWNIKA/band-blender.git`
2. Przejdź do katalogu projektu: `cd band-blender`
3. Zainstaluj zależności backendowe: `dotnet restore`
4. Przejdź do katalogu klienta: `cd ClientApp`
5. Zainstaluj zależności frontendowe: `npm install`

## Konfiguracja bazy danych

1. Utwórz nową bazę danych PostgreSQL.
2. W pliku `appsettings.json` ustaw connection string dla bazy danych.

## Uruchomienie

1. Przejdź do katalogu głównego projektu: `cd ..`
2. Uruchom backend: `dotnet run`
3. W osobnym terminalu przejdź do katalogu klienta: `cd ClientApp`
4. Uruchom frontend: `npm start`

## Użycie

Po uruchomieniu projektu możesz przejść do przeglądarki i otworzyć stronę `http://localhost:3000/`, aby korzystać z aplikacji Band Blender.

## Licencja

Ten projekt jest objęty licencją MIT. Szczegółowe informacje można znaleźć w pliku LICENSE.

## Kontakt

Jeśli masz pytania lub sugestie dotyczące projektu, możesz się ze mną skontaktować poprzez e-mail: kuba@starweb.pl.

