# Magzayn 2022
1. # Wstęp
    ### Cel projektu
    Aplikacja **Magzayn 2022** jest to narzędzie do zarządzania magazynem.
    Specyfikacja ta jest stworzona przed pracą nad aplikacją opisuje nasze założenia i plany co do aplikacji.
    ### Konwencja Dokumentu
    Brak
    ### Sugestie co do treści
    Klient powinien przeczytać sekcje 1 oraz 2, aby upewnić się co do ogólnych założeń projektu.
    Programiści powinni przeczytać cały dokument, aby zrozumieć o co w projekcie chodzi oraz wiedzieć jakie technologie zostały użyte, ale powinni skupić się na sekcja 3, 4, 5.

    
1. # Ogólny opis
    ### Możliwości
    Aplikacja będzie pozwalać pracownikowi na operacje takie jak: drukowanie wybranych etykiet, lokalizowanie paczek w magazynie, zmiania danych adresowych paczki itp. Całość będzie posiadac poziomy dostępu dla poszczególnych pracowników.
    ### Tabela funkcjonalność/dostęp
   Funkcjonalność| Poziom Dostępu 3 |  Poziom Dostępu 2 |  Poziom Dostępu 1
    ---|------------ | ------------- | ----
    Drukowanie etykiet| TAK|TAK|TAK
    Ponowny dodruk etykiety| TAK|TAK|NIE
    Dodrukowywanie listu BLP| TAK|TAK|TAK
    Wyszukiwanie paczek oraz całych zamówień| TAK|TAK|NIE
    Sprawdzanie stanu paczek oraz zamówień| TAK|TAK|NIE
    Interwencje odnośnie paczki/zamówienia |TAK|TAK|NIE
    Sprawdzanie adresu i zamienianie go w kod listu wysyłkowego  |TAK|TAK|NIE
    Sprawdzanie danych przypisanych do paczki/zamówienia| TAK|NIE|NIE
    Historia paczki/zamówienia(zwrot/awizo itp.)| TAK|TAK|TAK
    Zarejestrowanie/aktualizacja paczki/zamówienia |TAK|NIE|NIE
1. # Technologia Wykonania
    Aplikacja zostanie wykonana wykonana przy pomocy technologi .NET Core. Za GUI odpowiadać będzie Windows Presentation Foundation (WPF). Bazą danych oprzemy o technologię T-SQL. Aplikacja łączy się z bazą poprzez technologię Dapper. Testy zostały wykonane w oparciu o framework Nunit oraz FluentAsertion. Organizacja projektu jest oparta o wzorzec Model-View-Controll. 
1. # Wymagania
    ### Funkcjonalne
    * Drukowanie etykiet
    * Wyszukiwanie zamówienia
    * Aktualizacja danych zamówienia
    ### Pozafunkcjonalne
    * Przejrzysty interfejs 
    * Szybkie przełączanie między funkcjami
    * Krótki czas szkolenia
    * Funkcje widoczne w zależności od uprawnień 
    * Dane osobowe widoczne w zależności od uprawnień (Zgodność z RODO)
1. # Schemat bazy danych 
    Schemat będzie na bieżąco uzupełniany w trakcie prac nad projektem.







