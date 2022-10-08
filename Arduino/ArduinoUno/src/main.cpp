#include <Arduino.h>

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
    // write your initialization code here
    pinMode(ledPin, OUTPUT);
    pinMode(SW, INPUT);
}

void loop()
{
    // write your code here
    for(int i=1; i<=10;++i)
        if(digitalRead(SW) == HIGH){
            digitalWrite(ledPin, HIGH);
            delay(i*ledOnTime);
            digitalWrite(ledPin, LOW);
            delay(ledOffTime);
        }
    delay(1000);

}