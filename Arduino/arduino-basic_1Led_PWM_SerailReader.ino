#include "Ardoino.h"


int ledPin=3;
int SW = 6; // כפתור
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
            analogWrite(ledPin, 1023);
            Serial.println(analogRead(ledPin));
            delay(i*ledOnTime);
            analogWrite(ledPin, 50);
            Serial.println(analogRead(ledPin));
            delay(ledOffTime);
        }
        else{
            analogWrite(ledPin, 0);
        }
    delay(ledOffTime);

}