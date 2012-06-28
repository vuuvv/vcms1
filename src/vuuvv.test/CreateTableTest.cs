using vuuvv.data.expressions.ddl;
using vuuvv.data.schema;
using vuuvv.data.types;
using vuuvv.data.visitors;


using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace vuuvv.test
{
    
    
    /// <summary>
    ///This is a test class for CreateTableTest and is intended
    ///to contain all CreateTableTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CreateTableTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for CreateTable Constructor
        ///</summary>
        [TestMethod()]
        public void CreateTableConstructorTest()
        {
            MetaData meta = new MetaData();
            Table table = new Table("test", meta,
                new Column("id", new Integer()),
                new Column("name", new String()));
            CreateTable stmt = new CreateTable(table);
            DDLCompiler compiler = new DDLCompiler();
            Assert.AreEqual("", compiler.visit(stmt));
        }
    }
}
