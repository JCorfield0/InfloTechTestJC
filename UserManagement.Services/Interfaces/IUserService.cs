using System.Collections.Generic;
using UserManagement.Models;

namespace UserManagement.Services.Domain.Interfaces;

public interface IUserService 
{
    /// <summary>
    /// Return users by active state
    /// </summary>
    /// <param name="isActive"></param>
    /// <returns></returns>
    IEnumerable<User> FilterByActive(bool isActive);

    /// <summary>
    /// Returns list of all users
    /// </summary>
    /// <returns></returns>
    IEnumerable<User> GetAll();

    /// <summary>
    /// Returns a filtered or unfiltered list depending on the presence and state of the given boolean
    /// </summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    IEnumerable<User> GetList(bool? filter = null);
}
