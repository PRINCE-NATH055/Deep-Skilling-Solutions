package factories;

import document.Document;
import concretedocclasses.WordDocument;

public class WordFactory extends DocumentFactory {
    @Override
    public Document createDocument() {
        return new WordDocument();
    }
}
