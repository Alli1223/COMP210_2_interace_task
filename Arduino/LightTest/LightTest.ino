#include "Ardunity.h"
#include "PulseOutput.h"

PulseOutput pulseOutput0(0, 13, LOW);

void setup()
{
  ArdunityApp.attachController((ArdunityController*)&pulseOutput0);
  ArdunityApp.resolution(256, 1024);
  ArdunityApp.timeout(5000);
  ArdunityApp.begin(115200);
}

void loop()
{
  ArdunityApp.process();
}
