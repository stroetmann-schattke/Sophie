
var rl = require('readline-sync');
//const { json } = require('stream/consumers');

let antwort = rl.question('Wie heisst du? ');

console.log('Hallo ' + antwort);

let antw = rl.question('Ich habe mir eine Zahl ausgedacht. An welche denke ich?');

const geheimzahl = Math.floor(Math.random()*100)+1;

 const zahl = parseInt(eingabe,10);

 /*
        if (isNaN(zahl)) {
            console.log("Bitte gib eine gültige Zahl ein");
            return frage();
        } 

        if (zahl < geheimzahl ) {
            console.log("zu klein!");
        } else if (zahl > geheimzahl){
            console.log("zu groß!");
        }else {
            console.log('Erraten! Ich habe mir ${geheimzahl} gedacht') 
            rl.close();
        }
*/





