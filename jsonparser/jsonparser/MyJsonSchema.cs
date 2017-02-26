using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;

namespace jsonparser
{
    /// <summary>
    /// Declaring your custom json schema
    /// Author: vish
    /// </summary>
    public class MyJsonSchema
    {
       
        public Element element;
        

    }

    // Describe with variable names
    public class Element
    {
        public string key { get; set; }
        public string value { get; set; }
        public string description { get; set; }

        public Object Object;
    }


    // this is example of inner node
    public class Object
    {
        public string key { get; set; }
        public string value { get; set; }
        public int checksum { get; set; }
    }
}