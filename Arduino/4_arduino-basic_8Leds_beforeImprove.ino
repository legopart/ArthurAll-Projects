
// https://www.tinkercad.com/things/aCAQGJyLKiz

int ledPin[8] = {3, 4, 5, 6, 7, 8, 9, 10};
int SW = 2;


void turnOffAll(){
    for(int i=0; i<=7;++i){ digitalWrite(ledPin[i], LOW); }
}

void turnOnAll(){
    for(int i=0; i<=7;++i){ digitalWrite(ledPin[i], HIGH); }
}

void setup()
{
    pinMode(ledPin[0], OUTPUT);
    pinMode(ledPin[1], OUTPUT);
    pinMode(ledPin[2], OUTPUT);
    pinMode(ledPin[3], OUTPUT);
    pinMode(ledPin[4], OUTPUT);
    pinMode(ledPin[5], OUTPUT);
    pinMode(ledPin[6], OUTPUT);
    pinMode(ledPin[7], OUTPUT);
    pinMode(SW, INPUT);
}

void loop()
{


    if(digitalRead(SW) == HIGH){
        turnOffAll();
        for(int i=0; i<=7;++i){
            digitalWrite(ledPin[i], HIGH);
            delay(1000);
        }
    }


    else{
        turnOnAll();
        delay(1000);
        for(int i=0; i<=7;++i){
            digitalWrite(ledPin[7-i], LOW);
            delay(1000);
        }


    }

}