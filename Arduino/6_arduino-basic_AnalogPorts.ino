
// https://www.tinkercad.com/things/jGtedu9obdG

void setup()
{
    pinMode(LED_BUILTIN, OUTPUT);
    //pinMode(A0, INPUT);
    Serial.begin(9600);
}


int val;
void loop()
{
    val = analogRead(A0);  // 0 -> 1023
    Serial.println(val);
    delay(100);
    if(val > 513){
        digitalWrite(13, HIGH);
    } else {
        digitalWrite(13, LOW);
    }
}