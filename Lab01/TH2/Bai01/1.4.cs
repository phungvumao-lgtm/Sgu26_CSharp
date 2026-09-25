public class Fraction
{
    private long numerator;
    private long denominator;

    public Fraction()
    {
        this.denominator = 1;
        this.numerator = 0;
    }

    public Fraction(long x, long y)
    {
        if (y == 0)
        {
            throw new ArgumentException("Mau so khong duoc bang 0.");
        }

        if (y < 0)
        {
            x = -x;
            y = -y;
        }

        long divisor = Gcd(Math.Abs(x), y);
        this.numerator = x / divisor;
        this.denominator = y / divisor;
    }

    public Fraction(Fraction f){
        this.denominator = f.denominator;
        this.numerator = f.numerator;
    }

    public override string ToString()
    {
        return this.numerator + "/" + this.denominator;
    }

    private static long Gcd(long a, long b)
    {
        if (b == 0)
            return a;
        return Gcd(b, a % b);
    }

    public static Fraction operator +(Fraction a){
        return new Fraction(a.numerator, a.denominator);
    }

    public static Fraction operator -(Fraction a){
        return new Fraction(-a.numerator, a.denominator);
    }

    public static Fraction operator +(Fraction a, Fraction b){
        return new Fraction(a.numerator*b.denominator+b.numerator*a.denominator, a.denominator*b.denominator);
    }

    public static Fraction operator -(Fraction a, Fraction b){
        return new Fraction(a.numerator*b.denominator-b.numerator*a.denominator, a.denominator*b.denominator);
    }

    public static Fraction operator *(Fraction a, Fraction b){
        return new Fraction(a.numerator*b.numerator, a.denominator*b.denominator);
    }

    public static Fraction operator /(Fraction a, Fraction b){
        return new Fraction(a.denominator*b.numerator, a.numerator*b.denominator);
    }

    public static bool operator <(Fraction a, Fraction b){
        return a.numerator * b.denominator < b.numerator * a.denominator;
    }

    public static bool operator >(Fraction a, Fraction b){
        return b < a;
    }

    public static bool operator <=(Fraction a, Fraction b){
        return !(a > b);
    }

    public static bool operator >=(Fraction a, Fraction b){
        return !(a < b);
    }

    public static bool operator ==(Fraction a, Fraction b){
        return !(a < b) && !(a > b);
    }

    public static bool operator !=(Fraction a, Fraction b){
        return !(a == b);
    }

}