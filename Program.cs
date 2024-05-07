var x=10;
Console.WriteLine(x);
x='A';
Console.WriteLine(x);


Organization o;
o=new PermanentEmp();
o.GetEmployeeDetails();
o.ShowEmployeeDetails();
o=new ContractEmp();
o.GetEmployeeDetails();
o.ShowEmployeeDetails();
abstract class Organization
{
    protected int empid;protected string? empname;
    public abstract void GetEmployeeDetails();
    public abstract void ShowEmployeeDetails();
}
class PermanentEmp : Organization
{
    public override void GetEmployeeDetails()
    {
        Console.WriteLine("Enter id");
        empid=Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Enter Name");
        empname=Console.ReadLine();
    }
    public override void ShowEmployeeDetails()
    {
        Console.WriteLine("Permenant Emp");
        Console.WriteLine(empid);
        Console.WriteLine(empname);
    }
}
class ContractEmp : Organization
{
    public override void GetEmployeeDetails()
    {
        Console.WriteLine("Enter id");
        empid=Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Enter Name");
        empname=Console.ReadLine();
    }
    public override void ShowEmployeeDetails()
    {
        Console.WriteLine(empid);
        Console.WriteLine(empname);
    }
}
































// using DemoLib;
// EmpDetails em=new EmpDetails();
// em.GetEmployeeDetails();
// em.ShowEmployeeDetails();
// class EmpDetails{
//     Class1 emp=new Class1();
//     // Class1 emp;

//     public void GetEmployeeDetails(){
//         Console.WriteLine("Enter id");
//         /*int*/ emp.id=Convert.ToInt16(Console.ReadLine());
//         Console.WriteLine("Enter name");
//         /*string*/ emp.name=Console.ReadLine();
//         // emp=new Class1(id,name);
//     }
//     public void ShowEmployeeDetails(){
//         Console.WriteLine(emp.id);
//         Console.WriteLine(emp.name);
//     }
// }
// C c=new C();
// c.hello();
// c.show();
// class A {
//     public int x=10;
// }
// class B:A{
//     // public int x=20;
//     public void show(){x=40;Console.WriteLine(x);}
// }
// class C:B{
//     public int x=30;
//     public void hello(){
//     Console.WriteLine(base.x);
//     }
// }