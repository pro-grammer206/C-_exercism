using System.Globalization;
class WeighingMachine
{
    private readonly int _precision;
    private double _weight;

    public int Precision { get { return _precision; } }

    public double Weight
    {
        get => _weight;
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            _weight = value;
        }
    }
    public WeighingMachine(int precision)
    {
        this._precision = precision;
    }

    public double TareAdjustment { get; set; } = 5.0;
    public string DisplayWeight
    {
        get => string.Format(new NumberFormatInfo { NumberDecimalDigits = Precision }, "{0:F} kg", Weight - TareAdjustment);

    }
}