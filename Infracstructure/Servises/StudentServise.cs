namespace Infracstructure.Servises;
using Dapper;
using Npgsql;
using Domain.Models;
using System;


public class StudentServise
{
    string constr = "Server=localhost;Port=5432;Database=DapperDemo;User Id=postgres;Password=mahmud04;";

    public List<Students> GetStudent(string name)
    {
        using (var con = new NpgsqlConnection(constr))
        {
            string sql = $"select * from student ";
            if (name != null)
            {
                sql += $"where lower(first_name) like '%{name.ToLower()}%'";
            }
            var result = con.Query<Students>(sql);
            return result.ToList();
        }
    }
    public void AddStudent(Students student)
    {
        using (var con = new NpgsqlConnection(constr))
        {
            var result = con.Execute($"insert into student(first_name,last_name,phone) " +
            $"values('{student.first_name}','{student.last_name}','{student.phone}');");
            if (result == 1)
            {
                System.Console.WriteLine("student add ");
            }
            else
            {
                System.Console.WriteLine("Error");
            }
        }

    }
    public void Delete(int a){
     using (var conn=new NpgsqlConnection(constr)){
        string sql = $"delete from student where id={a}";
         var f= conn.Execute(sql);
         if(f==1){
            System.Console.WriteLine("Student remove sucessfully");
         }else{
         System.Console.WriteLine("Error");
         }
    }

}
public void Update(int w,Students st){
     using (var conn=new NpgsqlConnection(constr)){
        string sql = $"  update student set first_name ='{st.first_name}',last_name=' {st.last_name}',age={18},phone='{st.phone}' where id={w}";
         var f= conn.Execute(sql);
         if(f==1){
            System.Console.WriteLine("Update  sucessfully");
         }else{
         System.Console.WriteLine("Error");
         }
}    
}

    public object GetStudents(string? name)
    {
        throw new NotImplementedException();
    }

}
