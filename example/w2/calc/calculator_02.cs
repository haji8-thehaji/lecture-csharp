
int in_num1 = 0, in_num2 = 0, result = 0;
string in_oper;//사칙연산 연산자 

Console.WriteLine("첫 번째 숫자를 입력하세요");
// Console.ReadLine()
// int.Parse 스트링을 int로 형변환함
in_num1 = int.Parse(Console.ReadLine());
Console.WriteLine("두 번째 숫자를 입력하세요");
in_num2 = int.Parse(Console.ReadLine());

// *   -  + 
Console.WriteLine("사칙연산 연산자를 입력하세요");
in_oper = (String)Console.ReadLine();

switch (in_oper)
{
    case "+":
        result = in_num1 + in_num2;
        Console.WriteLine(in_num1 + " + " + in_num2 + "  = " + result);
        break;
    case "-":
        result = in_num1 - in_num2;
        Console.WriteLine($"{in_num1} - {in_num2} = {result}");
        break;
    case "*":
        result = in_num1 * in_num2;
        Console.WriteLine("{0} * {1} = {2}", in_num1, in_num2, result);
        break;
    case "/":
        try
        {
            result = in_num1 / in_num2;
            Console.WriteLine("{0} / {1} = {2}", in_num1, in_num2, result);

        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("0으로 나눌수 없습니다");
        }
        break;
    default:
        Console.WriteLine("사칙연산자를 잘못 입력하였습니다.");
        break;
}
