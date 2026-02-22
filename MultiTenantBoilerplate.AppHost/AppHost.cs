var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.MultiTenantBoilerplate_Api>("multitenantboilerplate-api");

builder.Build().Run();
