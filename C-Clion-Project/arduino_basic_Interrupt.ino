#include "Ardoino.h"


volatile boolean ledOn = false; //volatile! ,

void setup()
{
    pinMode(3, OUTPUT);
    pinMode(2, INPUT);
    attachInterrupt(0, buttonPressed, RISING);  // 0 = 2(iterrupt ID), Executed Function (buttonPressed), RISING = LOW -> HIGH (RISING / FALLING / CHANGE _-_)
    // UNO Accept pin 2, 3 (as 0, 1)
}

void loop()
{

}  //if(digitalRead(2) == HIGH) digitalWrite(3, HIGH);


void buttonPressed() //iterrupt serviece rutine
{ //! DONT Use delay, dont use serial prin, shared variables is volatile, keep it short
    if(ledOn)
    {
        ledOn = false;
        digitalWrite(3, LOW);
    }
    else
    {
        ledOn = true;
        digitalWrite(3, HIGH);
    }

}