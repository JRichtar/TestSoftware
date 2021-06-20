# Specifikace Požadavků
## Verze 2

Tvorba softwaru ve formě gramatického testu

Jakub Richtár <br/>
richtar.jakub.2018@skola.ssps.cz <br/>
20. 6. 2021 - Poslední aktualizace

 

* Úvod
  * Účel dokumentu
    * Dokument bude informovat o tvorbě užitečného softwaru, na kterém pracuji v rámci MVOPu ve škole
  * Konvence dokumentu
    * Důležitost - 1 nejvyšší, 5 nejnižší
    * Všechny kritické požadavky budou tučně
* Celkový popis
  * Funkce
    * Software bude sloužit k ověření znalostí z českého jazyka, z učiva probraného na ZŠ a SŠ. Bude také sloužit k vytváření testů pro ostatní.
  * Uživatelské skupiny
    * Software bude určený primárně pro studenty a učitele ZŠ a SŠ, mohou ho však využít i prarodiče, nebo kdokoli jiný
  * Omezení návrhu
    * Omezení prozatím nejsou
* Požadavky na rozhraní
  * Uživatelská rozhraní
    * V softawaru bude možné vytvořit vlastní test s vlastními otázkami. Zároveň bude možné testy vyplnit a zobrazit výsledky, s možností uložení výsledků.
  * Softwarová rozhraní
    * Software bude vytvořený v aplikaci WPF, v jazyce C#
* Vlastnosti systému
  1. Vyhodnocení testu
    * Důležitost: 1
    * Vstup : všechny odpovězené otázky v testu
    * Akce : odeslání odpovědí tlačítkem Vyhodnotit test
    * Výstup : počet správných/špatných odpovědí 
    * Výstup : chybové hlášení když nebude odpovězená otázka
  2. Zobrazení odpovědí 
    * Důležitost: 2
    * Vstup: Vyhodnocený test  
    * Akce: tlačítkem Zobrazit odpovědi
    * Výstup: správné odpovědi budou označeny zeleně
    * Výstup: špatné odpovědi budou označeny červeně a budou zobrazeny vysvětlivky
  3. Vytvoření/úprava testů
    * Důležitost: 1
    * Vstup: Vytvoření/upravení otázek a odpovědí
    * Akce: tlačítkem Vytvořit/Upravit test
    * Výstup: Test se vytvoří/upraví a zobrazí se v tabulce testů 
   4. Uložení výsledků
    * Důležitost: 3
    * Vstup: Zobrazené odpovědi
    * Akce: tlačítkem Uložit odpovědi
    * Výstup: vyplněný test se uloží
* Nefunkční požadavky
  * Odezva
    * Systém bude poskytovat odezvu do 3s od zadání akce
  * Spolehlivost
    * Systém neskončí s chybou ve více než 1% případů
