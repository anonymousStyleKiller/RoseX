using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace RoseX.Server.Controller.Base;

[ApiController]
[Route("api/[controller]")]
public class ApplicationController<T> : ControllerBase
{
    private ILogger<T> _logger;
    private IMediator _mediator;

    protected ILogger<T> Logger => _logger ??= HttpContext.RequestServices.GetService<ILogger<T>>();
    protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
}