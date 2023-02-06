﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;


// Этот проект осуществляет хранение пользователей и дает доступ к методам для аутентификации,
// регистрации и управления аккаунтами, используя Identity и EntityFramework
// Для работы необходимо создать свой класс пользователя, наделив его нужными для приложения полями, создать
// класс DbContext для доступа к бд через EF и запустить необходимые миграции через консоль пакетов.


namespace RazorPages.Identity.Classes;

/// <summary>
/// Пользователь. Наследует базового пользователя из Identity
/// </summary>
public class User : IdentityUser
{
    /// <summary>
    /// Имя, показываемое для остальных пользователей.
    /// </summary>
    [Required]
    public string DisplayName { get; set; }

    public int CoinBalance { get; set; }
}