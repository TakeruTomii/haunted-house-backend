create table LoginUsers (
   Id string(36) ,
   Name string(50),
   Email string(319),
   Role integer,
   Salt string(256),
   CreateDate datetime,
   UpdateDate datetime,
   primary key(Id)
);
insert into LoginUsers values("admin-user-id-1", "Admin", "admin@gmail.com", "admin-salt-1", current_timestamp, current_timestamp )
insert into LoginUsers values("test-user-id-1", "John Doe", "john.doe@gmail.com", "test-user-salt-1", current_timestamp, current_timestamp)

--create table SaveData (
--   UserId string(36) ,
--   Id string(36) ,
--   Slot integer,
--   UserName string(50),
--   IsClear bool,
--   CreateDate datetime,
--   UpdateDate datetime
--);

--create table Items (
--   UserId string(36) ,
--   SaveId string(36) ,
--   Id string(36) ,
--   Name string(50),
--   Description string(512),
--   Slot integer,
--   ImgPath string(256),
--   CreateDate datetime,
--   UpdateDate datetime
--);