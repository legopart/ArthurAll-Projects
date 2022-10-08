#include "Ardoino.h"


int ledPin=4;
int SW = 7; // כפתור
int ledOnTime = 1000;
int ledOffTime = ledOnTime;
float f = 4.556;
bool b = true;
String s = "Arthur";
char ch = 'A';


void setup()
{
    pinMode(ledPin, OUTPUT);
    pinMode(SW, INPUT);
    Serial.begin(9600);
}

void loop()
{
    for(int i=1; i<=10;++i)
        if(digitalRead(SW) == HIGH){
            digitalWrite(ledPin, HIGH);
            Serial.println(digitalRead(ledPin));
            delay(i*ledOnTime);
            digitalWrite(ledPin, LOW);
            Serial.println(digitalRead(ledPin));
            delay(ledOffTime);
        }
    delay(ledOffTime);

}