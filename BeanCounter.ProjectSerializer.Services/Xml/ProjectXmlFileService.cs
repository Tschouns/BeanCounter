namespace BeanCounter.ProjectSerializer.Services.Xml
{
    using System;
    using ProjectModel;
    using BeanCounter.ProjectSerializer.Xml;

    /// <summary>
    /// See <see cref="IProjectXmlFileService"/>.
    /// </summary>
    public class ProjectXmlFileService : IProjectXmlFileService
    {
        /// <summary>
        /// See <see cref="IProjectXmlFileService.LoadProjectFromFile(string)"/>.
        /// </summary>
        public Project LoadProjectFromFile(string path)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// See <see cref="IProjectXmlFileService.WriteProjectToFile(Project, string)"/>.
        /// </summary>
        public void WriteProjectToFile(Project project, string path)
        {
            throw new NotImplementedException();
        }
    }
}
