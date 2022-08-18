namespace WebApplication7.Models.Aviation;

public class Key
{
    public int id { get; set; }
    public string api_key { get; set; }
    public string type { get; set; }
    public string expired { get; set; }
    public string registered { get; set; }
    public int limits_by_hour { get; set; }
    public int limits_by_minute { get; set; }
    public int limits_by_month { get; set; }
    public int limits_total { get; set; }
}

