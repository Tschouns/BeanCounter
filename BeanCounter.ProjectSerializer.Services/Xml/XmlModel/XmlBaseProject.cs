namespace BeanCounter.ProjectSerializer.Services.Xml.XmlModel
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Base class for an XML project, which contains the XML model version info.
    /// </summary>
    [DataContract(Name = "Project", Namespace = "http://www.github.com/tschouns/beancounter")]
    public abstract class XmlBaseProject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XmlBaseProject"/> class.
        /// </summary>
        protected XmlBaseProject(string versionInfo)
        {
            this.VersionInfo = versionInfo;
        }

        /// <summary>
        /// Gets or sets the version info.
        /// </summary>
        [DataMember]
        public string VersionInfo { get; set; }
    }
}
