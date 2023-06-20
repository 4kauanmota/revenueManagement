# blazor-wasm-trabalho
Segundo trabalho Camilo.

```dotnet run --project <nome-project>```


SQL icomida:

create table food
(
    Id          varchar(100) null,
    Name        varchar(100) null,
    Description varchar(255) null,
    Weight      double       null,
    Time        double       null,
    Preparation varchar(100) null
);

create table food_ingredient
(
    Id           varchar(100) null,
    IdFood       varchar(100) null,
    IdIngredient varchar(100) null
);

create table ingredient
(
    Id     varchar(100) null,
    Name   varchar(80)  null,
    Weight double       null
);
