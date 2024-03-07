
int in_num1 = 0, in_num2 = 0, sum = 0;
string in_oper;//사칙연산 연산자 

Console.WriteLine("첫 번째 숫자를 입력하세요");
//입력받은 문자열을 int형으로 형변환 후 in_num1에 저장 
in_num1 = int.Parse(Console.ReadLine());
//입력받은 문자열을 int형으로 형변환 후 in_num2에 저장 
Console.WriteLine("두 번째 숫자를 입력하세요");
in_num2 = int.Parse(Console.ReadLine());
//입력받은 문자열을 in_oper에 저장 
Console.WriteLine("사친연산 연산자를 입력하세요");
in_oper = Console.ReadLine();

    //문자열이므로 " "로 작성 
switch (in_oper)
{
    case "+":
        sum = in_num1 + in_num2;
        Console.WriteLine("{0} + {1} = {2}", in_num1, in_num2, sum);
        break;
    case "-":
        sum = in_num1 - in_num2;
        Console.WriteLine("{0} - {1} = {2}", in_num1, in_num2, sum);
        break;
    case "*":
        sum = in_num1 * in_num2;
        Console.WriteLine("{0} * {1} = {2}", in_num1, in_num2, sum);
        break;
    case "/":
        sum = in_num1 / in_num2;
        Console.WriteLine("{0} / {1} = {2}", in_num1, in_num2, sum);
        break;
    default:
        Console.WriteLine("사칙연산자를 잘못 입력하였습니다.");
        break;
}
