String s = "";

void setup() {
  Serial.begin(9600);
  Serial.println("Hello World");
  Serial.println("I am Aung Win Htut");
  Serial.println("*********************");
  Serial.println("Enter R ");
}

void loop() {

  
  while (!Serial.available() ) {
  }
  while (Serial.available() > 0)
  {
    char ch = Serial.read();
    if (ch != '\n')
    {
      //Serial.print(ch);
      s += ch;
    }
    else {
      Serial.print(s);
      float r = s.toFloat();
      float a = 3.14 * r * r;
      Serial.print("Area = ");
      Serial.println(a);
      s = "";
      r = 0;
      a = 0;
      
    }
  }

}

void funArea()
{
  float a, r;
  r = 20;
  a = 3.14 * r * r;
  Serial.print("Area = ");
  Serial.println(a);
}
