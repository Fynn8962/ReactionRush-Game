# Lern-Periode 4
Fynn Huber
20.02.2024 bis 02.04.2024

# Mein Projekt
In diesem Konsolenspiel geht es darum, die Tasten, die angezeigt werden, richtig zu drücken, braucht man zu lang, zählt der Input nicht mehr. Es gibt verschieden Schwierigkeitsgrade, in welchen man unterschiedlich schnell reagieren muss. Der Highscore (welcher für alle Spielmodi derselbe ist) wird in einer .txt Datei gespeichert. Bei Überschreiten des alten Highscores hat man einen neuen Highscore, welcher dann auch den alten Highscore überschreibt.

<img src="https://github.com/Fynn8962/ReactionRush-Game/blob/main/reaction_rush.gif" alt="Gif Reaction-Rush Spiel" width="500" >

<img src="https://github.com/Fynn8962/ReactionRush-Game/blob/main/4JQzNArVdZ.png" alt="Bild Reaction-Rush Menü" width="500" >


# Grob-Planung

&nbsp;

 **Was hatten Sie sich am Ende von LP3 vorgenommen? Was war Ihr VBV? Wie könnten Sie diesen besonders gut üben?**

Ich möchte mehr Routine im Coden an sich erlangen, da ich bis jetzt, nach meiner Meinung noch nicht viel Programmiert habe. 
Dafür befasse ich mich mit Themen wie zum Beispiel dicitionarys und expections.

&nbsp;

&nbsp;

### *20.2.2024*

**Heute habe ich...**

 Meine Grobplanung verfasst, in der ich meine Noten und die VBV der vorherigen LP angeschaut und reflektiert habe. Anschliessend habe über eine neue Tähtigkeit 
nachgedacht welche ich in der LP4 nachgehen möchte. Ich habe mich dann für die vertiefung meiner Routine im Coden entschieden und mir neue Befehle in C# wie auch das lösen von mathematischen Problemen zur Aufgabe gemacht.

&nbsp;

&nbsp;

### *27.2.2024*

- [x] Auflistung mit einem Dicitonary in C# über Auto Modelle.    
- [x] Abfragen der Auflistung  nach z.B Modell oder Baujahr.    
- [x] Veränderung der Auflistung, z.B neues Modell hinzufügen oder altes Löschen.    
- [ ] Probleme 1-3 auf projectuler.net lösen, möglist schön.       

&nbsp;

| Testfall-Nummer | Ausgangslage (Given) |	Eingabe (When) | Ausgabe (Then) | Erfüllt? | 
|-----------------|----------------------|----------------|----------------|----------|
1 | VS geöffnet | new Dictionary<Datentyp>(); | Dicitonary erstellt | x |	   	
2 | Dictionary erstellt | if(dict.Bedingung){ dann das } | ausgabe des Inhalt | x |
3 | Dictionary erstellt | dict.add(Daten) | änderung des Inhalts | x |
4 |		   Project Euler Problemstellung | Code zur Problemlösung | Antwort auf Problem | | 

&nbsp;

 **Heute habe ich...**

Ich habe in VS ein Dictionary über Porsche Modelle erstellt. Anschliessend habe ich ein zweites Dictionary mit PS-Werten erstellt, hierbei habe ich darauf geachtet, dass die Key der jeweiligen Values in den zwei Dictionary übereinstimmen. Das heisst das Modell mit Key = 1 hat den dazugehörige PS-Wert beim zweiten Dictionary auch bei Key = 1. Somit habe ich sozusagen zwei Tabellen die miteinander in verbindung stehen erstellt. Den Code habe ich auf mein repository hochgeladen. Am schluss habe ich mithilfe einer foreach Schleife die alle Werte in den beiden Dictionarys ausgegeben und die jeweilligen Key's zusammengefügt.
Da wir heute nur bis 11:00 Zeit hatten, habe ich das vierte Arbeitspaket nicht bearbeitet. 

&nbsp;

&nbsp;

### *05.03.2024*

