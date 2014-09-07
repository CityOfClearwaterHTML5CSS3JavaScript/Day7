USE [master]
GO
CREATE DATABASE MyClearwater ON 
( FILENAME = N'C:\Users\Geek\Documents\City of Clearwater\Projects\myclearwater.com\MyClearwater.mdf' ),
( FILENAME = N'C:\Users\Geek\Documents\City of Clearwater\Projects\myclearwater.com\MyClearwater.ldf' )
 FOR ATTACH ;
GO