# pollutionApiDotNet
- An ASP.NET CORE web API using EFCore and Google Cloud MySQL

## References
- https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-2.2&tabs=visual-studio-code

## Startup
1. SSH Into Compute Engine VM
2. Make sure no containers are running: `docker container list`
3. Execute the following:
```bash
docker exec $(docker run -d -p 8080:8080 gcr.io/pollutiondb-api/pollution-api) \ 
nohup ./cloud_sql_proxy -instances=nickel-api:us-central1:database-project=tcp:3306 \
-credential_file=creds.json &
```