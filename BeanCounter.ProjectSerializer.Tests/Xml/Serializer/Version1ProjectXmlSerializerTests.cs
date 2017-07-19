namespace BeanCounter.ProjectSerializer.Tests.Xml.Serializer
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Services.Xml.Serializer;
    using System.Xml;
    using System.Text;
    using System.IO;
    using ProjectModel;
    using System.Diagnostics;

    /// <summary>
    /// Tests the <see cref="Version1ProjectXmlSerializer"/>.
    /// </summary>
    [TestClass]
    public class Version1ProjectXmlSerializerTests
    {
        [TestMethod]
        public void Serialize_EmptyProject_XmlStringContainsProjectElements()
        {
            // Arrange
            var candidate = new Version1ProjectXmlSerializer();

            var sampleProject = CreateSampleProject();

            var xmlStringBuilder = new StringBuilder();
            var xmlTextWriter = new XmlTextWriter(new StringWriter(xmlStringBuilder));

            // Act
            candidate.Serialize(sampleProject, xmlTextWriter);

            // Assert
            var xmlString = xmlStringBuilder.ToString();

            Assert.IsTrue(xmlString.Contains("<Id>"));
            Assert.IsTrue(xmlString.Contains("<Title>"));

            Assert.IsTrue(xmlString.Contains(sampleProject.Id.ToString()));
            Assert.IsTrue(xmlString.Contains(sampleProject.Title));
        }

        private static Project CreateSampleProject()
        {
            var project = new Project(Guid.Parse("4557bea7-c5ad-4e64-b5b9-9bd2cd5a7c95"))
            {
                Title = "Manhatten Project"
            };

            // Add items.
            var item1 = new Item(Guid.Parse("ab1f3206-602c-457b-8747-5d7f5c3a0fa0"))
            {
                PublicIdentifier = "Uno",
                Summary = "El Numero Uno",
                Description = "This is the first item in the project.",
                EstimatedCostOfDelayPerDay = 1.5m,
                EstimatedDevelopmentDurationInDays = 30
            };

            var item2 = new Item(Guid.Parse("4557a9cc-360e-4bd1-8ff0-e7c24d40ca9a"))
            {
                PublicIdentifier = "Due",
                Summary = "El Numero Due",
                Description = "This is the second item in the project.",
                EstimatedCostOfDelayPerDay = 0.4m,
                EstimatedDevelopmentDurationInDays = 12
            };

            project.Items.Add(item1);
            project.Items.Add(item2);

            // Add a backlog.
            var backlog = new Backlog(Guid.Parse("38df6656-5a16-41b1-aba8-bc21eaf0d5c9"))
            {
                Name = "Features"
            };

            backlog.BacklogItems.Add(new BacklogItem(item1)
            {
                Rank = 2
            });

            backlog.BacklogItems.Add(new BacklogItem(item2)
            {
                Rank = 1
            });

            project.Backlogs.Add(backlog);

            return project;
        }
    }
}
