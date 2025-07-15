// Zahlenspiel 

const programName = "Zahlenspiel";

// Hilfs-Modul einbinden
var rl = require('readline-sync');

// Geheimzahl erstellen
const geheimzahl = Math.floor(Math.random()*100)+1;

//Anfang des Spiels
console.log('Hallo!');
console.log("Ich habe mir eine Zahl von 1-100 ausgedacht.");

// Funktion 1-100 erraten 
function frage() {
    let eingabe = rl.question("Rate meine Zahl: ");  // Frage 
     
        const zahl = parseInt(eingabe,10);

        if (isNaN(zahl)) { // keine gültige Eingabe
            console.log("Bitte gib eine gültige Zahl ein");
            return false;
        } 

        if (zahl < geheimzahl ) {  // Falsche Antwort Zahl ist zu klein
            console.log("zu klein!");
            return false;
        } else if (zahl > geheimzahl){  // Falsche Antwort Zahl ist zu groß
            console.log("zu groß!");
            return false;
        }else {
            console.log('Erraten! Ich habe an ' + geheimzahl + ' gedacht'); // Richtige Antwort
            return true;
        }
    
}


while(!frage()) {}

// Ende des Spiels 
console.log('ACHTUNG:Glücksspiel macht süchtig')




