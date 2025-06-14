﻿using Microsoft.AspNetCore.Identity;

namespace ContainRs.Api.Identity;

public class AcessoManagerWithIdentity(UserManager<AppUser> userManager) : IAcessoManager
{
    private readonly UserManager<AppUser> _userManager = userManager;

    public async Task AdicionarClienteAsymc(string email, CancellationToken cancellationToken)
    {
        var user = await _userManager.FindByNameAsync(email);
        if (user is null) 
        { 
            user = new AppUser
            { 
                UserName = email,
                Email = email 
            };

            await _userManager.CreateAsync(user, "Alura@123");
            await _userManager.AddToRoleAsync(user, "Cliente");
        }
        user.EmailConfirmed = true;
        await _userManager.UpdateAsync(user);
    }

    public async Task BloquearClienteAsync(string email, CancellationToken cancellationToken)
    {
        var user = await _userManager.FindByEmailAsync(email);

        if (user is null) 
            return;

        await _userManager.DeleteAsync(user);
    }

    public async Task<bool?> ClientePossuiAcessoAsync(string email, CancellationToken cancellationToken)
    {
        var user = await _userManager.FindByEmailAsync(email);
        if (user is null) 
            return null;

        return user.EmailConfirmed;
    }

    public async Task RemoveClienteasync(string email, CancellationToken cancellationToken)
    {
        var user = await _userManager.FindByEmailAsync(email);
        if (user is null) return;

        user.EmailConfirmed = false;
        await _userManager.UpdateAsync(user);
    }
}