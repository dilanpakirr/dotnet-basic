namespace dotnet_basics.Models;

public class Product
{

    public int id { get; set; }
    public string? productName { get; set; }
    public string? productDescription { get; set; }
    public double? productPrice { get; set; }
    public bool productStatus { get; set; }

}