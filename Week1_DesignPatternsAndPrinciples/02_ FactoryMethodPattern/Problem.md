# Exercise 2: Implementing the Factory Method Pattern

## Scenario
You are developing a document management system that needs to create different types of documents (e.g., Word, PDF, Excel). To handle the creation process flexibly and adhere to object-oriented principles, use the Factory Method Pattern.

## Objective
Design a system where different types of documents are created using factory classes. This allows for scalability and decouples object creation from the client code.

## Steps

1. **Create a New Java Project**
   - Name the project: `FactoryMethodPatternExample`.

2. **Define Document Classes**
   - Create interfaces or abstract classes for document types:
     - `Document` (common interface)
     - `WordDocument`
     - `PdfDocument`
     - `ExcelDocument`

3. **Create Concrete Document Classes**
   - Implement concrete classes for each document type:
     - `WordDocument implements Document`
     - `PdfDocument implements Document`
     - `ExcelDocument implements Document`

4. **Implement the Factory Method**
   - Create an abstract factory class: `DocumentFactory`
     - Method: `createDocument()`
   - Create concrete factory classes:
     - `WordDocumentFactory`
     - `PdfDocumentFactory`
     - `ExcelDocumentFactory`

5. **Test the Factory Method Implementation**
   - Create a test class (e.g., `DocumentFactoryTest`) to demonstrate document creation using different factories.
   - Confirm that the right document objects are created based on the factory used.
