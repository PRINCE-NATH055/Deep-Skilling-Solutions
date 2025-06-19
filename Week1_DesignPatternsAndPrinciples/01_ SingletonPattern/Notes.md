# Approach for Singleton Pattern Exercise

- The `Logger` class will implement the Singleton pattern.
- Only one instance of the Logger will exist throughout the program's execution.
- Access will be provided using a public static method: `getInstance()`.
- To test this, the `SingletonTest` class will:
  - Create multiple references to Logger.
  - Compare their references to confirm that they point to the same object.


## Structure:
- Logger.java → Contains the singleton logic.
- Test.java → Demonstrates singleton behavior and verifies reference equality.

