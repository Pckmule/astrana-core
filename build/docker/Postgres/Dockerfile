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
    psql -U postgres -tc "SELECT 1 FROM pg_database WHERE datname = 'astrana'" | grep -q 1 || psql -U postgres -c "CREATE DATABASE astrana" &&\
    psql -c "ALTER USER postgres WITH ENCRYPTED PASSWORD 'I@m5ecure!!';"

EXPOSE 5432
