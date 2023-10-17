# Architecture and Design Principles

Add summary here... this document is intended to set out and explain the most important 
architecture and design principles and decisions for the solution.

## Data Model

### Index Clustering

#### General Guidelines

1. Don't use GUIDs as clustering in keys in the database:<br />
[GUIDs as PRIMARY KEYs and/or the clustering key](https://www.sqlskills.com/blogs/kimberly/guids-as-primary-keys-andor-the-clustering-key)

#### Microsoft SQL Server

#### PostgreSQL

[NPGSQL - GitHub Issue - How to make Primary Key Cluster](https://github.com/npgsql/efcore.pg/issues/1150)

(https://www.postgresql.org/docs/current/sql-cluster.html)

#### MySQL

https://dev.mysql.com/doc/refman/8.1/en/innodb-index-types.html