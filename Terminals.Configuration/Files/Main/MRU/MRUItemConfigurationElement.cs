namespace Terminals.Configuration.Files.Main.MRU
{
    using System.Configuration;

    /// <summary>
    /// Most-recently-used (MRU) lists.
    /// </summary>
    public class MRUItemConfigurationElement : ConfigurationElement
    {
        public MRUItemConfigurationElement()
        {
        }

        public MRUItemConfigurationElement(string name)
        {
            this.Name = name;
        }

        [ConfigurationProperty("name", IsRequired = true)]
        public string Name
        {
            get { return (string) this["name"]; }
            set { this["name"] = value; }
        }
    }
}