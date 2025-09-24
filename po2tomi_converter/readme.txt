Program ma za zadanie dokonać konwersji pliku .po, obsługiwanego przez OmegaT, do odszyfrowanych plików .txt niezbędnych do wgrania przetłumaczonego tekstu do gry. 
Link do releasu: https://github.com/tirey93/mi3pl/releases/tag/po2_tab_converter

Konfiguracja programu
Plik konfiguracyjny appsettings.json zawiera w sobie elementy niezbędne do poprawnego działania programu. Poniżej opis elementów:

Mode - Dostępne opcje: FromPo, ToPo Domyślnie FromPo. W przypadku normalnego użytkowania programu nie należy tej flagi zmieniać. Jeśli z jakiegoś powodu niezbędne będzie działanie programu w sposób odwrotny(tj. z odszyfrowanych plików gry wygenerować plik .po) to wtedy należy tę wartość ustawić na ToPo.
PoFileLocation - Lokalizacja pliku .po utworzonego w OmegaT z katalogu target. Najlepiej ustawić sobie dokładną ścieżkę do projektu OmegaT/target/mi3pl.po a program będzie czytał dane z pliku .po od razu po zapisaniu w OmegaT.
EngFileLocation - Lokalizacja pliku angielskiego. Znajduje się on w repozytorium w katalogu skrypty/steam/en/LANGUAGE.TAB.TXT. Najwygodniej jest sobie ustawić ścieżkę do tego miejsca i zapomnieć o sprawie. W przypadku trybu FromPo ścieżki te nie są wymagane.
PlFileLocation - Lokalizacja odszyfrowanego pliku polskiego. Znajduje się on w repozytorium w katalogu skrypty/steam/pl/LANGUAGE.TAB.TXT. Najwygodniej jest sobie ustawić ścieżkę do tego miejsca i zapomnieć o sprawie. 