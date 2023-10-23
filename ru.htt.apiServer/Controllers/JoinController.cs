using Microsoft.AspNetCore.Mvc;
using ru.htt.apiServer.Core.Abstractions.Repositories;
using ru.htt.apiServer.Core.Domain;
using ru.htt.apiServer.Models;

namespace ru.htt.apiServer.Controllers; 
/// <summary>
/// Join запрос
/// </summary>
[ApiController]
[Route("api/v1/[controller]")]
public class JoinController: ControllerBase  {
    private readonly IRepository<JoinRequest> _joinRequestRepository;

    public JoinController(IRepository<JoinRequest> joinRepository) {
        _joinRequestRepository = joinRepository;
    }
    /// <summary>
    /// Получить join
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<ActionResult<List<JoinResponse>>> GetJoinAsync()
    {
        var join = await _joinRequestRepository.GetJoinAsync();
        var joinResponse = join.Select(x => new JoinResponse() {
            CategoryName = x.CategoryName,
            ProductName = x.ProductName,
            Price = x.Price
        }).ToList();
        return Ok(joinResponse);
    }
}