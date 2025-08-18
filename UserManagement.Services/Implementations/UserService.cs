using System;
using System.Collections.Generic;
using System.Linq;
using UserManagement.Data;
using UserManagement.Models;
using UserManagement.Services.Domain.Interfaces;

namespace UserManagement.Services.Domain.Implementations;

public class UserService : IUserService
{
    private readonly IDataContext _dataAccess;
    public UserService(IDataContext dataAccess) => _dataAccess = dataAccess;


    public IEnumerable<User> FilterByActive(bool isActive) => _dataAccess.GetAll<User>().Where(user => user.IsActive == isActive);
    public IEnumerable<User> GetAll() => _dataAccess.GetAll<User>();
    public IEnumerable<User> GetList(bool? filter = null)
    {
        if (filter == null) return GetAll();

        return FilterByActive((bool)filter);
    }
}
