namespace BeanCounter.ProjectSerializer.Services.Xml.Serializer
{
    using System;
    using System.Xml;
    using BeanCounter.ProjectModel;
    using XmlModel.Version1;
    using Base.RuntimeChecks;
    using System.Runtime.Serialization;

    /// <summary>
    /// Implements <see cref="IProjectXmlSerializer"/> for the version 1 XML model.
    /// </summary>
    public class Version1ProjectXmlSerializer : IProjectXmlSerializer
    {
        /// <summary>
        /// See <see cref="IProjectXmlSerializer.Serialize(Project, XmlWriter)"/>.
        /// </summary>
        public void Serialize(Project project, XmlWriter xmlWriter)
        {
            ArgumentChecks.AssertNotNull(project, nameof(project));
            ArgumentChecks.AssertNotNull(xmlWriter, nameof(xmlWriter));

            var xmlProject = ToXmlProject(project);
            var serializer = new DataContractSerializer(typeof(XmlProject));
            serializer.WriteObject(xmlWriter, xmlProject);
        }

        /// <summary>
        /// See <see cref="IProjectXmlSerializer.Deserialize(XmlReader)"/>.
        /// </summary>
        public Project Deserialize(XmlReader xmlReader)
        {
            throw new NotImplementedException();
        }

        private static XmlProject ToXmlProject(Project project)
        {
            // Create XML project.
            var xmlProject = new XmlProject
            {
                Id = project.Id,
                Title = project.Title,
            };

            // Create XML items.
            foreach (var item in project.Items)
            {
                var xmlItem = new XmlItem
                {
                    Id = item.Id,
                    PublicIdentifier = item.PublicIdentifier,
                    Summary = item.Summary,
                    Description = item.Description,
                    EstimatedCostOfDelayPerDay = item.EstimatedCostOfDelayPerDay,
                    EstimatedDevelopmentDurationInDays = item.EstimatedDevelopmentDurationInDays,
                };

                xmlProject.Items.Add(xmlItem);
            }

            // Create XML backlogs.
            foreach (var backlog in project.Backlogs)
            {
                var xmlBacklog = new XmlBacklog
                {
                    Id = backlog.Id,
                    Name = backlog.Name,
                };

                // Create XML backlog items.
                foreach (var backlogItem in backlog.BacklogItems)
                {
                    var xmlBacklogItem = new XmlBacklogItem
                    {
                        ItemId = backlogItem.Item.Id,
                        Rank = backlogItem.Rank,
                    };

                    xmlBacklog.BacklogItems.Add(xmlBacklogItem);
                }

                xmlProject.Backlogs.Add(xmlBacklog);
            }

            return xmlProject;
        }
    }
}