- [x] Game in dem man in unterschiendlichen Abständen verschiedene Tasten(z.B Pfeiltasten) drücken muss. (Inspiration: Guitar Hero)
- [x] Wenn man eine falsche taste drückt, oder zu langsam ist, hat man verloren und das Programm soll den Score anzeigen.
- [ ] Verschiedene Schwierigkeitsstufen die ausgewählt werden können.
- [ ] Probleme 1-3 auf projectuler.net lösen, möglist schön.    

&nbsp;

| Testfall-Nummer | Ausgangslage (Given) |	Eingabe (When) | Ausgabe (Then) | Erfüllt? | 
|-----------------|----------------------|----------------|----------------|----------|
| 1 | game gestartet | linke Pfeiltaste | Runde wird vortgesetzt |x |
| 2 | Game gestartet | falsche Pfeiltaste | Runde wird beendet |x |
| 3 | Game Menü | Auswahl leicht, mittel, schwer | Schwierigkeit wird angepasst | |
| 4 |		Project Euler Problemstellung | Code zur Problemlösung | Antwort auf Problem | |

&nbsp;

 **Heute habe ich...**

Ich habe angefangen mein Spiel "PressTheButtons" zu Coden. Bis jetzt  werden fortlaufend zufällige Tasten generiert die man drücken muss, ist man zu langsam , oder hat man die falsche Taste drückt, stopt der Versuch. Da ich Anfangs Schwierigkeiten hatte, wie zum Beispiel das die Zeit richtig gestoppt wird, bin ich nocht nicht Fertig. Nächstes mal will ich das Spiel erneut spielbar machen mithilfe eins Restart Menü, ausserdem soll es einen Punktezähler geben, der zählt wie viel mal die richtige Taste gedrückt worden ist. Falls ich noch genügend Zeit habe, möchte ich noch die Darstellung verschönern. 

&nbsp;

&nbsp;

### *12.03.2024*

- [ ] Verschiedene Schwierigkeitsstufen die ausgewählt werden können (leicht, mittel, schwer).
- [x] Restart Menü, um nochmal  zu Spielen oder um aufzuhören.
- [ ] Punktezähle am Ende des versuchs, der gedrückte Tasten zusammenzählt.
- [x] Anschauliche, Benutzerfreundliche Oberfläche, damit das Spiel mehr Spass macht.

&nbsp;

| Testfall-Nummer | Ausgangslage (Given) |	Eingabe (When) | Ausgabe (Then) | Erfüllt? | 
|-----------------|----------------------|----------------|----------------|----------|
| 1 | game Menü | Auswahl einfach, mittel, schwer | Schwierigkeit wird angepasst | |
| 2 | restart Menü | Auswahl: fortfahren, beenden | Auswahl wird ausgeführt |x |
| 3 | versuch vorbei, (game over) | gedrückte Tasten zusammenzählen | Ausgabe Anzahl gedrückter Tasten | |
| 4 |		game Spielen | Schöne, übersichtliche Darstellung | freude am Spiel |x |

 &nbsp;

 **Heute habe ich...**         

Ich habe zu meinem Game ein restartmenu hinzugefügt, welches ermöglicht nach einen verlorenen Spiel nochmal neu zu spielen. Ausserdem habe ich nachdem man ein Versuch startet einen Countdown eingefügt, damit es nicht so apprupt losgeht. Weitere Anpassungen wie zum Beispiel Zentrieren des Text und ändern der Textfarbe (Beispiel: "GAME OVER" in rot) habe ich zur verschönerung vorgenommen. Zu verstehen wie ich den Text in der Console zentrieren kann hat mir anfangs Probleme bereitet, da es nicht so einfach ist wie ich gedacht habe. Beim nächsten mal möchte ich als erstes die Score Anzeige machen, damit das Spielen mehr Sinn bekommt. Anschliessend noch mehrere Schwierigkeitsmodi um mehr Abwechslung reinzubringen. Am Ende möchte ich noch alles auf mögliche Bugs überprüfen, damit das Spiel auch Benutzerfreundlich ist. (Bsp wenn man im Menü irgendwelche Tasten drückt, dass das Spiel diese nicht falsch interpretiert sondern ignoriert und nur wenn eine Sinngemässe Taste (z.B Start) gedrückt wird, das Programm dann reagiert.)

