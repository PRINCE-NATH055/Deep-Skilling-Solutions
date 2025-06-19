# Approach for Singleton Pattern Exercise

- The `Logger` class will implement the Singleton pattern.
- Only one instance of the Logger will exist throughout the program's execution.
- Access will be provided using a public static method: `GetInstance()`.
- To test this, the `Program` class will:
  - Create multiple references to Logger.
  - Compare their references to confirm that they point to the same object.

---

## Structure:

- `Logger.cs` → Contains the Singleton logic.
- `Program.cs` → Demonstrates Singleton behavior and verifies reference equality.



