using System;

namespace W10BlockB{
    class Program{
        static void Main(string[] args) {
            int a = 10, b = 5, result;
            char operation = '+';
            Method(a, b, operation, out result);
            Console.WriteLine("{0} {1} {2} = {3}", a, b, operation, result);
            operation = '*';
            Method(a, b, operation, out result);
            Console.WriteLine("{0} {1} {2} = {3}", a, b, operation, result);
            Console.ReadLine();
        }
        static void MethodBool(bool result) { 
        
        }
           
        static void Method(int a, int b, char operation, out int result){
            if (operation == '+'){
                result = a + b;
            }else if (operation == '-'){
                result = a - b;
            }else if (operation == '*' || operation == 'x'){
                result = a * b;
            }else if (operation == '/'){
                result = a / b;
            }else{
                result = 0;
            }
        }
    }
}
