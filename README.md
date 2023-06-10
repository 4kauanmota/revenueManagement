# blazor-wasm-trabalho
Segundo trabalho Camilo.


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
    id_comida     varchar(100) null,
    id_ingredient varchar(100) null
);

create table ingredient
(
    Id     varchar(100) null,
    Name   varchar(80)  null,
    Weight double       null
);