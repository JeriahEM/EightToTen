using EightToTen.Services.Ten;
using Microsoft.AspNetCore.Mvc;

namespace EightToTen.Controllers;
[ApiController]
[Route("controller/{random}")]
public class TenController

{
    private readonly ITenServices _tenServices;

    public TenController(ITenServices tenServices)
    {
        _tenServices = tenServices;
    }
[HttpGet]
[Route("restPickBurg")]
public string pickRestBurg()
{
return _tenServices.pickRestBurg();
}



[HttpGet]
[Route("restPickChick")]
public string pickRestChick()
{
return _tenServices.pickRestChick();
}

[HttpGet]
[Route("restPickPizza")]
public string pickRestPizza()
{
return _tenServices.pickRestPizza();
}
}