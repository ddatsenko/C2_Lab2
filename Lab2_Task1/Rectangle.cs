namespace Lab2_Task1
{
    class Rectangle
    {
        int a, b;
        public Rectangle()
        {
            a = 0;
            b = 0;
        }
        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public override string ToString() => $"Length of the sides of a rectangle: a = {a} cm, b = {b} cm";
        public string PerimeterCalculation()
        {
            int perimeter = 2 * (a + b);
            return $"Perimeter of a rectangle: P = {perimeter} cm";
        }
        public string AreaCalculation()
        {
            int area = a * b;
            return $"The area of a rectangle: S = {area} square centimeters";
        }
        public int A
        {
            get => a;
            set => a = value;
        }
        public int B
        {
            get => b;
            set => b = value;
        }
        public string this[int i]
        {
            get
            {
                switch (i)
                {
                    case 'a':
                        return $"Rectangle's side a equals {a} cm";
                    case 'b':
                        return $"Rectangle's side b equals {b} cm";
                    default:
                        return null;
                }
            }
        }
    }
}
