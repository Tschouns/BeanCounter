namespace BeanCounter.ProjectSerializer.Tests.Xml.Serializer
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Services.Xml.Serializer;
    using System.Xml;
    using System.Text;
    using System.IO;
    using ProjectModel;

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

            var projectId = Guid.NewGuid();
            var projectTitle = "Manhatten Project";

            var project = new Project(projectId)
            {
                Title = projectTitle
            };

            var xmlStringBuilder = new StringBuilder();
            var xmlTextWriter = new XmlTextWriter(new StringWriter(xmlStringBuilder));

            // Act
            candidate.Serialize(project, xmlTextWriter);

            // Assert
            var xmlString = xmlStringBuilder.ToString();

            Assert.IsTrue(xmlString.Contains("<Id>"));
            Assert.IsTrue(xmlString.Contains("<Title>"));

            Assert.IsTrue(xmlString.Contains(projectId.ToString()));
            Assert.IsTrue(xmlString.Contains(projectTitle));
        }
    }
}
