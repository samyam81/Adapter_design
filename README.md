# Adapter Design Pattern

This repository contains implementations of the Adapter design pattern in various programming languages. The Adapter pattern allows objects with incompatible interfaces to collaborate by converting the interface of one object into another interface that a client expects.

## Files

### Kotlin

- **Main.kt**: Contains the main function to demonstrate the usage of the Adapter pattern.
- **AssignmentWork.kt**: Defines the `AssignmentWork` class which uses a `PenAdapter` to write assignments.
- **Pen.kt**: Defines the `Pen` interface.
- **PenAdapter.kt**: Implements the `Pen` interface by adapting `PilotPen` to write assignments.

### Java

- **AssignmentWork.java**: Defines the `AssignmentWork` class which uses a `PenAdapter` to write assignments.
- **Pen.java**: Defines the `Pen` interface.
- **PenAdapter.java**: Implements the `Pen` interface by adapting `PilotPen` to write assignments.
- **PilotPen.java**: Provides the implementation for writing using a Pilot Pen.
- **School.java**: Contains the main function to demonstrate the usage of the Adapter pattern.

### C++

- **Main.cpp**: Contains the main function to demonstrate the usage of the Adapter pattern.
- **AssignmentWork.cpp**: Defines the `AssignmentWork` class which uses a `PenAdapter` to write assignments.
- **Pen.h**: Defines the `Pen` abstract class.
- **PilotPen.h**: Provides the implementation for writing using a Pilot Pen.
- **PenAdapter.cpp**: Implements the `Pen` interface by adapting `PilotPen` to write assignments.

### C#

- **School.cs**: Contains the main function to demonstrate the usage of the Adapter pattern.
- **AssignmentWork.cs**: Defines the `AssignmentWork` class which uses a `PenAdapter` to write assignments.
- **IPen.cs**: Defines the `IPen` interface.
- **PenAdapter.cs**: Implements the `IPen` interface by adapting `PilotPen` to write assignments.
- **PilotPen.cs**: Provides the implementation for writing using a Pilot Pen.

### Python

- **main.py**: Contains the main function to demonstrate the usage of the Adapter pattern.
- **pen.py**: Defines the `Pen` interface.
- **pilot_pen.py**: Provides the implementation for writing using a Pilot Pen.
- **pen_adapter.py**: Implements the `Pen` interface by adapting `PilotPen` to write assignments.
- **assignment_work.py**: Defines the `AssignmentWork` class which uses a `PenAdapter` to write assignments.

## Usage

Each implementation demonstrates how the Adapter pattern can be used to make two incompatible interfaces work together seamlessly. Simply run the main function in each respective language file to see the demonstration.

## Contributors

- [Samyam](https://github.com/samyam81) and 
- [Swikriti](https://github.com/swikriti0416)
