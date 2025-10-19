#define BLYNK_TEMPLATE_ID "TMPL6y2ZBiwO9"
#define BLYNK_TEMPLATE_NAME "AUTOMATED IRRIGATION SYSTEM"
#define BLYNK_AUTH_TOKEN "JKxbz7bQX5QHb7WDgz6Cavq6E-mERXiy"

#define BLYNK_PRINT Serial
#include <ESP8266WiFi.h>
#include <BlynkSimpleEsp8266.h>

// Multiplexer control pins
#define S0 D5
#define S1 D6
#define S2 D7

char auth[] = BLYNK_AUTH_TOKEN;
char ssid[] = "HUAWEI Y5 Prime 2018";
char pass[] = "12345678";

const int sensor_pin = A0;
const int relayPins[] = {D0, D1, D2};  // Relays controlled by V11, V12, V13
bool autoMode = true;
int moistureThreshold = 30;
unsigned long lastUpdate = 0;

float moisture[3] = {0, 0, 0};

void setup() {
  Serial.begin(115200);
  
  // Initialize multiplexer
  pinMode(S0, OUTPUT);
  pinMode(S1, OUTPUT);
  pinMode(S2, OUTPUT);
  
  // Initialize relays
  for (int i = 0; i < 3; i++) {
    pinMode(relayPins[i], OUTPUT);
    digitalWrite(relayPins[i], HIGH);  // Start with all relays OFF
  }
  
  Blynk.begin(auth, ssid, pass);
  Blynk.syncAll();
  Blynk.virtualWrite(V10, 0);  // Initialize Auto mode
  Serial.println("System Initialized.");
}

void selectSensor(uint8_t sensor) {
  digitalWrite(S0, (sensor & 1) ? HIGH : LOW);
  digitalWrite(S1, (sensor & 2) ? HIGH : LOW);
  digitalWrite(S2, (sensor & 4) ? HIGH : LOW);
  delay(10);  // Mux stabilization
}

void readAndSendSensors() {
  for (int i = 0; i < 3; i++) {
    selectSensor(i);
    int rawValue = analogRead(sensor_pin);
    moisture[i] = 100.00 - ((rawValue / 1023.00) * 100.00);
    
    // Always send sensor data to Blynk
    Blynk.virtualWrite(V1 + i, moisture[i]);
    
    // Serial output for monitoring sensor values
    Serial.print("Sensor ");
    Serial.print(i);
    Serial.print(": ");
    Serial.print(moisture[i]);
    Serial.println("%");
  }
}

void autoControl() {
  for (int i = 0; i < 3; i++) {
    bool needsWater = moisture[i] < moistureThreshold;
    digitalWrite(relayPins[i], needsWater ? LOW : HIGH);
    Blynk.virtualWrite(V11 + i, needsWater ? 1 : 0);
    
    // Serial output for relay state
    Serial.print("Relay ");
    Serial.print(i);
    Serial.print(" - ");
    if (needsWater) {
      Serial.println("Watering ON");
    } else {
      Serial.println("Watering OFF");
    }
  }
}

void loop() {
  Blynk.run();
  
  if (millis() - lastUpdate > 1000) {
    readAndSendSensors();  // Always read and send sensors
    
    if (autoMode) {
      autoControl();  // Only control relays in auto mode
    }
    
    lastUpdate = millis();
  }
}

// Mode switch handler (V10)
BLYNK_WRITE(V10) {
  autoMode = !param.asInt();
  
  if (autoMode) {
    // When entering auto mode, sync switches with actual state
    for (int i = 0; i < 3; i++) {
      Blynk.virtualWrite(V11 + i, digitalRead(relayPins[i]) == LOW ? 1 : 0);
    }
  }
  
  // Serial output for mode change
  Serial.print("Mode switched to ");
  Serial.println(autoMode ? "Auto" : "Manual");
}

// Manual control handlers
BLYNK_WRITE(V11) { 
  if (!autoMode) {
    digitalWrite(D0, param.asInt() ? LOW : HIGH);
  }
  // Serial output for manual relay control
  Serial.print("Relay 0 ");
  Serial.println(param.asInt() ? "ON" : "OFF");
}

BLYNK_WRITE(V12) { 
  if (!autoMode) {
    digitalWrite(D1, param.asInt() ? LOW : HIGH);
  }
  // Serial output for manual relay control
  Serial.print("Relay 1 ");
  Serial.println(param.asInt() ? "ON" : "OFF");
}

BLYNK_WRITE(V13) { S
  if (!autoMode) {
    digitalWrite(D2, param.asInt() ? LOW : HIGH);
  }
  // Serial output for manual relay control
  Serial.print("Relay 2 ");
  Serial.println(param.asInt() ? "ON" : "OFF");
}
