using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Addressbook_tests_autoIt
{
    public class GroupDeleteTests : TestBase
    {
        [Test]
        public void TestGroupDelete()
        {
            List<GroupData> oldGroups = app.Groups.GetGroupList();
            app.Groups.Delete(0);

            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.RemoveAt(0);

            oldGroups.Sort();
            newGroups.Sort();

            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
