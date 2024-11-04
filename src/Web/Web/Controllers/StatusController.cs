// Copyright © BEN ABT (www.benjamin-abt.com) 2021-2022 - all rights reserved

using BenjaminAbt.MyDemoPlatform.Engine.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Providers.Status.Engine.Queries;

namespace Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StatusController : ControllerBase
{
    private readonly IEventDispatcher _eventDispatcher;

    public StatusController(IEventDispatcher eventDispatcher)
    {
        _eventDispatcher = eventDispatcher;
    }

    [HttpGet]
    public async Task<IActionResult> Get(CancellationToken cancellationToken)
    {
        var status = await _eventDispatcher.Get(new GetStatusQuery(), cancellationToken);
        return Ok(status);
    }
}
