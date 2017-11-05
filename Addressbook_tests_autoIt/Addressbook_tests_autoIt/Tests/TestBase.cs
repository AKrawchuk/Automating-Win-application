using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Addressbook_tests_autoIt
{
    public class TestBase
    {
        public ApplicationManager app;

        [SetUp]//[TestFixtureSetUp]
        public void initApplication()
        {
            app = new ApplicationManager();
        }

        [TearDown]//[TestFixtureTearDown]
        public void stopApplication()
        {
            app.Stop();
        }
    }
}
