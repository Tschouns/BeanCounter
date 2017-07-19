namespace BeanCounter.ProjectSerializer.Xml
{
    using BeanCounter.ProjectModel;

    /// <summary>
    /// Provides methods to write a <see cref="Project"/> to an XML file, or load
    /// one from an XML file.
    /// </summary>
    public interface IProjectXmlFileService
    {
        /// <summary>
        /// Loads a project from an XML file at the specified path.
        /// </summary>
        Project LoadProjectFromFile(string path);

        /// <summary>
        /// Writes the specified <see cref="Project"/> to an XML file at the specified path.
        /// </summary>
        void WriteProjectToFile(Project project, string path);
    }
}
