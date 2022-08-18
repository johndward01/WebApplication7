namespace WebApplication7.Models.Aviation;

public class Request
{
    public string lang { get; set; }
    public string currency { get; set; }
    public int time { get; set; }
    public string id { get; set; }
    public string server { get; set; }
    public string host { get; set; }
    public int pid { get; set; }
    public Key key { get; set; }
    public Params _params { get; set; }
public int version { get; set; }
public string method { get; set; }
public Client client { get; set; }
}

