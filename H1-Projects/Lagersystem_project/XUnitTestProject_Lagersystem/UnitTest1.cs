using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Xunit;
using Lagersystem_project;

namespace XUnitTestProject_Lagersystem
{
    public class UnitTest1
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, Add(2, 2));
        }

        int Add(int x, int y)
        {
            return x + y;
        }

        [Fact]
        public void connection()
        {
            Database db = new Database();
            Assert.NotNull(db.connection());
        }

        [Fact]
        public void InsertProduct()
        {
            Database db = new Database();
            SqlConnection conn = db.connection();
            conn.Open();
            Assert.Equal("1 rows affected.\n", Methods_And_Functions.InsertProduct("Headset", 100, conn));
            conn.Close();
        }

    }
}
