using MstGrades.Logins;
using MstGrades.Models;
using MstGrades.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MstGrades.Repositories
{
    public class SqlGradeRespository : IGradeRepository
    {
        public DataTable GetAll()
        {
            string connectionstring = "Data Source=.\\sqlexpress;Initial Catalog=StudManagement;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            var con = new SqlConnection(connectionstring);
            var da = new SqlDataAdapter(@"SELECT * FROM dbo.MstGrades", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void AddGrade(Grade grade)
        {
            string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=StudManagement;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            string query = @"INSERT INTO dbo.MstGrades 
                         (GradeName, Description, ActiveStatus,CreatedBy)
                         VALUES 
                         (@GradeName, @Description, @ActiveStatus,@CreatedBy)";

            var conn = new SqlConnection(connectionString);
            var cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@GradeName", grade.GradeName);
            cmd.Parameters.AddWithValue("@Description", grade.Description);
            cmd.Parameters.AddWithValue("@ActiveStatus", grade.ActiveStatus);
            cmd.Parameters.AddWithValue("@CreatedBy", Session.CurrentUser);
            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public void UpdateGrade(Grade grade)
        {
            string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=StudManagement;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            string query = @"UPDATE dbo.MstGrades 
                         SET GradeName = @GradeName, 
                             Description = @Description, 
                             ActiveStatus = @ActiveStatus
                         WHERE GradeID = @GradeID";
            var conn = new SqlConnection(connectionString);
            var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@GradeID", grade.GradeID);
            cmd.Parameters.AddWithValue("@GradeName", grade.GradeName);
            cmd.Parameters.AddWithValue("@Description", grade.Description);
            cmd.Parameters.AddWithValue("@ActiveStatus", grade.ActiveStatus);
            conn.Open();
            cmd.ExecuteNonQuery();
        }
        public void DeleteGrade(int gradeID)
        {
            string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=StudManagement;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            string query = @"DELETE FROM dbo.MstGrades WHERE GradeID = @GradeID";
            var conn = new SqlConnection(connectionString);
            var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@GradeID", gradeID);
            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
