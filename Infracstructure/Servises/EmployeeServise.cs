using Npgsql;
using Dapper;
using Domain.Models;


namespace Infracstructure.Servises;

public class EmployeeServise
{
    class pers
    {

        public int Id { get; set; }
    }
    string constr="Server=localhost;Port=5432;Database=DapperDemo;User Id=postgres;Password=mahmud04;";
    public List<Employee>  Get(string t){
    using ( var con =new NpgsqlConnection(constr))
    {
        string sql="select * from Employee ";
        if(t!=null){
            sql+=$"where lower(first_name) like '%{t.ToLower()}%'";
         }
        var result =con.Query<Employee>(sql);
        return result.ToList();
      }
    }
    async public void Add(Employee e){
 await using( var con = new NpgsqlConnection(constr)){
var sql =$"insert into Employee(first_name,last_name,age,salary)values('{e.first_name}','{e.last_name}','{e.age}','{e.salary}')";
   var result =con.Execute(sql);
   if(result==1){
    System.Console.WriteLine("Employee Add");
   }else{
   System.Console.WriteLine("Error");}
  
}
}
public string Update(Employee q){
    using (var con =new NpgsqlConnection(constr)){
var sql =$"Update Employee set first_name = '{q.first_name}', last_name = '{q.last_name}',age = {q.age} , salary = {q.salary} where id= {q.id}";
    var result = con.Execute(sql);
    if (result==1){
       return "Update sucessfully";
    }else{
        return "Error";
    }
    }
}
public string Delete(int q){
    using (var con =new NpgsqlConnection(constr)){
        var sql =$"Delete from Employee where id={q}";
        var result =con.Execute(sql);
        if(result==1){
            return "Employee delete";
        }
        return "Error";
    }
}
public List<Employee> GetById(int id){
    using (var con = new NpgsqlConnection(constr)){
        var sql = $"select * from Employee where id={id}";
          var result =con.Query<Employee>(sql);
          return result.ToList();

    }
}
}

