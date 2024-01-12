using EightToTen.Services.Eight;
using Microsoft.AspNetCore.Mvc;

namespace EightToTen.Controllers;
[ApiController]
[Route("[controller]")]
public class EightController
{
    private readonly IEightServices _eightServices;

    public EightController(IEightServices eightServices)
    {
        _eightServices = eightServices;
    }
[HttpGet]
[Route ("magicEight/{question}")]
public string EightBall()
    {
        return _eightServices.EightBall();
    }
}