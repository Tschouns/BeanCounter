namespace BeanCounter.ProjectSerializer.Services.Xml.Serializer
{
    using BeanCounter.ProjectModel;
    using System.Xml;

    /// <summary>
    /// Serializes / deserializes a <see cref="Project"/> instance to / from an XML stream.
    /// </summary>
    public interface IProjectXmlSerializer
    {
        /// <summary>
        /// Serializes the specified <see cref="Project"/> via the specified <see cref="XmlWriter"/>.
        /// </summary>
        void Serialize(Project project, XmlWriter xmlWriter);

        /// <summary>
        /// Deserialize a <see cref="Project"/> via the specified <see cref="XmlReader"/>.
        /// </summary>
        /// <param name="xmlReader"></param>
        /// <returns></returns>
        Project Deserialize(XmlReader xmlReader);
    }
}
