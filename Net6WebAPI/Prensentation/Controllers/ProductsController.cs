using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Net6WebAPI.Application.Dtos.Criteria;
using Net6WebAPI.Application.Dtos.Product;
using Net6WebAPI.Application.Features.Product.StockIn;
using Net6WebAPI.Application.Features.Product.StockOut;

namespace Net6WebAPI.Prensentation.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ProductsController : ControllerBase
  {
    //private readonly IStockInService stockInService;
    //private readonly IStockOutService stockOutService;
    //private readonly IServiceProvider provider;
    //private readonly IConfiguration configuration;
    private readonly IMediator mediator;
   

    // Mediator davranışsal tasarım deseni, nensler arasındaki kaotik ilişkilerin merkezi olarak yönetilmesine imkan tanıyan bir davranışsal tasarım deseni.

    //public ProductsController(IStockInService stockInService, IStockOutService stockOutService, IServiceProvider serviceProvider, IConfiguration configuration, IMediator mediator)
    //{
    //  this.stockInService = stockInService;
    //  this.provider = serviceProvider;
    //  this.configuration = configuration;
    //  this.mediator = mediator;
    //  this.stockOutService = stockOutService;

    //}


    public ProductsController( IMediator mediator)
    {

      this.mediator = mediator;


    }

    [HttpPost]
    public IActionResult Create([FromBody] ProductCreateDto dto)
    {
      
     

     

     
      return Created("", dto); // 201
    }

    [HttpPut("changePrice/{id}")] // update işlemi /api/products/update?productId=12123213, /api/products/update/23342423
    public IActionResult ChangePrice([FromRoute] string id, [FromBody] ProductChangePriceDto dto)
    {
      return NoContent(); // 204 işlemi yaptım sonuç döndürmüyoruz.

    }


    [HttpPut("stockIn/{id}")] // update işlemi /api/products/update?productId=12123213, /api/products/update/23342423
    public async Task<IActionResult>  StockIn([FromRoute] string id, [FromBody] StockInDto dto)
    {

      IStockInService iss = null;

      //  if (this.configuration.GetSection("StockInType").Value == "Default")

      //if (dto.StockType == "Default")
      //{
      //  iss = this.provider.GetRequiredService<DefaultStockInService>();
      //}
      //else
      //{
      //  iss = this.provider.GetRequiredService<UniversalStockInService>();
      //}


      //await iss.StockIn(dto);

     //await stockInService.StockIn(dto);

      await this.mediator.Send(dto);


      return NoContent(); // 204 işlemi yaptım sonuç döndürmüyoruz.

    }

    [HttpPut("stockOut/{id}")] // update işlemi /api/products/update?productId=12123213, /api/products/update/23342423
    public async Task<IActionResult> StockOut([FromRoute] string id, [FromBody] StockOutDto dto)
    {
      //await this.stockOutService.StockOut(dto);


      await this.mediator.Send(dto);



      return NoContent(); // 204 işlemi yaptım sonuç döndürmüyoruz.

    }


    [HttpDelete]
    public async Task<IActionResult> Delete([FromQuery] string id, [FromHeader] string reason)
    {


      var dto = new ProductDeleteDto();
      dto.ProductId = id;
      dto.Reason = reason;

      await this.mediator.Send(dto);

      // Delete 204 No Content result döner.
      return NoContent();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Detail(string id)
    {
      var model = new ProductDetailDto();

      return Ok(model); // status code 200
    }

    [HttpGet("{barcode}/{qrcode}")]
    public async Task<IActionResult> Detail2(string barcode, string qrcode)
    {
      var model = new ProductDetailDto();

      return Ok(model); // status code 200
    }


    // api/makaleler
    // api/makaleler/1 1 nolu makale
    // APİ/MAKALELER/1/yorumlar 1 nolu makale yorumları
    // api/makaleler/1/yorumlar/3 1 nolu makalenin 3 nolu yorumu
    // api/makaleler/1/yorumlar/3/oy 1 nolu makakenin 3 nolu yorumuna ait oylama puanı

    [HttpDelete("{productId}/photos/{photoId}")]
    public IActionResult DeletePhoto(string productId, string photoId)
    {
      return NoContent();
    }




    [HttpGet] // api/products?searchText=ali&orderBy=name desc&page=1&limit=10;
    public async Task<IActionResult> List([FromQuery] CriteriaDto dto)
    {
      // var p = ProductRepository.Find(id);
      // p.Photos.DeletePhoto("1234");
      // ProductRepository.Save();


      var model = new List<ProductDetailDto>();

      return Ok(model); // status 200
    }







  }
}
