namespace LineOO
{
    struct Point
    {
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public readonly double X;
        public readonly double Y;
    }
    class Line
    {
        public Line(double k, double l)
        {
            this.k = k;
            this.l = l;
        }

        private double k;
        private double l;

        public Point? Intersection(Line other)
        {
            if (k == other.k)
                return null;

            double x = (other.l - l) / (k - other.k);
            double y = k * x + l;
            return new Point(x, y);
        }
    }
}
