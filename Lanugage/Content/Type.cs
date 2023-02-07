namespace Lanugage.Content;

public partial class SymbolTableGenerator
{
    public enum Type
    {
        INT,
        FLOAT,
        STRING,
        BOOL,
        ASSIGNMENT, // assignment is an expression, but should not be allowed
        FUNCTION
    }
}