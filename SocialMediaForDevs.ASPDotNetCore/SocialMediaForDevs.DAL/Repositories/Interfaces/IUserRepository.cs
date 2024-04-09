﻿using SocialMediaForDevs.DAL.Entities;

namespace SocialMediaForDevs.DAL.Repositories.Interfaces;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetUsersAsync();
    Task<User> GetUserByIdAsync(int id);
    Task<User> CreateUserAsync(User user);
    Task<User> UpdateUserAsync(User user);
    Task<User> DeleteUserAsync(int id);
}
