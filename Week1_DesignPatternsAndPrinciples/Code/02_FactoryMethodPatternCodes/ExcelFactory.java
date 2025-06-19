package factories;

import document.Document;
import concretedocclasses.ExcelDocument;

public class ExcelFactory extends DocumentFactory {
    @Override
    public Document createDocument() {
        return new ExcelDocument();
    }
}
