using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationTracker.Tests.Unit
{
		//The following are unit tests for the repository class
		[TestClass]
		public class RepositoryTests
		{
				[TestMethod]
				public void UnitTestIsStudentValid(){
						var s = Repository.GetStudent(3);
						Assert.IsTrue(s != null);
						Assert.IsTrue(s.Courses.Any(m => m.Mark >= 0));
						Assert.IsTrue(s.Courses.Any(m => m.Mark <= 100));
				}
				[TestMethod]
				public void UnitTestIsDiplomaValid()
				{
						var d = Repository.GetDiploma(1);
						Assert.IsTrue(d != null);
						Assert.IsTrue(d.Credits > 0);

				}
				[TestMethod]
				public void UnitTestIsRequirementValid()
				{
						var r = Repository.GetRequirement(102);
						Assert.IsTrue(r != null);
						Assert.IsTrue(r.MinimumMark > 49);
				}
		}
}
