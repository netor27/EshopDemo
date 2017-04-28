using Demo.BuildingBlocks.Resilience.Http;
using System;

namespace Demo.WebMVC.Infrastructure
{
    public interface IResilientHttpClientFactory
    {
        ResilientHttpClient CreateResilientHttpClient();
    }
}