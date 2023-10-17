FROM postgres:15.3-alpine3.18

# ENV POSTGRES_DB="astrana"
# ENV POSTGRES_USER="astranau"
# ENV POSTGRES_PASSWORD="postgres"

USER postgres

RUN chmod 0700 /var/lib/postgresql/data &&\
    initdb /var/lib/postgresql/data &&\
    echo "host all  all    0.0.0.0/0  md5" >> /var/lib/postgresql/data/pg_hba.conf &&\
    echo "listen_addresses='*'" >> /var/lib/postgresql/data/postgresql.conf &&\
    pg_ctl start &&\
    psql -U postgres -tc "SELECT 1 FROM pg_database WHERE datname = 'main'" | grep -q 1 || psql -U postgres -c "CREATE DATABASE main" &&\
    psql -c "ALTER USER postgres WITH ENCRYPTED PASSWORD 'I@m5ecure!!';"

EXPOSE 5432

# Add required alpine packages
RUN apk add openrc

# Install ASP.NET Core runtime
RUN apk update

RUN apk add aspnetcore7-runtime

# Switch to application installation directory
WORKDIR /opt/astrana

# Copy all release artifacts
COPY /release/dist/ /opt/astrana/

# Switch to the configuration directory
WORKDIR /etc

# Copy the configuration files
COPY /release/config/.astrana /etc/astrana/
COPY /release/config/ssl-certificate/* /etc/astrana/ssl/

# Switch to the application executable directory
WORKDIR /opt/astrana

# ENTRYPOINT ["dotnet", "Astrana.Core.Application.dll", "--urls", "https://0.0.0.0:9001"]