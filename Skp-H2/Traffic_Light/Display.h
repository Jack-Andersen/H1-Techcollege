LiquidCrystal_I2C lcd(0x27, 2, 1, 0, 4, 5, 6, 7, 3, POSITIVE);

class Display {


public:
  void DisplayStart() {
    lcd.setCursor(1,0);
    lcd.print("Left/Right");
    lcd.setCursor(12,0);
    lcd.print("Bot/Top");
  }

  void GoLeftRight(){
    lcd.setCursor(5,2);
    lcd.print("Go");
  }

  void GoBotTop(){
    lcd.setCursor(14,2);
    lcd.print("Go");
  }

  void StopLeftRight(){
    lcd.setCursor(4,2);
    lcd.print("Stop");
  }

  void StopBotTop(){
    lcd.setCursor(13,2);
    lcd.print("Stop");
  }
};
//void thumbsUpLeftRight() {
  //byte thumbUp1[8] = {B00100,B00011,B00100,B00011,B00100,B00011,B00010,B00001};
  //byte thumbUp2[8] = {B00000,B00000,B00000,B00000,B00000,B00000,B00000,B00011};
  //byte thumbUp3[8] = {B00000,B00000,B00000,B00000,B00000,B00000,B00001,B11110};
  //byte thumbUp4[8] = {B00000,B01100,B10010,B10010,B10001,B01000,B11110,B00000};
  //byte thumbUp5[8] = {B00010,B00010,B00010,B00010,B00010,B01110,B10000,B00000};
  //byte thumbUp6[8] = {B00000,B00000,B00000,B00000,B00000,B10000,B01000,B00110};
  //lcd.createChar(0, thumbUp1);
  //lcd.createChar(1, thumbUp2);
  //lcd.createChar(2, thumbUp3);
  //lcd.createChar(3, thumbUp4);
  //lcd.createChar(4, thumbUp5);
  //lcd.createChar(5, thumbUp6);
  //lcd.setCursor(4,3);
  //lcd.write(byte(0));
  //lcd.setCursor(4,2);
  //lcd.write(byte(1));
  //lcd.setCursor(5,3);
  //lcd.write(byte(2));
  //lcd.setCursor(5,2);
  //lcd.write(byte(3));
  //lcd.setCursor(6,3);
  //lcd.write(byte(4));
  //lcd.setCursor(6,2);
  //lcd.write(byte(5));
//}

//void thumbdown() {
  //byte thumbDown0[8] = {B00001,B00010,B00011,B00100,B00011,B00100,B00011,B00100};
  //byte thumbDown1[8] = {B00011,B00000,B00000,B00000,B00000,B00000,B00000,B00000};
  //byte thumbDown2[8] = {B11110,B00001,B00000,B00000,B00000,B00000,B00000,B00000};
  //byte thumbDown3[8] = {B00000,B11110,B01000,B10001,B10010,B10010,B01100,B00000};
  //byte thumbDown4[8] = {B00000,B10000,B01110,B00010,B00010,B00010,B00010,B00010};
  //byte thumbDown5[8] = {B00110,B01000,B10000,B00000,B00000,B00000,B00000,B00000};
  //lcd.createChar(0, thumbDown0);
  //lcd.createChar(1, thumbDown1);
  //lcd.createChar(2, thumbDown2);
  //lcd.createChar(3, thumbDown3);
  //lcd.createChar(4, thumbDown4);
  //lcd.createChar(5, thumbDown5);
  //lcd.setCursor(14,2);
  //lcd.write(byte(0));
  //lcd.setCursor(14,3);
  //lcd.write(byte(1));
  //lcd.setCursor(15,2);
  //lcd.write(byte(2));
  //lcd.setCursor(15,3);
  //lcd.write(byte(3));
  //lcd.setCursor(16,2);
  //lcd.write(byte(4));
  //lcd.setCursor(16,3);
  //lcd.write(byte(5));
//}