&nbsp;

&nbsp;

### *19.03.2024*

- [x] Punktezähle am Ende des versuchs, der gedrückte Tasten zusammenzählt.
- [x] Verschiedene Schwierigkeitsstufen die ausgewählt werden können (leicht, mittel, schwer).
- [ ] Durch Debuggen Fehler in meinem Spiel beheben. (z.B in- output fehler)
- [ ] Mein Spiel als .exe Datei auf meinen Desktop verknüpften und mit einem Logo versehen. (z.B  Taste(n) der Tastatur als Symbol)

&nbsp;

| Testfall-Nummer | Ausgangslage (Given) |	Eingabe (When) | Ausgabe (Then) | Erfüllt? | 
|-----------------|----------------------|----------------|----------------|----------|
| 1 | versuch vorbei, (game over) | gedrückte Tasten zusammenzählen | Ausgabe Anzahl gedrückter Tasten | x |
| 2 | game Menü | Auswahl einfach, mittel, schwer | Schwierigkeit wird angepasst | x |
| 3 | Spiel spielen | zufällige Tasten drücken | nichts | |
| 4 | Lust zum Spielen | Doppelklick auf Desktop-Icon | Spiel öffnet sich | |

 &nbsp;

 **Heute habe ich...**   
 
 Als erster habe ich eine score Anzeige hinzugefügt, die keine grossen Probleme gemacht hat und auch einwandfrei funktioniert. Anschliessend wollte ich kleine Bugs fixen, was aber doch mehr Probleme gemacht hat als gedacht. Ich habe nach langem Probieren mich dazu entschieden, mit der Schwierigkeitsauswahl anzufangen, um nicht Zeit zu verschwenden. Die 4 Schwierigkeitsstufen die ich erstellt habe waren schnell und einfach gemacht. Bei der Einfachsten hat man nun 2 Sekunden zum reagieren und bei der schwierigsten 
0.5 Sekunden. Zum Debuggen bin ich danach leider nicht mehr gekommen, heisst ich werde nächstes mal noch alle Fehler beheben und dann das Spiel abschliessen.
Ich habe den Code des Games hochgeladen, jedoch enthält dieser wie gesagt noch kleine Bugs.)
 
&nbsp;

&nbsp;

### *26.03.2024*

- [x] Durch Debuggen Fehler in meinem Spiel beheben. (z.B in- output fehler)
- [x] Mein Spiel als .exe Datei auf meinen Desktop verknüpften und mit einem Logo versehen. (z.B  Taste(n) der Tastatur als Symbol)
- [ ] Modul 117 an der Dokumentation arbeiten. (neue Inhalte die hinzuzufügen sind vom Freitag 22.03, dokumentieren.)
- [ ] Werte aus einem VS-Programm in einer .txt Datei speichern (um z.B Spielstände zu speichern)
      
&nbsp;

| Testfall-Nummer | Ausgangslage (Given) |	Eingabe (When) | Ausgabe (Then) | Erfüllt? | 
|-----------------|----------------------|----------------|----------------|----------|
| 1 | Spiel spielen | zufällige Tasten drücken | nichts | x |
| 2 | Lust zum Spielen | Doppelklick auf Desktop-Icon | Spiel öffnet sich | x |
| 3 |Vorgabe was Dokumentiert werden soll | Dokumentieren | Falls nötig abgeben auf Moodle | |
| 4 | z.B neuer Highscore | Speichere unter "Pfad\.txt" | Wert gespeichert | |

 &nbsp;

 **Heute habe ich...** 
 
Ich habe Fehler in meinem Spiel behoben, damit es nun Spielbar ist. Ein Bug hat mich sehr lange aufgehalten da ich auch durch Debugen nicht heraufinden konnte, wo der Fehler war. Schlussentlich konnte ich das Problem jedoch beheben, indem ich einen Teil des Codes umgeschrieben habe. Da es immmernoch möglich wäre, dass Fehler entdeckt werden habe ich hinzugefügt, dass sich das Spiel in der BETA befindet. Ausserdem habe ich noch weitere Ideen die ich villeicht abseits des Lern-Ateliers noch hinzufügen/abändern werde. 
Nachdem ich mit der Funktion des Spiels zufrieden war habe ich noch das Code Layout ein bischen verschöndert und unnötige Abstände gelöscht. Damit ich mein Spiel auch spielen kann habe ich dan eine Verknüpfung erstellt die ich auf meinem Desktop gezogen habe. Nun kann man das Spiel ohne den Visual Stuido zu starten direkt spielen.
  
