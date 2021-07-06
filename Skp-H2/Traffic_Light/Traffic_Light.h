class TrafficLight {

int _greenLED;
int _yellowLED;
int _redLED;
bool _isReverse;

public:
  TrafficLight(int greenLED, int yellowLED, int redLED, bool isReverse) {
  
    _greenLED = greenLED;
    _yellowLED = yellowLED;
    _redLED = redLED;
    _isReverse = isReverse;
    
    pinMode(_greenLED, OUTPUT);
    pinMode(_yellowLED, OUTPUT);
    pinMode(_redLED, OUTPUT);    
  }

 void Green() {
    digitalWrite(_greenLED, LOW);
    digitalWrite(_yellowLED, HIGH);
    digitalWrite(_redLED, HIGH);
  }

  void Yellow() {
    digitalWrite(_greenLED, HIGH);
    digitalWrite(_yellowLED, LOW);
    digitalWrite(_redLED, HIGH);
  }

  void Red() {
    digitalWrite(_greenLED, HIGH);
    digitalWrite(_yellowLED, HIGH);
    digitalWrite(_redLED, LOW);
  }

  void RedAndYellow() {
    digitalWrite(_greenLED, HIGH);
    digitalWrite(_yellowLED, LOW);
    digitalWrite(_redLED, LOW);
  }

  void RedReverse() {
    digitalWrite(_greenLED, HIGH);
    digitalWrite(_yellowLED, HIGH);
    digitalWrite(_redLED, LOW);
  }
  
  void RedAndYellowReverse() {
    digitalWrite(_greenLED, HIGH);
    digitalWrite(_yellowLED, LOW);
    digitalWrite(_redLED, LOW);
  }
  
  void GreenReverse() {
    digitalWrite(_greenLED, LOW);
    digitalWrite(_yellowLED, HIGH);
    digitalWrite(_redLED, HIGH);
  }
  
  void YellowReverse() {
    digitalWrite(_greenLED, HIGH);
    digitalWrite(_yellowLED, LOW);
    digitalWrite(_redLED, HIGH);
  }
};
