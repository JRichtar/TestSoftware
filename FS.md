# Funkční Specifikace
## Verze 1

Tvorba softwaru ve formě gramatického testu

Jakub Richtár <br/>
richtar.jakub.2018@skola.ssps.cz <br/>
23. 5. 2021

 

* Úvod
  * Účel dokumentu
    * Dokument bude informovat o tvorbě užitečného softwaru, na kterém pracuji v rámci MVOPu ve škole
  * Konvence dokumentu
    * Všechny kritické požadavky budou tučně
* Scénáře
  * Všechny reálné způsoby použití
    * Bude mít použití pro pedagogické, či studijní účely.
  * Typy uživatelských rolí
    1. Role učitel: Vytváří/upravuje testy
    2. Role žák: Vyplňuej testy
  * Vymezení rozsahu
    * Nebude možné v testu vytvořit otevřené otázky
* Celková hrubá architektura 
  * Pracovní tok
    * Po spuštění aplikace bude nutné vytvořit test, po vytvoření testu bude možné test vyplnit a následně zobrazit a uložit výsledky
  * Hlavní moduly
    1. Modul pro vytvoření testu
    2. Modul pro vyplnění testu
    3. Modul pro zhodnocení testu
    4. Modul pro uložení výsledků testu
  * Všechny detaily
    * Obrazovka bude pouze jedna, budou se vyskytovat oznamovací okna např. při zobrazení výsledků. Dále pak okno pro tvoření/úpravu testů. Chybové zprávy se budou vyskytovat zejména při tvorbě/úpravě testů a při vyhodnocování testu. Všechny akce se budou spouštět tlačítky.
