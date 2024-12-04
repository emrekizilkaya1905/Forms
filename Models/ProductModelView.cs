namespace Forms.Models
{
  public class ProductModelView() 
  {
    public List<Product> Products {get;set;}=null!;
    public List<Category> Categories {get;set;}=null!;
    public string? SelectedCategory { get; set; }

  }
}