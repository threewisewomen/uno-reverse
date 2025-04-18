using uno_reverse;

public class Program
{
    public readonly IBasicMath _basicMath;
    public readonly ILogicalOperations _logicalOperations;
    public readonly ISetTheory _setTheory;
    public readonly IMatrixOperations _matrixOperations;

    public Program(IBasicMath basicMath, ILogicalOperations logicalOperations, ISetTheory setTheory, IMatrixOperations matrixOperations)
    {
        _basicMath = basicMath;
        _logicalOperations = logicalOperations;
        _setTheory = setTheory;
        _matrixOperations = matrixOperations;
    }

    public static void Main()
    {
        var basicmath = new BasicMath();
        var logicalOperations = new LogicalOperations();
        var setTheory = new SetTheory();
        var matrixOperations = new MatrixOperations();
        var program = new Program(basicmath, logicalOperations, setTheory, matrixOperations);


        Console.WriteLine("************************************************");
        Console.WriteLine("1. Arthematics");
        Console.WriteLine("2. Logical Operations");
        Console.WriteLine("3. Set Theory");
        Console.WriteLine("4. Real Analysis");
        Console.WriteLine("5. Complex Numbers");
        Console.WriteLine("6. Fields");
        Console.WriteLine("7. Vectors");
        Console.WriteLine("8. Matrices");
        Console.WriteLine("9. Lists");
        Console.WriteLine("10. Magic Sqaure");
        Console.WriteLine("11. Traverse Diagonal");
        Console.WriteLine("12. Tetraktys");
        Console.WriteLine("13. Aristotle Square Matrix");
        Console.WriteLine("14. Aristotle Oblong Matrix");
        Console.WriteLine("15. Circle Of Fifths");

        Console.WriteLine("************************************************");


        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice <= 0)
        {
            Console.WriteLine("Select The Choice From the List");
        }
        switch (choice)
        {
            case 1: program.RunArthematic(); break;
            case 2: program.RunLogical(); break;
            case 3: program.RunSetTheory(); break;
            case 4: program.RunRealAnalysis(); break;
            case 5: program.RunComplexNumber(); break;
            case 6: program.RunFields(); break;
            case 7: program.RunVectors(); break;
            case 8: program.RunMatrixRank(); break;
            case 9: program.RunLists(); break;
            case 10: program.RunMagicSquare(); break;
            case 11: program.RunTraverseDiagonal(); break;
            case 12: program.RunTetraktys(); break;
            case 13: program.RunAristotleSquareNumber(); break;
            case 14: program.RunAristotleOblongMatrix(); break;
            case 15: program.RunCircleOfFifths(); break;

            default: Console.WriteLine("Enter Valid Choice"); break;
        }
    }

    public void RunArthematic()
    {

        Console.WriteLine("***********");
        Console.WriteLine("Enter the size");
        int size;
        while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
        {
            Console.WriteLine("Invalid size. Please enter a positive integer:");
        }
        Console.WriteLine("Input your numbers");
        List<int> numbers = new List<int>();
        for (int i = 0; i < size; i++)
        {
            int input;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Enter numbers pls");
            }
            numbers.Add(input);

        }

        int sum = _basicMath.SumofNum(numbers);
        Console.WriteLine("The sum is " + sum);

        int diff = _basicMath.DiffofNum(numbers);
        Console.WriteLine("The diff is " + diff);

        int mul = _basicMath.Multipliers(numbers);
        Console.WriteLine("The series multiplier is " + mul);

        float div = _basicMath.DivofNum(numbers);
        Console.WriteLine("The series divisor is " + div);

    }

    public void RunLogical()
    {
        bool p_isTrue = true;
        bool p_isFalse = false;
        bool q_isTrue = true;
        bool q_isFalse = false;



        Console.WriteLine("___________________");
        Console.WriteLine("CONJUNCTION -- AND OPERATION");
        Console.WriteLine("p is true and q is true. p ∧ q = " + _logicalOperations.And(p_isTrue, q_isTrue));
        Console.WriteLine("p is true and q is false. p ∧ q = " + _logicalOperations.And(p_isTrue, q_isFalse));
        Console.WriteLine("p is false and q is true. p ∧ q = " + _logicalOperations.And(p_isFalse, q_isTrue));
        Console.WriteLine("p is false and q is false. p ∧ q = " + _logicalOperations.And(p_isFalse, q_isFalse));
        Console.WriteLine("___________________");
        Console.WriteLine("/n/n/n");


        Console.WriteLine("___________________");
        Console.WriteLine("DISJUNCTION -- OR OPERATION");
        Console.WriteLine("p is true and q is true. p ∨ q = " + _logicalOperations.Or(p_isTrue, q_isTrue));
        Console.WriteLine("p is true and q is false. p ∨ q = " + _logicalOperations.Or(p_isTrue, q_isFalse));
        Console.WriteLine("p is false and q is true. p ∨ q = " + _logicalOperations.Or(p_isFalse, q_isTrue));
        Console.WriteLine("p is false and q is false. p ∨ q = " + _logicalOperations.Or(p_isFalse, q_isFalse));
        Console.WriteLine("___________________");
        Console.WriteLine("/n/n/n");


        Console.WriteLine("___________________");
        Console.WriteLine("IMPLICATION");
        Console.WriteLine("p is true and q is true. p  →  q = " + _logicalOperations.Implication(p_isTrue, q_isTrue));
        Console.WriteLine("p is true and q is false. p  →  q = " + _logicalOperations.Implication(p_isTrue, q_isFalse));
        Console.WriteLine("p is false and q is true. p  →  q = " + _logicalOperations.Implication(p_isFalse, q_isTrue));
        Console.WriteLine("p is false and q is false. p  →  q = " + _logicalOperations.Implication(p_isFalse, q_isFalse));
        Console.WriteLine("___________________");
        Console.WriteLine("/n/n/n");


        Console.WriteLine("___________________");
        Console.WriteLine("BICONDITIONAL");
        Console.WriteLine("p is true and q is true. p  ↔  q = " + _logicalOperations.Biconditional(p_isTrue, q_isTrue));
        Console.WriteLine("p is true and q is false. p  ↔  q = " + _logicalOperations.Biconditional(p_isTrue, q_isFalse));
        Console.WriteLine("p is false and q is true. p  ↔  q = " + _logicalOperations.Biconditional(p_isFalse, q_isTrue));
        Console.WriteLine("p is false and q is false. p  ↔  q = " + _logicalOperations.Biconditional(p_isFalse, q_isFalse));
        Console.WriteLine("___________________");
        Console.WriteLine("/n/n/n");

        Console.WriteLine("___________________");
        Console.WriteLine("Negation");
        Console.WriteLine("p is true. ¬p = " + _logicalOperations.Negation(p_isTrue));
        Console.WriteLine("q is false. ¬q = " + _logicalOperations.Negation(q_isFalse));
        Console.WriteLine("q is true. ¬q = " + _logicalOperations.Negation(q_isTrue));
        Console.WriteLine("p is false. ¬p = " + _logicalOperations.Negation(p_isFalse));
        Console.WriteLine("___________________");
        Console.WriteLine("/n/n/n");

    }

    public void RunSetTheory()
    {
        Console.WriteLine("Set Builder \n");

        Console.WriteLine("Enter a property P(x) to describe the set:");
        Console.WriteLine("Example 1: enter 'x => x % 2 == 0 && x > 10' for even numbers");
        Console.WriteLine("Example 2: enter 'x => x % 2 == 0 && x > 10' - Even numbers greater than 10.");
        Console.WriteLine("Example 3: enter 'x => x % 3 == 0 || x % 5' == 0 - Numbers divisible by either 3 or 5.");
        Console.WriteLine("Example 4: enter 'x => x >= 0 && x <= 100' - Numbers between 0 and 100, inclusive.");
        Console.WriteLine("Example 5: enter 'x => x * x < 100' - Numbers whose square is less than 100.");
        Console.WriteLine("Example 6: enter 'x => Enumerable.Range(2, x - 1).All(y => x % y != 0)' - Prime numbers. ");


        string propertyString = Console.ReadLine();

        Func<int, bool> property = x => _setTheory.EvaluateProperty(propertyString, x);

        Console.WriteLine("Enter the upper limit of the set: ");
        int limit;
        while (!int.TryParse(Console.ReadLine(), out limit))
        {
            Console.WriteLine("Enter numbers pls");
        }
        _setTheory.GenerateSet(property, limit);



    }

    public void RunRealAnalysis()
    {
        PositiveRational a = new PositiveRational(1, 2);
        PositiveRational b = new PositiveRational(2, 3);

        PositiveRational sum = a + b;
        PositiveRational product = a * b;

        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");
        Console.WriteLine($"a + b = {sum}");
        Console.WriteLine($"a * b = {product}");
    }
    public void RunComplexNumber()
    {
        Console.WriteLine("Enter the real part of the first complex number");
        double real1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the imaginary part of the first complex number");
        double imaginary1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the real part of the second complex number");
        double real2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the imaginary part of the second complex number");
        double imaginary2 = Convert.ToDouble(Console.ReadLine());

        ComplexNumbers complex1 = new ComplexNumbers(real1, imaginary1);
        ComplexNumbers complex2 = new ComplexNumbers(real2, imaginary2);

        ComplexNumbers additionResult = complex1 + complex2;
        ComplexNumbers subtractionResult = complex1 - complex2;
        ComplexNumbers multiplicationResult = complex1 * complex2;
        ComplexNumbers divisionResult = complex1 / complex2;

        Console.WriteLine($"Addition: {additionResult}");
        Console.WriteLine($"Subtraction: {subtractionResult}");
        Console.WriteLine($"Multiplication: {multiplicationResult}");
        Console.WriteLine($"Division: {divisionResult}");

    }

    public void RunVectors()
    {
        Console.WriteLine("Enter Vector 1 (x) : ");
        int v1x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Vector 1 (y) : ");
        int v1y = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Vector 2 (x) : ");
        int v2x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Vector 2 (y) : ");
        int v2y = int.Parse(Console.ReadLine());

        Vector v1 = new Vector(v1x, v1y);
        Vector v2 = new Vector(v2x, v2y);

        Vector result = Vector.Add(v1, v2);

        Console.WriteLine($"Result of Vector Addtion: {result}");
    }
    public void RunMatrixRank()
    {
        List<double[]> vectors = new List<double[]>();
        Console.WriteLine("Enter the number vectors:");
        int numVectors = int.Parse(Console.ReadLine());

        for (int i = 0; i < numVectors; i++)
        {
            Console.WriteLine($"Enter the components of vector {i + 1} separated by spaces:");
            string[] components = Console.ReadLine().Split(' ');
            double[] vector = Array.ConvertAll(components, double.Parse);
            vectors.Add(vector);
        }

        double[,] matrix = _matrixOperations.ColumnStack(vectors);

        Console.WriteLine("The matrix is: ");
        _matrixOperations.PrintMatrix(matrix);

        int rank = _matrixOperations.CalculateRank(matrix);
        Console.WriteLine($" The rank of the matrix is: {rank}");
    }

    public void RunFields()
    {
        Console.WriteLine("We are going to do exponents");
        Console.WriteLine("Enter a number F:");
        int f1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the exponent for that number (F)^e");
        int f2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter another exponent to find (F^e)^x");
        int f3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter another number to find (F1.F2)^e");
        int f4 = int.Parse(Console.ReadLine());


        Fields f = new Fields(f1, f2);
        Fields ff = new Fields(f1, f2, f3);
        Fields fff = new Fields(f1, f4, f2);
        double singlepower = Fields.SinglePower(f);
        double doublepower = Fields.DoublePower(ff);
        double multiplypower = Fields.MultiplyAndPower(fff);

        double singlepowerloop = Fields.SinglePowerLoop(f);
        double doublepowerloop = Fields.DoublePowerLoop(ff);
        double multiplypowerloop = Fields.MultipleAndPowerLoop(fff);

        Console.WriteLine($"LHS {singlepower} = RHS {singlepowerloop}");
        Console.WriteLine($"LHS {doublepower} = RHS {doublepowerloop}");
        Console.WriteLine($"LHS {multiplypower} = RHS {multiplypowerloop}");


    }

    public void RunLists()
    {
        Console.WriteLine("Enter a positive integer for length n");
        int n = int.Parse(Console.ReadLine());
        List<int> F = new List<int>();

        Console.WriteLine("Enter the Elements for F of length n");
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Enter {i} element");
            int x = int.Parse(Console.ReadLine());
            F.Add(x);
        }

        Console.WriteLine("Search element if it exists");
        int k = int.Parse(Console.ReadLine());

        int result = Lists.SearchInList(F, k);

        if (result == -1)
        {
            Console.WriteLine("Does not exist");
        }

        List<int> sortedList = Lists.SortList(F);
        List<int> scalarMul = Lists.ScalarMultiply(F, k);
        foreach (var item in sortedList)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("lets add 2 lists");
        Console.WriteLine("Let List X be 1,3,5,7,9");
        Console.WriteLine("Let List Y be 2,4,6,8,10");

        List<int> X = new List<int> { 1, 3, 5, 7, 9 };
        List<int> Y = new List<int> { 2, 4, 6, 8, 10 };

        List<int> summedList = Lists.AddList(X, Y);
        foreach (var item in summedList)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine($"Scalar Multiplication of List F and {k}");
        foreach (var item in scalarMul)
        {
            Console.WriteLine(item);
        }
    }

    public void RunMagicSquare()
    {
        //Console.WriteLine("Enter the Square Dimension M ..... where the Square is M x M");
        //int m;
        //while (!int.TryParse(Console.ReadLine(), out m) || m < 0)
        //{
        //    Console.WriteLine("Enter a valid dimension");
        //}
        //int magicsum = MagicSquare.MagicSum(m);
        //Console.WriteLine($"the magic sum is  {magicsum}");
        Console.WriteLine("DURER MAGIC SQUARE");

        int[,] matrix = MagicSquare.DurerMagicSquare();
        MagicSquare.PrintMatrix(matrix);

    }

    public void RunTraverseDiagonal()
    {
        Console.WriteLine("Enter the number x for dimension of Square matrix");
        int num = int.Parse(Console.ReadLine());
        //DiagonalTraverse.DiagonalTraversev1(num);
        //DiagonalTraverse.DiagonalTraversalv2(num); DiagonalTraversalv3
        DiagonalTraverse.DiagonalTraversalv3(num);
    }

    public void RunTetraktys()
    {
        Tetraktys tetraktys = new Tetraktys();
        tetraktys.TetraktysMain();
    }

    public void RunAristotleSquareNumber()
    {
        AritoteSquareMatrix aritoteSquareMatrix = new AritoteSquareMatrix(_matrixOperations);
        aritoteSquareMatrix.AritoteSquareMatrixMain();
    }

    public void RunAristotleOblongMatrix()
    {
        AristotleOblongMatrix aritoteOblongMatrix = new AristotleOblongMatrix(_matrixOperations);
        aritoteOblongMatrix.AritoteOblongMatrixMain();
    }

    public void RunCircleOfFifths()
    {
        CircleOfFifths circleOfFifths = new CircleOfFifths();
        circleOfFifths.CircleOfFifthsMain();
    }
}


