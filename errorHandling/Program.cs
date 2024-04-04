using errorHandling.Models;
// Console.WriteLine(DevidebyNumber(6, 0));

// decimal DevidebyNumber(int num1, int num2)
// {
//     decimal answer = 0; 
//     try
//     {
//        answer = num1 / num2;
//     }

//     catch(DivideByZeroException ex)
//     {
//         Console.WriteLine(ex.Message);
//         Console.WriteLine($"Devid Number Cannot be a Zero , {ex.Message}");

//     }

//     catch(Exception ex)
//     {
//         Console.WriteLine(ex.Message);
//     }

//     return answer; 
// }

var mical = new Employee();
mical.Name = "Mical";
mical.Email = "mical@email.com";
mical.NetSalary = 70000;
mical.LoanAmount = 50000;

decimal netSalary = mical.NetSalary;

try
{
    mical.GetNetSalary();
Console.WriteLine($"This is {mical.Name} Calculated Salary {netSalary}");

}

catch(NetSalaryException ex)
{
    Console.WriteLine($"Cannot Calulate NetSalary Logic Error: {ex.Message}");
}


catch(Exception ex)
{
    Console.WriteLine($"Somthing Went Wrong : {ex.Message}");
}
