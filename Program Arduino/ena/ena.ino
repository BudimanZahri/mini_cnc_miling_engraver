#include <AccelStepper.h>

// Define motor interface type
#define MotorInterfaceType 1

// Define the pins connected to your motor driver for the X-axis
#define X_STEP_PIN D0
#define X_DIR_PIN D1

// Define the pins connected to your motor driver for the Y-axis
#define Y_STEP_PIN D2
#define Y_DIR_PIN D3

// Define the pins connected to your motor driver for the Z-axis
#define Z_STEP_PIN D4
#define Z_DIR_PIN D5

// Create instances of AccelStepper for X-axis, Y-axis, and Z-axis
AccelStepper stepperX(MotorInterfaceType, X_STEP_PIN, X_DIR_PIN);
AccelStepper stepperY(MotorInterfaceType, Y_STEP_PIN, Y_DIR_PIN);
AccelStepper stepperZ(MotorInterfaceType, Z_STEP_PIN, Z_DIR_PIN);

// Define variables to control the X-axis motor
bool moveClockwise_X = false;
bool moveCounterClockwise_X = false;
bool moveoff_X = false;

// Define variables to control the Y-axis motor
bool moveClockwise_Y = false;
bool moveCounterClockwise_Y = false;
bool moveoff_Y = false;

// Define variables to control the Z-axis motor
bool moveClockwise_Z = false;
bool moveCounterClockwise_Z = false;
bool moveoff_Z = false;

void setup() {
  // Initialize serial communication
  Serial.begin(9600);

  // Set up the direction pins
  pinMode(X_STEP_PIN, OUTPUT);
  pinMode(X_DIR_PIN, OUTPUT);
  pinMode(Y_STEP_PIN, OUTPUT);
  pinMode(Y_DIR_PIN, OUTPUT);
  pinMode(Z_STEP_PIN, OUTPUT);
  pinMode(Z_DIR_PIN, OUTPUT);

  // Set maximum speed and acceleration values for all motors
  stepperX.setMaxSpeed(1000000);
  stepperX.setAcceleration(100000);

  stepperY.setMaxSpeed(1000000);
  stepperY.setAcceleration(100000);
  
  stepperZ.setMaxSpeed(1000000);
  stepperZ.setAcceleration(100000);
}

void loop() {
  if (Serial.available() > 0) {
    char command = Serial.read();
    // X-axis commands
    if (command == 'Q') {
      moveClockwise_X = true;
      moveCounterClockwise_X = false;
      moveoff_X = false;
    } else if (command == 'W') {
      moveClockwise_X = false;
      moveCounterClockwise_X = true;
      moveoff_X = false;
    } else if (command == 'E') {
      moveClockwise_X = false;
      moveCounterClockwise_X = false;
      moveoff_X = true;
    }
    // Y-axis commands
    else if (command == 'R') {
      moveClockwise_Y = true;
      moveCounterClockwise_Y = false;
      moveoff_Y = false;
    } else if (command == 'T') {
      moveClockwise_Y = false;
      moveCounterClockwise_Y = true;
      moveoff_Y = false;
    } else if (command == 'Y') {
      moveClockwise_Y = false;
      moveCounterClockwise_Y = false;
      moveoff_Y = true;
    }
    // Z-axis commands
    else if (command == 'U') {
      moveClockwise_Z = true;
      moveCounterClockwise_Z = false;
      moveoff_Z = false;
    } else if (command == 'I') {
      moveClockwise_Z = false;
      moveCounterClockwise_Z = true;
      moveoff_Z = false;
    } else if (command == 'O') {
      moveClockwise_Z = false;
      moveCounterClockwise_Z = false;
      moveoff_Z = true;
    }
  }

  // Control the X-axis motor
  if (moveClockwise_X) {
    stepperX.setSpeed(100000);
    stepperX.runSpeed();
  } else if (moveCounterClockwise_X) {
    stepperX.setSpeed(-100000);
    stepperX.runSpeed();
  } else if (moveoff_X) {
    stepperX.setSpeed(0);
    stepperX.runSpeed();
  }
  
  // Control the Y-axis motor
  if (moveClockwise_Y) {
    stepperY.setSpeed(100000);
    stepperY.runSpeed();
  } else if (moveCounterClockwise_Y) {
    stepperY.setSpeed(-100000);
    stepperY.runSpeed();
  } else if (moveoff_Y) {
    stepperY.setSpeed(0);
    stepperY.runSpeed();
  }

  // Control the Z-axis motor
  if (moveClockwise_Z) {
    stepperZ.setSpeed(100000);
    stepperZ.runSpeed();
  } else if (moveCounterClockwise_Z) {
    stepperZ.setSpeed(-100000);
    stepperZ.runSpeed();
  } else if (moveoff_Z) {
    stepperZ.setSpeed(0);
    stepperZ.runSpeed();
  }
}
