#include <Keypad.h>

const byte rows = 4; //four rows
const byte cols = 4; //three columns
char keys[rows][cols] = {
  {'1','2','3', '+'},
  {'4','5','6', '-'},
  {'7','8','9', 'x'},
  {'A','0','=', '/'}
};
byte rowPins[rows] = {11, 10, 9, 8}; //connect to the row pinouts of the keypad
byte colPins[cols] = { 7, 6, 5, 4}; //connect to the column pinouts of the keypad
Keypad keypad = Keypad( makeKeymap(keys), rowPins, colPins, rows, cols );

char key;

void setup() 
{
  Serial.begin(9600);
}


    /* serialEvent()
Description
Called when data is available. Use Serial.read() to capture this data.

NB : Currently, serialEvent() is not compatible with the Esplora, Leonardo, or Micro

Syntax
*/

void loop() 
{
  key = keypad.getKey();
    if (key!=NO_KEY)
        {
          Serial.print(key);
          if(key == '=' || key == 'A' )
          {
            Serial.println();
          }
        }
}
/*void serialEvent() 
{
  while (Serial.available()) 
  {
    key = keypad.getKey();
    if (key!=NO_KEY)
        {
          Serial.println(key);
        }
  }
}*/
  
