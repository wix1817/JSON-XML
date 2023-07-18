namespace JSON_XML;

using System.Runtime.Serialization;

[DataContract]
public class Squad
{
    [DataMember]
    public string squadName { get; set; }
    [DataMember]
    public string homeTown { get; set; }
    [DataMember]
    public int formed { get; set; }
    [DataMember]
    public string secretBase { get; set; }
    [DataMember]
    public bool active { get; set; }
    [DataMember]
    public SuperHero[] members { get; set; }

    [DataContract]
    public class SuperHero
    {
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public int age { get; set; }
        [DataMember]
        public string secretIdentity { get; set; }
        [DataMember]
        public string[] powers { get; set; }
    }
}