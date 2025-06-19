package factories;

import document.Document;
import concretedocclasses.PdfDocument;

public class PdfFactory extends DocumentFactory {
    @Override
    public Document createDocument() {
        return new PdfDocument();
    }
}
