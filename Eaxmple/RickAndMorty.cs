using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Character
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Status { get; set; }
    public string? Species { get; set; }
    public string? Type { get; set; }
    public string? Gender { get; set; }
}

public class Location
{
    public string? Name { get; set; }
    public string? Url { get; set; }
}

public class RootObject
{
    public List<Character>? Results { get; set; }
}
