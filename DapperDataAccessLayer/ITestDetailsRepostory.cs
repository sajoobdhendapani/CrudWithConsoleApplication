using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;


namespace DapperDataAccessLayer
{
    public interface ITestDetailsRepostory
    {
        public TestDetails InsertSP(TestDetails details);
        public IEnumerable<TestDetails> ReadSP();
        public TestDetails DeleteSP(long Id);
        public TestDetails UpdateSP(long Id, TestDetails UptdDetails);
    }
}
