FROM ubuntu:16.04
WORKDIR /app
COPY ./bin/Publish/PublishOutput .
RUN apt-get update -y --force-yes -qq
RUN apt-get install wget -y --force-yes -qq
RUN wget -q https://packages.microsoft.com/config/ubuntu/16.04/packages-microsoft-prod.deb
RUN dpkg -i packages-microsoft-prod.deb
RUN apt-get install apt-transport-https -y --force-yes -qq
RUN apt-get update -y --force-yes -qq
RUN apt-get install dotnet-sdk-2.2 -y --force-yes -qq
EXPOSE 5000
CMD nohup ./cloud_sql_proxy -instances=nickel-api:us-central1:database-project=tcp:3306 -credential_file=creds.json &
CMD dotnet PollutionApiDotNet.dll --server.urls http://0.0.0.0:8080
