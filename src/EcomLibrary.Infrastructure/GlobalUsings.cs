global using Confluent.Kafka;
global using EcomLibrary.Core.CQRS.CommandHandling;
global using EcomLibrary.Core.CQRS.QueryHandling;
global using EcomLibrary.Core.Domain;
global using EcomLibrary.Core.EventBus;
global using EcomLibrary.Infrastructure.CQRS;
global using EcomLibrary.Infrastructure.EventBus;
global using EcomLibrary.Infrastructure.Http;
global using EcomLibrary.Infrastructure.Identity;
global using EcomLibrary.Infrastructure.Integration;
global using EcomLibrary.Infrastructure.Kafka.Consumer;
global using EcomLibrary.Infrastructure.Kafka.Serialization;
global using EcomLibrary.Infrastructure.Kafka.Workers;
﻿global using EcomLibrary.Core.Infrastructure.Outbox;
global using EcomLibrary.Infrastructure.Outbox.Workers;
global using EcomLibrary.Infrastructure.WebApi;
global using EcomLibrary.Infrastructure.Workers;
global using EcomLibrary.Core.Persistence;
global using EcomLibrary.Core.Testing;
global using EcomLibrary.Core.Reflection;
global using IdentityModel.Client;
global using JasperFx.Core.Reflection;
global using Marten;
global using MediatR;
global using Microsoft.AspNetCore.Authentication;
global using Microsoft.AspNetCore.Authentication.JwtBearer;
global using Microsoft.AspNetCore.Authorization;
global using Microsoft.AspNetCore.Builder;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.Extensions.Caching.Memory;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.DependencyInjection.Extensions;
global using Microsoft.Extensions.Hosting;
global using Microsoft.Extensions.Logging;
global using Microsoft.Extensions.Options;
global using Microsoft.IdentityModel.Tokens;
global using Microsoft.OpenApi.Models;
global using Newtonsoft.Json;
global using Newtonsoft.Json.Linq;
global using NSubstitute;
global using Polly;
global using System.IdentityModel.Tokens.Jwt;
global using System.Linq.Expressions;
global using System.Net.Http.Headers;
global using System.Net.Mime;
global using System.Text;
global using System.ComponentModel;
global using Weasel.Core;
global using Marten.Linq;

