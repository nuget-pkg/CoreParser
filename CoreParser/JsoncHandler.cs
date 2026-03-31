namespace Core;

using Global;
public class JsoncHandler : IParseJson {
    private readonly Core.JsoncParser jsonParser;
    public JsoncHandler(bool numberAsDecimal) {
        jsonParser = new Core.JsoncParser(numberAsDecimal);
    }
    public object? ParseJson(string json) {
        return jsonParser.ParseJson(json);
    }
    public object?[] ParseJsonSequence(string jsonSequenceString) {
        object? result = ParseJson(jsonSequenceString);
        if (result == null) return [null];
        return new object[] { result };
    }
}
