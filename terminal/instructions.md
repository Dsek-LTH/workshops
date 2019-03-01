## Instruktioner skriver vi här

Plancher
boka idéet?
windows
Ladda hem ett gitrepo, där finns filer
http://www.ee.surrey.ac.uk/Teaching/Unix/

# Uppstart

## Linux

Installera tldr genom att köra `sudo apt-get install tldr` i terminalen

## Windows

Installera följande program:

* Git Bash -> https://git-scm.com/download/win
  När installerna frågar om du vill använda vim eller nano, välj nano. Det är inte hela världen om det blir fel.
* Python -> https://www.python.org/downloads/release/python-372/

Hitta en map där du vill du vill köra projektet i utforskaren, högerklicka och välj "open git bash here"
Vi behöver ett program till, installera det genom att köra `pip install tldr`

# Intro

Längst upp i git bash syns var du är i filsystemet.
För att se vilka filer som finns i mappen du är på. Kör `ls` som står för "list"
Kör `git clone https://github.com/Dsek-LTH/workshops` och kör sen `ls` och se att det finns en ny map som heter workshops.
Tips: att copy/paste:a funkar lite annorlunda i terminalen, använd högerklicka till en början
För att byta map avända kommandot `cd workshops` vilket står för "change directory" och sen var du vill gå.
I mappen workshops hittar du en mapp som heter terminal och gå in i den. (med cd)
Kör `cd .`, vad hände? Var hamnade du nu?
Här finns filen instructions.md, som du just nu läser från använd commandot `less` för att läsa detta.
För att gå ur less tryck `q`
Tips: när du skrivit början att ett filnamn kan du trycka tab så försöker datorn skriva resten åt dig.
Man kan skriva resultat av kommadon till en fil med hjälp av >>-tecknet
Testa `ls >> filer.txt` och titta på resultatet

# Enkla script
Det finns ett program som heter `echo`, vad gör den? Använd `tldr echo` för att läsa mer.
I mappen finns ett enkelt skript (kallat simplescript.sh) detta kan köras genom `bash simplescript.sh`
Öppna filen med nano, du kan spara och avsluta med ctrl+x och sen y + enter.
Med hjälp av kommandona `pwd`, `ls` och `echo` (och `tldr`) gör så att skriptet skriver ditt namn, var skriptet körs ifrån och vilka andra filer som finns där.
Ändra scriptet till att skriva ditt namn till filen, din årskurs, och filerna i den nuvarande mappen.

Testa även att köra joelsbrascript.sh. Om allt går fel tryck ctrl+c för att avbryta.

# Fler kommandon
Med hjälp av tldr, find, grep och wc gör följande uppgifter. (Tips använd . för att referera till mappen du är i)

Hitta 

Med hjälp av tldr, rm, mv, cp, mkdir

# Kommandon och koncept som används i workshoppen

* ls - Lista filer där du är
* cd - Byt mapp (change directory)
* less - Se innehålet i en fil
* pwd - skriver ut var du befinner dig (print working directory)
* tldr och man - Hjälp om kommandon (tldr står för "too long, didn't read")
* echo - Skriver ut till skärmen
* nano - Simpel texteditor
* . - Förkortning som betyder nuvarande mappen.
* .. - Förkortning till mappen ett lager upp.
* \*.txt - Förkortning för alla filer som slutar med .txt
* find - hittar filer
* grep - letar bland filer efter text bland filer
* wc - word count
* rm - remove 
* cp - copy
* alia



 senare
 pipe 
 $1
chmod ./
 ssh till skolan
