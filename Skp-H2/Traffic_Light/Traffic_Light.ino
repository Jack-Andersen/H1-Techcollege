#include <Wire.h>
#include <LiquidCrystal_I2C.h>

#include "Traffic_Light.h"
#include "Display.h"


// Traffic_Light
// declare pins
int greenLeft = 4;
int yellowLeft = 3;
int redLeft = 2;
int greenTop = 7;
int yellowTop = 6;
int redTop = 5;
int greenRight = 10;
int yellowRight = 9;
int redRight = 8;
int greenBot = 13;
int yellowBot = 12;
int redBot = 11;

TrafficLight trafficLight(greenLeft, yellowLeft, redLeft, false);
TrafficLight trafficLight2(greenTop, yellowTop, redTop, true);
TrafficLight trafficLight3(greenRight, yellowRight, redRight, false);
TrafficLight trafficLight4(greenBot, yellowBot, redBot, true);


// Display

Display Display;


void setup() {
  lcd.begin(20,4);
  lcd.clear();
}  // end of setup

void loop() {
// here you can change which lights turn on when and for how long

  //Stage 1
  //Left/Right = Green and Bot/Top = Red
  lcd.clear();
  Display.DisplayStart();
  Display.GoLeftRight();
  Display.StopBotTop();
  trafficLight.Green();
  trafficLight2.RedReverse();
  trafficLight3.Green();
  trafficLight4.RedReverse();
  delay(5000);

  //Stage 2
  //Left/Right = Yellow
  trafficLight.Yellow();
  trafficLight3.Yellow();
  delay(1000);
  //Left/Right = Red
  lcd.clear();
  Display.DisplayStart();
  Display.StopLeftRight();
  Display.StopBotTop();
  trafficLight.Red();
  trafficLight3.Red();
  delay(2000);
  //Bot/Top = Red And Yellow
  trafficLight2.RedAndYellowReverse();
  trafficLight4.RedAndYellowReverse();
  delay(2000);

  //Stage 3
  //Left/Right = Red and Bot/Top = Green
  lcd.clear();
  Display.DisplayStart();
  Display.StopLeftRight();
  Display.GoBotTop();
  trafficLight.Red();
  trafficLight2.GreenReverse();
  trafficLight3.Red();
  trafficLight4.GreenReverse();
  delay(5000);

  //Stage 4
  //Bot/Top = Yellow
  trafficLight2.YellowReverse();
  trafficLight4.YellowReverse();
  delay(1000);
  //Bot/Top = Red
  lcd.clear();
  Display.DisplayStart();
  Display.StopLeftRight();
  Display.StopBotTop();
  trafficLight2.RedReverse();
  trafficLight4.RedReverse();
  delay(2000);
  //Left/Right = Red And Yellow
  trafficLight.RedAndYellow();
  trafficLight3.RedAndYellow();
  delay(2000);

}
