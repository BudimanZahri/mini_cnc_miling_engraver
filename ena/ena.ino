#include <AccelStepper.h>

// Define motor interface type
#define MotorInterfaceType 1

// Define the pins connected to your motor driver for the X-axis
#define X_STEP_PIN D0
#define X_DIR_PIN D1

// Define the pins connected to your motor driver for the Y-axis
#define Y_STEP_PIN D2
#define Y_DIR_PIN D3

// Create instances of AccelStepper for X-axis and Y-axis
AccelStepper stepperX(MotorInterfaceType, X_STEP_PIN, X_DIR_PIN);
AccelStepper stepperY(MotorInterfaceType, Y_STEP_PIN, Y_DIR_PIN);

// Define variables to control the X-axis motor
bool moveClockwise_X = false;
bool moveCounterClockwise_X = false;
bool moveoff_X = false;
int speedX = 0;  // Speed for the X-axis motor

// Define variables to control the Y-axis motor
bool moveClockwise_Y = false;
bool moveCounterClockwise_Y = false;
bool moveoff_Y = false;
int speedY = 0;  // Speed for the Y-axis motor

void setup() {
  // Initialize serial communication
  Serial.begin(9600);

  // Set up the direction pins
  pinMode(X_STEP_PIN, OUTPUT);
  pinMode(X_DIR_PIN, OUTPUT);
  pinMode(Y_STEP_PIN, OUTPUT);
  pinMode(Y_DIR_PIN, OUTPUT);

  // Set maximum speed and acceleration values for both motors
  stepperX.setMaxSpeed(100000);  // Adjusted maximum speed
  stepperX.setAcceleration(100000);

  stepperY.setMaxSpeed(100000);  // Adjusted maximum speed
  stepperY.setAcceleration(100000);
}

void loop() {
  if (Serial.available() > 0) {
    String command = Serial.readStringUntil('\n');
    // X-axis commands
    if (command == "Q") {
      moveClockwise_X = true;
      moveCounterClockwise_X = false;
      moveoff_X = false;
    } else if (command == "W") {
      moveClockwise_X = false;
      moveCounterClockwise_X = true;
      moveoff_X = false;
    } else if (command == "E") {
      moveClockwise_X = false;
      moveCounterClockwise_X = false;
      moveoff_X = true;
    }
    // Y-axis commands
    else if (command == "R") {
      moveClockwise_Y = true;
      moveCounterClockwise_Y = false;
      moveoff_Y = false;
    } else if (command == "T") {
      moveClockwise_Y = false;
      moveCounterClockwise_Y = true;
      moveoff_Y = false;
    } else if (command == "Y") {
      moveClockwise_Y = false;
      moveCounterClockwise_Y = false;
      moveoff_Y = true;
    }
    // Speed commands
    else if (command.startsWith("S") && command.endsWith("X")) {
      speedX = command.substring(1, command.length() - 1).toInt();
      Serial.println(speedX);
      stepperX.setSpeed(speedX);
    } else if (command.startsWith("S") && command.endsWith("Y")) {
      speedY = command.substring(1, command.length() - 1).toInt();
      stepperY.setSpeed(speedY);
    }
  }

  // Control the X-axis motor
  if (moveClockwise_X) {
    stepperX.setSpeed(speedX);
    stepperX.runSpeed();
  } else if (moveCounterClockwise_X) {
    stepperX.setSpeed(-speedX);
    stepperX.runSpeed();
  } else if (moveoff_X) {
    stepperX.stop();
  }

  // Control the Y-axis motor
  if (moveClockwise_Y) {
    stepperY.setSpeed(speedY);
    stepperY.runSpeed();
  } else if (moveCounterClockwise_Y) {
    stepperY.setSpeed(-speedY);
  }
}