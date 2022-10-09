
// https://www.tinkercad.com/things/aCAQGJyLKiz




void setup()
{
    //pinMode(ledPin[0], OUTPUT);
    //...
    //pinMode(ledPin[7], OUTPUT);
    DDRD= 0xff;//0B11111111 all pins set as output
    // 0B000000000 will mean that all the pins input.
    PORTD = 0x0; //0B00000000
}

const int delayDefault = 1000;
const void delaySet(int i = delayDefault) { delay(i); }	//to review
byte a;

void loop()
{
    a = 0x0; //0B00000000
    PORTD = a;
    delaySet();

    a |= 0B1; //0B00000001
    for(int i=0; i<=7;++i){
        PORTD |= a;
        a = a << 1;
        delaySet();
    }

    a = 0xff;//0B11111111;
    PORTD = a;
    delaySet();
    for(int i=0; i<=7;++i){
        a = a >> 1;
        PORTD &= a;
        delaySet();
    }

}

// להוסיף סוויטץ