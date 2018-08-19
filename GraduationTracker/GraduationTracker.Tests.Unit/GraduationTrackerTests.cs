using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace GraduationTracker.Tests.Unit
{
    [TestClass]
    public class GraduationTrackerTests
    {
        [TestMethod]
        public void IntegrationTestHasCredits()
        {
						var tracker = new GraduationTracker();

						var diploma = Repository.GetDiploma(1);
						
						var students = new[]
						{
								Repository.GetStudent(1),
								Repository.GetStudent(2),
								Repository.GetStudent(3),
								Repository.GetStudent(4)
						};
            
            var graduated = new List<Tuple<bool, STANDING>>();

            foreach(var student in students)
            {
                graduated.Add(tracker.HasGraduated(diploma, student));      
            }
						
            Assert.IsTrue(graduated.Any());

        }

				[TestMethod]
				public void IntegrationTestGraduationFailure()
				{
						var tracker = new GraduationTracker();

						var diploma = Repository.GetDiploma(1);

						var students = new[]
						{
								Repository.GetStudent(1),
								Repository.GetStudent(2),
								Repository.GetStudent(3),
								Repository.GetStudent(4)
						};

						var graduated = new List<Tuple<bool, STANDING>>();

						foreach (var student in students) {
								graduated.Add(tracker.HasGraduated(diploma, student));
						}

						Assert.IsFalse(graduated.Any(m => m.Item2 == STANDING.None));

				}
		}
}
