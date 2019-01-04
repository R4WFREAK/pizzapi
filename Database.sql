create database pizzapi
  collate Latin1_General_CI_AS
go

create table User
(
  Id           int identity
    primary key,
  RemoteId     nvarchar(max)                  not null,
  ShowName     nvarchar(max)                  not null,
  CreationTime datetime2 default getutcdate() not null
)
go

create unique index User_Id_uindex
  on User (Id)
go

create table Pizza
(
  Id           int identity,
  CreationTime datetime2 constraint Pizza_CreationTime_default default getutcdate() not null,
  Latitude     float                                                                not null,
  Longitude    float                                                                not null,
  Rating       smallint,
  UserId       int                                                                  not null
    constraint Pizza_User_Id_fk
    references User,
  ConsumeTime  datetime2 default getutcdate()                                       not null
)
go

create unique index Pizza_Id_uindex
  on Pizza (Id)
go

create table PizzaImage
(
  Id           int identity,
  PizzaId      int                            not null
    constraint PizzaImage_Pizza_Id_fk
    references Pizza (Id),
  ImageUri     nvarchar(1)                    not null,
  CreationTime datetime2 default getutcdate() not null
)
go

create unique index PizzaImage_Id_uindex
  on PizzaImage (Id)
go

