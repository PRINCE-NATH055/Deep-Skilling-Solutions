# Exercise 1: Implementing the Singleton Pattern

## Scenario
You need to ensure that a logging utility class in your application has only one instance throughout the application lifecycle to ensure consistent logging.

## Objective
Implement the Singleton Design Pattern in Java to restrict instantiation of the Logger class to a single object and provide global access to it.

## Steps

1. **Create a New Java Project**  
   - Name the project: `SingletonPatternExample`.

2. **Define a Singleton Class**  
   - Create a class named `Logger`.
   - The class should contain:
     - A private static instance of itself.
     - A private constructor to prevent external instantiation.
     - A public static method to return the singleton instance.

3. **Implement the Singleton Pattern**  
   - Ensure that the class restricts the instantiation and provides consistent access to the same object.

4. **Test the Singleton Implementation**  
   - Create a test class to verify that only one instance of `Logger` is created and reused across the application.
