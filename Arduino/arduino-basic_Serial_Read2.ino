// https://www.tinkercad.com/things/0nWSahFXxC7


void setup()
{
    pinMode(3, OUTPUT);
    Serial.begin(9600);
}

void loop()
{
    int a;
    int b;
    float result;

    Serial.println();

    Serial.print("enter the first value...");
    while(!Serial.available());
    a = readSerial();

    Serial.print("enter the second value...");
    while(!Serial.available());
    b = readSerial();

    calculate(a, b);
}

int readSerial()
{
    int i = Serial.parseInt();
    if (i < 1) i = 0;
    Serial.print(i);
    Serial.println();
    return i;
}

int calculate(int a, int b)
{
    float distance = sqrt(a*a + b*b);
    Serial.print("The Distance is");
    Serial.println(distance);
}