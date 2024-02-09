global using FluentValidation;
global using SharpGrip.FluentValidation.AutoValidation.Mvc.Extensions;
global using System.Text;

global using Microsoft.AspNetCore.Diagnostics;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.AspNetCore.Authentication.JwtBearer;
global using Microsoft.AspNetCore.Authorization;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.IdentityModel.Tokens;

global using Library.BLL;
global using Library.BLL.Models.DTOs;
global using Library.BLL.Models.Validators;
global using Library.BLL.Services.Implementations;
global using Library.BLL.Services.Interfaces;
global using Library.BLL.Exceptions;
global using Library.BLL.Models.Options;


global using Library.API.Extensions;
global using Library.API.Handlers;

global using Library.DAL.Data;
global using Library.DAL.Repositories.Implementations;
global using Library.DAL.Repositories.Interfaces;
global using Library.DAL.Entities;