&nbsp;

&nbsp;

### *02.04.2024*

- [x] Modul 187 an der Dokumentation arbeiten. (neue Inhalte die hinzuzufügen sind vom Freitag 22.03, dokumentieren.)
- [x] Werte aus einem VS-Programm in einer .txt Datei speichern (um z.B Spielstände zu speichern)
- [ ] Das gelernte aus Arbeitspaket 2 auf mein Spiel das ich gemacht habe anwenden. Somit können dann Highscores gespeichert werden.
      
&nbsp;

| Testfall-Nummer | Ausgangslage (Given) |	Eingabe (When) | Ausgabe (Then) | Erfüllt? | 
|-----------------|----------------------|----------------|----------------|----------|
| 1 |Vorgabe was Dokumentiert werden soll | Dokumentieren | Falls nötig abgeben auf Moodle |x|
| 2 | z.B neuer Highscore | Speichere unter "Pfad\.txt" | Wert gespeichert |x|
| 3 | Neuer Highscore in ReactionRush | überschreibt Wert in .txt Datei  | neuer Highscore gespeichert |  |

 &nbsp;

 **Heute habe ich...**                       
 Ich habe für das Modul 187 zwei neue Einträge in die Dokumentation geschrieben zum Thema Systemsicherheit und zum Thema Virtuelle Maschine. Anschliessend habe ich versucht herauszufinden wie man einen Wert in einer .txt Datei speichert. In der Art wie ich es brauche war es sehr leicht zu verstehen, da ich immer nur einen int Wert (den Highscore) hinenschreibe/speichern möchte und wenn ein neuer Highscore erspielt wird, wird der alte einfach überschrieben. Für das implementieren des Codes in mein Spiele blieb mir leider keien Zeit mehr.
 
### Reflexion
Ich habe mir in de Letzten LP vorgenommen mehr Routine im Coden zu erlangen und neue Sachen zu lernen. Diese habe ich meiner, wie ich finde, gut umsetzten können. ich habe zwie kleinere "Spiele" programmiert mit denen ich sehr zufrieden bin. Ausserdem wollte ich Projekte machen bei denen ich nicht nach zwei Sitzungen schon fertig bin, was mir auch gelungen ist. Ich habe durch diese Arbeitspakete neue Techniken und Denkweisen kennengelernt. Mit meiner Arbeitsweise bin ich sehr Zufrieden. Ich habe immer gewusst was zu tuhen ist durch meine Arbeitspackete, zeitlich gab es manchmal kleine Probleme aber ich konnt meisten gut im Zeitplan bleiben. 

In der LP5 als Abschluss würde ich gerne entweder ein Spiel in z. B. (Unity) programmieren oder mich mit HTML beschäftigen und eine Website, mit z.B Info's über mich, erstellen. Das heisst in der LP5 möchte ich mich gerne mit etwas grossem beschäftigen damit ich am Schluss etwas in der Hand habe was mir sehr gefällt. 
Fazit: Ich möchte mir in der nächsten LP5 etwas neues beibringen (bsp. Unity, HTML) und anhand des erlenten dann ein Projekt erstellen das für mich am Schluss Perfekt sein soll ohne Fehler oder unreinheiten. 

### *19.04.2024*
Nach dem Abschluss der LP4 habe ich mein Spiel nochmal verändert und dann doch noch die Highscore Anzeige und das Speichers des Highscores hinzugefügt. Das Speichern und auslesen des Highscores war keine grosse Sache. Am Schluss habe ich noch die neue Highscore anzeige schön in den Rest der Benutzeroberfläche integriergt und bin nun zufrieden mit dem kleinen "Game". Den Code habe im jetztigen zustand Hochgeladen.
