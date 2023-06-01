namespace Net6WebAPI.Domain
{
  public class Product
  {
    public string Id { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal ListPrice { get; set; }
    public int Stock { get; set; }

    public List<ProductPhoto> _photos = new List<ProductPhoto>();
    public IReadOnlyList<ProductPhoto> Photos => _photos;


    public void DeletePhoto(string photoId)
    {
      var photo = _photos.FirstOrDefault(x => x.Id == photoId);
      _photos.Remove(photo); // entity framework change trancker removed.
    }

  }
}
