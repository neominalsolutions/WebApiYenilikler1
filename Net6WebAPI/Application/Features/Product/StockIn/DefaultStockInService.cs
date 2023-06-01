using Net6WebAPI.Application.Dtos.Product;

namespace Net6WebAPI.Application.Features.Product.StockIn
{
  // Ülke sınırlar içerisinde firmalardan alınan malların procudürel işlemleri için
  public class DefaultStockInService : IStockInService
  {
    // Application Katmanı Facade Design Pattern uygulamış olur.
    // private readonly ProductRepository
    // private readonly EmailService
    // private ready CriticalStockControlService
    public async Task StockIn(StockInDto stockInDto)
    {

      // Prensentation Katmanı işi başlatır. => Application Katmanına işi devereder. Application katmanı operasyonun sonucunu döndüren. Operasyona ait validatosyonları kontrol eden. Operasyona ait hata durumlarını kontrol eden bir katman. Koordinasyondan sorumlu
      // eğer ki bu katmanda bir bussiness rule varsa o kural entity üzerinden aşağıdaki gibi uygulanmalıdır.

      // if(stockInDto.isValid){}

      // var p = productRepo.find(stockInDto.ProductId);

      // if( p == null)
      // throw new Exception("Ürün bulunamadı");

      // p.stock.Amount+= stockInDto.amount;
      // p.StockIn(stockInDto.Amount); // Bussiness Rule yoksa direct crud bazlı insert,update,delete

      // if(stockInDto.Stock < stockInDto.amount){} Bussiness katmanı devre dışı application tüm kod logiclerinden sorumlu
      // AppDbContext.Products.Add(p);


      throw new NotImplementedException();
    }
  }
}
