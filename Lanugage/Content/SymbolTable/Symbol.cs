using System.Xml.Linq;

namespace Lanugage.Content.SymbolTable;

public class Symbol
{
    public string Name { get; set; }
    public int? Type { get; set; }

    public Symbol(string name, int? type)
    {
        Name = name;
        Type = type;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null) return false;
        if (!(obj.GetType() == typeof(Symbol))) {
            return false;
        }
        if (obj == this)
        {
            return true;
        }
        return Name == ((Symbol)obj).Name;
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode();
    }
}