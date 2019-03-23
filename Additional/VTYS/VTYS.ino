#include <RFID.h>
#include <SPI.h>

#define sda 10
#define reset 9

int i = 0;
RFID rfid(sda,reset); //SDA,RESET

void setup() {
  
  Serial.begin(9600);
  SPI.begin();
  rfid.init();
}

void loop() {
    
if(rfid.isCard())
  {
    if(rfid.readCardSerial())
    {
      Serial.print(rfid.serNum[0]);
      Serial.print(rfid.serNum[1]);
      Serial.print(rfid.serNum[2]);
      Serial.print(rfid.serNum[3]);
      Serial.println(rfid.serNum[4]);
  
    }
  }
  rfid.halt();

delay(1000);
  
}
