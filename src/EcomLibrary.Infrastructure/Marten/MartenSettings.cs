﻿namespace EcomLibrary.Infrastructure.Marten;

public record MartenSettings
{
    public string WriteSchema { get; set; }
    public string ReadSchema { get; set; }
}
