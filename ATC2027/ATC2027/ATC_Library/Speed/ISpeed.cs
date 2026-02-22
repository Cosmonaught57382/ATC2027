namespace ATC2027.Library.Speed
{
    public interface ISpeed
    {
        int ToKnots();
        ISpeed FromKnots();
        abstract string ToString();
    }
}