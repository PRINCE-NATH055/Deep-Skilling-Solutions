# Approach for Factory Method Pattern Exercise

## Components:
- Interface: `Document`
- Concrete Products: `WordDocument`, `PdfDocument`, `ExcelDocument`
- Abstract Factory: `DocumentFactory` (contains abstract method `createDocument()`)
- Concrete Factories:
  - `WordDocumentFactory`
  - `PdfDocumentFactory`
  - `ExcelDocumentFactory`

## Behavior:
Each concrete factory knows how to instantiate its specific document type. The client uses the factory without needing to know the internal instantiation logic.

## Testing Plan:
- Using `DocumentFactoryTest` class to:
  - Instantiate each factory
  - Calling `createDocument()` and print/verify the class type
- Validating that different factory instances produce different document types, all adhering to the `Document` interface.

