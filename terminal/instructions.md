# Uppstart

## Linux

Installera tldr genom att köra `sudo apt-get install tldr` i terminalen

## Windows

Installera följande program:

* Git Bash -> https://git-scm.com/download/win
  När installerna frågar om du vill använda vim eller nano, välj nano. Det är inte hela världen om det blir fel.
* Python -> https://www.python.org/downloads/release/python-372/
    - klicka i 'add python environmental variables'

Hitta en map där du vill du vill köra projektet i utforskaren, högerklicka och välj "open git bash here"

Vi behöver ett program till, installera det genom att köra `pip install tldr`

# Intro

Längst upp i git bash syns var du är i filsystemet.

För att se vilka filer som finns i mappen du är på. Kör `ls` som står för "list"

Kör `git clone https://github.com/Dsek-LTH/workshops` och kör sen `ls` och se att det finns en ny map som heter workshops.

Tips: att copy/paste:a funkar lite annorlunda i terminalen, använd högerklicka till en början

För att byta map avända kommandot `cd workshops` vilket står för "change directory" och sen var du vill gå.

I mappen workshops hittar du en mapp som heter terminal och gå in i den. (med cd)

Här finns filen instructions.md, som du just nu läser från använd commandot `less` för att läsa detta.

För att gå ur less tryck `q`

Tips: när du skrivit början att ett filnamn kan du trycka tab så försöker datorn skriva resten åt dig.

Man kan skriva resultat av kommadon till en fil med hjälp av >>-tecknet

Testa `ls >> filer.txt` och titta på resultatet. Det är vanligt i linux att skapa filer automatiskt om de inte finns.

Man kan även lägga till så kallade "flaggor" för att ändra hur ett kommando fungerar. Flaggan '-a' för tex att ls visar gömda filer. (hela kommandot blir då `ls -a`)

# Enkla script

Det finns ett program som heter `echo`, vad gör den? Använd `tldr echo` för att läsa mer.

I mappen finns ett enkelt skript (kallat simplescript.sh) detta kan köras genom `bash simplescript.sh`

Öppna filen med `nano`, du kan spara och avsluta med ctrl+x och sen y + enter.

Med hjälp av kommandona `pwd`, `ls` och `echo` (och `tldr`) gör så att skriptet skriver ditt namn, var skriptet körs ifrån och vilka andra filer som finns till en fil.

Ändra scriptet till att skriva ditt namn till filen, din årskurs, och filerna i den nuvarande mappen.

Testa även att köra joelsbrascript.sh. Om allt går fel tryck ctrl+c för att avbryta.

# Fler kommandon

Med hjälp av tldr, find, grep, sort och wc (word count) gör följande uppgifter. (Tips använd . för att referera till mappen du är i och \* för alla filer i mappen du är i. Med uttrycket root path eller likandne menas en mapp helt enkelt)

* Det finns en mapp som heter filer, och där finns en massa skräp. Bland skräpet finns hemlig information i en fil som heter "hemlisar"! Hitta hemlisarna.
* I mappen filer finns filen uttryck.txt. Hur många utryck finns där? (en per rad)
* Hitta alla gåtor som har ordet "You" i sig. (glömd inte stora bokstäver)
* Utrycken ligger i oordning :( skapa en ny fil där de är i ordning! :D

* Någonstanns finns en map som heter "böcker", hitta denna. (tips, en av böckerna heter dracula.txt)
* Hur många gånger nämns "whale" i moby dick?
* Skapa en sorterad lista av böcker efter ordlängd.
* Hur många filer som slutar med .txt finns det totalt i mappen "filer"?

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
* mv - move
* mkdir - make directory
* alias
