namespace Name {

    class Number {
        // Fields
        private int _baseValue;

        // Properties
        public int BaseValue { 
            get {return _baseValue;}
            set {
                _baseValue = value;
                SquaredValue = BaseValue * BaseValue;
                CubedValue = SquaredValue * BaseValue;
            }
        }

        // Auto-Properties
        public int SquaredValue { get; private set;}
        public int CubedValue { get; private set;}

        // Constructor
        public Number(int inValue) {
            BaseValue = inValue;
        }

        // Methods
        public void Recall() {
            Console.WriteLine(BaseValue);
            Console.WriteLine(SquaredValue);
            Console.WriteLine(CubedValue);
        }

    }

    class Program {
        static void Main(string[] args) {
            Number myNum = new Number(2);
            myNum.Recall();
            myNum.BaseValue = 3;
            myNum.Recall();
        }
    }
}
