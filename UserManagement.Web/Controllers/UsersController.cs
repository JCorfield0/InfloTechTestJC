using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using UserManagement.Services.Domain.Interfaces;
using UserManagement.Web.Models.Users;

namespace UserManagement.WebMS.Controllers;

[Route("users")]
public class UsersController : Controller
{
    private readonly IUserService _userService;
    public UsersController(IUserService userService) => _userService = userService;


    /// <summary>
    /// Returns the default view result with an unfiltered list
    /// </summary>
    /// <returns></returns>
    [HttpGet("List")]
    public ViewResult List(bool? filter = null)
    {
        return View(new UserListViewModel(_userService.GetList(filter).Select(p => new UserListItemViewModel()
        {
            Id = p.Id,
            Forename = p.Forename,
            Surname = p.Surname,
            Email = p.Email,
            DateOfBirth = p.DateOfBirth,
            IsActive = p.IsActive
        }).ToList()));
    }


    [HttpPost("ShowAddDialog")]
    public IActionResult ShowAddDialog()
    {
        return PartialView("_AddUserDialog");
    }
}
