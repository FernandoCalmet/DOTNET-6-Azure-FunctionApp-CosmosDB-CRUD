﻿global using EFCoreFunctionApp.Infrastructure;
global using EfCoreFunctionApp.Commands.UserCommand;
global using EfCoreFunctionApp.ValueObjects.UserAggregate;
global using EfCoreFunctionApp.Contracts;
global using EfCoreFunctionApp.Exceptions;
global using Microsoft.Azure.Functions.Extensions.DependencyInjection;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.AspNetCore.Http;
global using Microsoft.Extensions.Logging;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.Azure.WebJobs;
global using Microsoft.Azure.WebJobs.Extensions.Http;
global using AzureFunctions.OidcAuthentication;
global using System;
global using System.Text.Json;
global using Newtonsoft.Json;
global using System.Linq;
global using System.Collections.Generic;
global using System.Threading.Tasks;