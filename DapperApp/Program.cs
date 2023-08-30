using Domain.Models;
using Infracstructure.Servises;
var ct = new StudentServise();
var tch = new TeacherServise();
while (true)
{
    int d;
    System.Console.WriteLine("1: Teachers");
    System.Console.WriteLine("1: Student");
    d = Convert.ToInt32(Console.ReadLine());
    if (d == 1)
    {
        while (true)
        {
            int n;
            System.Console.WriteLine();
            System.Console.WriteLine("1 for get teacher");
            System.Console.WriteLine("2 for add teacher");
            System.Console.WriteLine("3 for delete teacher");
            System.Console.WriteLine("4 for update teacher");
            System.Console.WriteLine("5 for exet program");
            System.Console.WriteLine();
            n = Convert.ToInt32(Console.ReadLine());
            if (n == 1)
            {
                string name;
                name = Console.ReadLine();
                var lis = tch.GetTeacher(name);
                System.Console.WriteLine("id----------firstname---------lastname----------specialty-----------age------------salary");
                foreach (var i in lis)
                {
                    System.Console.WriteLine();
                    System.Console.WriteLine($"{i.id}    |   {i.first_name}     |     {i.last_name}     |     {i.specialty}    |    {i.age}     |     {i.salary}");

                }
            }
            else if (n == 2)
            {
                var tc = new Teacher();
                System.Console.Write("firstname:");
                tc.first_name = Console.ReadLine();
                System.Console.Write("lastname:");
                tc.last_name = Console.ReadLine();
                System.Console.Write("specialty:");
                tc.specialty = Console.ReadLine();
                System.Console.Write("age:");
                tc.age = Convert.ToInt16(Console.ReadLine());
                System.Console.Write("salary:");
                tc.salary = Convert.ToInt16(Console.ReadLine());
                System.Console.WriteLine();
                tch.Add(tc);
            }else if(n==3){
                int y;
                y=Convert.ToInt32(Console.ReadLine());
                tch.Delete(y);
            }else if(n==4){
                int y;
                var t =new Teacher();
                System.Console.Write("id: ");
                y=Convert.ToInt32(Console.ReadLine());
                System.Console.Write("firstname:");
                t.first_name = Console.ReadLine();
                System.Console.Write("lastname:");
                t.last_name = Console.ReadLine();
                System.Console.Write("specialty:");
                t.specialty = Console.ReadLine();
                System.Console.Write("age:");
                t.age = Convert.ToInt16(Console.ReadLine());
                System.Console.Write("salary:");
                t.salary = Convert.ToInt16(Console.ReadLine());
                System.Console.WriteLine();
                tch.Update(y,t);
            }else if(n==5){
                break;
            }
        }

    }
    if (d == 2)
    {
        while (true)
        {
            int s;
            System.Console.WriteLine();
            System.Console.WriteLine("1 for get student");
            System.Console.WriteLine("2 for add student");
            System.Console.WriteLine("3 for delete student");
            System.Console.WriteLine("4 for update student");
            System.Console.WriteLine("5 for exet program");
            System.Console.WriteLine();
            s = Convert.ToInt32(Console.ReadLine());
            if (s == 1)
            {
                string name;
                name = Console.ReadLine();
                var lis = ct.GetStudent(name);
                System.Console.WriteLine("id----------firstname---------lastname----------phone");
                foreach (var i in lis)
                {
                    System.Console.WriteLine();
                    System.Console.WriteLine($"{i.Id}    |   {i.first_name}     |     {i.last_name}     |     {i.phone}");

                }
            }
            else if (s == 2)
            {
                string a, b, c;
                var ct1 = new Students();
                System.Console.Write("firstname:");
                ct1.first_name = Console.ReadLine();
                System.Console.Write("lastname:");
                ct1.last_name = Console.ReadLine();
                System.Console.Write("phone:");
                ct1.phone = Console.ReadLine();
                System.Console.WriteLine();
                ct.AddStudent(ct1);
                System.Console.WriteLine();
            }
            else if (s == 3)
            {
                int t = 0;
                t = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine();
                ct.Delete(t);
                System.Console.WriteLine();

            }
            else if (s == 4)
            {
                int l;
                System.Console.Write("id: ");
                l = Convert.ToInt32(Console.ReadLine());

                var st = new Students();
                System.Console.Write("firstname: ");
                st.first_name = Console.ReadLine();
                System.Console.Write("lastname: ");
                st.last_name = Console.ReadLine();
                Console.Write("phone: ");
                st.phone = Console.ReadLine();
                System.Console.WriteLine();
                ct.Update(l, st);
                System.Console.WriteLine();
            }
            else if (s == 5)
            {
                break;
            }

        }
    }
}