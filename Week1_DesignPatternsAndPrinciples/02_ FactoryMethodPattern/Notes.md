# Factory Method Pattern

## Components

### 1. Interface
- `IDocument.cs`
  - Declares method: `void Open();`

### 2. Concrete Document Classes
- `WordDocument.cs`
- `PdfDocument.cs`
- `ExcelDocument.cs`

Each implements `IDocument` and overrides `Open()` method.

### 3. Abstract Factory
- `DocumentFactory.cs`
  - Abstract class with method:
    ```csharp
    public abstract IDocument CreateDocument();
    ```

### 4. Concrete Factories
- `WordDocumentFactory.cs`
- `PdfDocumentFactory.cs`
- `ExcelDocumentFactory.cs`

Each class inherits from `DocumentFactory` and implements `CreateDocument()` returning the respective document type.

## Testing Plan

### Test Class
- File: `Program.cs` used to instantiate each factory and verify correct document creation.