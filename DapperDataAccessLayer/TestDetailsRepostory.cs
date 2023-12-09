using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

namespace DapperDataAccessLayer
{
   public class TestDetailsRepostory:ITestDetailsRepostory
    {
        public TestDetails InsertSP(TestDetails details)
        {
            try
            {
                var connectionString = "Data source=DESKTOP-CC47JG8\\SQLEXPRESS;initial catalog=Batch7;user id=sa;password=Anaiyaan@123;";

                var con = new SqlConnection(connectionString);
                con.Open();
                con.Execute($"exec InsertTeasDetails @Name='{details.Name}',@Number={details.Number},@Duration={details.Duration},@Score={details.Score},@StartDate='{details.StartDate.ToString("MM-dd-yyyy")}'");
                con.Close();

            }
            catch (SqlException sql)
            {
                throw;

            }
            catch (Exception ex)
            {
                throw;
            }
            return details;
          
        }
        public IEnumerable<TestDetails>ReadSP()
        {
            try
            {
                var connectionString = "Data source=DESKTOP-CC47JG8\\SQLEXPRESS;initial catalog=batch7;user id=sa;password=Anaiyaan@123;";

                var con = new SqlConnection(connectionString);
                con.Open();
                var TestDetails = con.Query<TestDetails>($"exec ReadAllTestDetails ");
                con.Close();


                return TestDetails.ToList();

            }
            catch (SqlException sql)
            {
                throw;

            }
            catch (Exception ex)
            {
                throw;
            }
            
        }
        public TestDetails DeleteSP(long Id)
        {
            try
            {
                var connectionString = "Data source=DESKTOP-CC47JG8\\SQLEXPRESS;initial catalog=batch7;user id=sa;password=Anaiyaan@123;";

                var con = new SqlConnection(connectionString);
                con.Open();
                var TestDetails = con.QueryFirstOrDefault<TestDetails>($"exec DeleteTestDetails @Id={Id}");
                con.Close();
                return TestDetails;
            }
            catch(SqlException ex)
            {
                throw;
            }
            catch(Exception ex)
            {
                throw;
            }
            
        }
        public TestDetails UpdateSP(long Id)
        {
            try
            {
                var connectionString = "Data source=DESKTOP-CC47JG8\\SQLEXPRESS;initial catalog=batch7;user id=sa;password=Anaiyaan@123;";
                var con = new SqlConnection(connectionString);
                con.Open();
                var TestDetails = con.QueryFirstOrDefault<TestDetails>($"exec Updateproduct @Id={Id},@name='{TestDetails.Name}',@number={prds.Number},@price={prds.Price},@gst={prds.Gst},@expirydate='{prds.ExpiryDate.ToString("MM-dd-yyyy")}'");
                var 
                ;

            }
            catch (SqlException sql)
            {
                throw;

            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
