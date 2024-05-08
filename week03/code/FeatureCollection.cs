public class FeatureCollection {
    // Todo Earthquake Problem - ADD YOUR CODE HERE
    // Create additional classes as necessary

    public string Type {get; set; } = "FeatureCollection";
    public Metadata metadata {get; set;}
    public List<Feature> Features {get; set;}
}

//Data set of the API Metadata
public class Metadata
{
    public long generated {get; set;}
    public string url {get; set;}
    public string title {get; set;}
    public string api {get; set;}
    public int count {get; set;}
    public int status {get; set;}
}

public class Feature
{
    //Defines which field will pick from Features
    public string type {get; set;}
    public Properties properties {get; set;}
    public Geometry geometry {get; set;}
    public string Id {get; set;}
}

public class Properties 
{
    //Defines what information you want from the API
    public decimal mag {get; set;}
    public string place {get; set;}
}

public class Geometry
{
    public string type {get; set;}
    public List<decimal> coordinates {get; set;} //longitude and latitude
}