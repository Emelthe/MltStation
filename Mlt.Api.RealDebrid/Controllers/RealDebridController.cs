using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Mlt.Api.Base.Controllers;
using Mlt.Api.RealDebrid.Services;
using Mlt.Models.Torrent;

namespace Mlt.Api.RealDebrid.Controllers;

public class RealDebridController : BaseController
{
    private readonly IMapper _mapper;
    private readonly IRealDebridService _realDebridService;

    public RealDebridController(IMapper mapper, IRealDebridService realDebridService)
    {
        _mapper = mapper;
        _realDebridService = realDebridService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
        => await HandleServiceCallErrorsAsync(async ()
                                                  => _mapper.Map<List<Torrent>>(await _realDebridService
                                                                                   .Torrents(Request.QueryString
                                                                                                    .Value!)));
}