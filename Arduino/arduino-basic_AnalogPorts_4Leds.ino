#include "Ardoino.h"


// https://www.tinkercad.com/things/l6uAGtyXG4U

void setup()
{
    pinMode(LED_BUILTIN, OUTPUT);
    //pinMode(0, OUTPUT);
    //pinMode(1, OUTPUT);
    //pinMode(2, OUTPUT);
    //pinMode(3, OUTPUT);
    DDRD= 0B11111111;
    PORTD = 0B00000000;
}

void loop()
{
    int val = analogRead(A0);  // 0 -> 1023
    if(val < 256){
        //digitalWrite(0, LOW);
        //digitalWrite(1, LOW);
        //digitalWrite(2, LOW);
        //digitalWrite(3, HIGH);
        PORTD = 0B00001000;
    } else if(val < 513) {
        //digitalWrite(0, LOW);
        //digitalWrite(1, LOW);
        //digitalWrite(2, HIGH);
        //digitalWrite(3, HIGH);
        PORTD = 0B00001100;
    } else if(val < 769) {
        //digitalWrite(0, LOW);
        //digitalWrite(1, HIGH);
        //digitalWrite(2, HIGH);
        //digitalWrite(3, HIGH);
        PORTD = 0B00001110;
    } else{
        //digitalWrite(0, HIGH);
        //digitalWrite(1, HIGH);
        //digitalWrite(2, HIGH);
        //digitalWrite(3, HIGH);
        PORTD = 0B00001111;
    }
}