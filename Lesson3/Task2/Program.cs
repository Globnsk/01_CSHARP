double CalculateFormula(int a, int b, int c, int d)
{
    double numinator = a * b;
    int denuminator = c + d;
    double result = numinator / denuminator;
    return result;
}
double answer = CalculateFormula(1, 2, 3, 4);
Console.Write(answer);