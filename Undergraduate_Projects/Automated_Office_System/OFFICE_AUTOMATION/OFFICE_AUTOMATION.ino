#define BLYNK_TEMPLATE_ID "TMPL6YUPfyunE"
#define BLYNK_TEMPLATE_NAME "OFFICE AUTOMATION"
#define BLYNK_AUTH_TOKEN "q7W_p_hYVPu0BMXFZX5vO49psmyUDPri"

#define BLYNK_PRINT Serial

#include <ESP8266WiFi.h>
#include <BlynkSimpleEsp8266.h>

char auth[] = BLYNK_AUTH_TOKEN;

char ssid[] = "Oppo A17";
char pass[] = "PremYudi62";

BLYNK_WRITE(V0)
{
  int value = param.asInt();
  Serial.println(value);
  if (value == 1)
  {
    // Turn on all LEDs
    digitalWrite(D0, LOW);
    digitalWrite(D1, LOW);
    digitalWrite(D2, LOW);
    digitalWrite(D3, LOW);
    Serial.println("All LEDs ON");
  }
  if (value == 0)
  {
    // Turn off all LEDs
    digitalWrite(D0, HIGH);
    digitalWrite(D1, HIGH);
    digitalWrite(D2, HIGH);
    digitalWrite(D3, HIGH);
    Serial.println("All LEDs OFF");
  }
}

BLYNK_WRITE(V1)
{
  int value = param.asInt();
  Serial.println(value);
  if (value == 1)
  {
    digitalWrite(D0, LOW);
    Serial.println("LED 1 (D0) ON");
  }
  if (value == 0)
  {
    digitalWrite(D0, HIGH);
    Serial.println("LED 1 (D0) OFF");
  }
}

BLYNK_WRITE(V2)
{
  int value = param.asInt();
  Serial.println(value);
  if (value == 1)
  {
    digitalWrite(D1, LOW);
    Serial.println("LED 2 (D1) ON");
  }
  if (value == 0)
  {
    digitalWrite(D1, HIGH);
    Serial.println("LED 2 (D1) OFF");
  }
}

BLYNK_WRITE(V3)
{
  int value = param.asInt();
  Serial.println(value);
  if (value == 1)
  {
    digitalWrite(D2, LOW);
    Serial.println("LED 3 (D2) ON");
  }
  if (value == 0)
  {
    digitalWrite(D2, HIGH);
    Serial.println("LED 3 (D2) OFF");
  }
}

BLYNK_WRITE(V4)
{
  int value = param.asInt();
  Serial.println(value);
  if (value == 1)
  {
    digitalWrite(D3, LOW);
    Serial.println("LED 4 (D3) ON");
  }
  if (value == 0)
  {
    digitalWrite(D3, HIGH);
    Serial.println("LED 4 (D3) OFF");
  }
}

void setup()
{
  Serial.begin(115200);
  Blynk.begin(auth, ssid, pass);

  // Initialize all LEDs to OFF initially
  digitalWrite(D0, HIGH);  // LED 1 (D0) OFF
  digitalWrite(D1, HIGH);  // LED 2 (D1) OFF
  digitalWrite(D2, HIGH);  // LED 3 (D2) OFF
  digitalWrite(D3, HIGH);  // LED 4 (D3) OFF
  
  pinMode(D0, OUTPUT);
  pinMode(D1, OUTPUT);
  pinMode(D2, OUTPUT);
  pinMode(D3, OUTPUT);
}

void loop()
{
  Blynk.run();
}
