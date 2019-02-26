void setup()
{
  pinMode(6 , OUTPUT) ; 
  Serial.begin(9600) ; 
} 

void loop()
{
  if(Serial.available() > 0 )
  {
    char x = Serial.read() ;
    if(x == '1')
    {
      digitalWrite(6 , HIGH ) ; 
      Serial.print("Turned ON ! ") ; 
    } 
    if(x == '0' ) 
    {
      digitalWrite(6 , LOW ) ;   
      Serial.print("Turned OFF ! ") ; 
    }
  }
} 
