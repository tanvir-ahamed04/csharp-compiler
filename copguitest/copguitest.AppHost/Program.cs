var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.copguitest_ApiService>("apiservice");

builder.AddProject<Projects.copguitest_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
