DROP DATABASE IF EXISTS VIDEORENTAL;
CREATE DATABASE VIDEORENTAL;
USE VIDEORENTAL;
DROP TABLE IF EXISTS Customer;
DROP TABLE IF EXISTS MOVIES;
DROP TABLE IF EXISTS RentedMovies;


CREATE TABLE `Customer` (
  `CustID` int(10) NOT NULL auto_increment primary key,
  `FirstName` varchar(25)  DEFAULT NULL,
  `LastName` varchar(25)  DEFAULT NULL,
  `Address` varchar(25)  DEFAULT NULL,
  `Phone` int(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;


CREATE TABLE `movies` (
  `movieID` int(10)  NOT NULL auto_increment primary key,
  `Title` varchar(25) DEFAULT NULL,
  `Year` varchar(25) DEFAULT NULL,
  `Rental_Cost` int(10) DEFAULT NULL,
  `Genre` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;


CREATE TABLE `RentedMovies` (
  `RMID` int(10)  NOT NULL auto_increment primary key,
  `MovieIDFK` int(10) DEFAULT NULL,
  `CustIDFK` int(10) DEFAULT NULL,
  `DateRented` datetime DEFAULT NULL,
  `DateReturned` datetime DEFAULT NULL,
  CONSTRAINT `FK_CustIDFk` FOREIGN KEY (`CustIDFK`) REFERENCES `Customer` (`CustID`),
  CONSTRAINT `FK_movieIDFk` FOREIGN KEY (`movieIDFK`) REFERENCES `movies` (`movieID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

INSERT INTO customer (FirstName, LastName, Address, Phone) VALUES ('scott', 'lang', '16 rot Street', '1345556');
INSERT INTO customer (FirstName, LastName, Address, Phone) VALUES ('Natasha', 'romanoff', '23 bleekers Street', '0112345');
INSERT INTO customer (FirstName, LastName, Address, Phone) VALUES ('Isaac', 'Newton', '81233 apple Street', '2111108');
INSERT INTO customer (FirstName, LastName, Address, Phone) VALUES ('Mark', 'Henry', '121 carot Lane', '411352');

INSERT INTO Movies (Title, Year,Rental_Cost,Genre) VALUES ('star wars:clone wars', '2003',2,'Sci-Fi,');
INSERT INTO Movies (Title, Year,Rental_Cost,Genre) VALUES ('lord of the rings', '2000',2,'adventure, drama');
INSERT INTO Movies (Title, Year,Rental_Cost,Genre) VALUES ('jurassic park', '2016',5,'Action, adventure');
INSERT INTO Movies (Title, Year,Rental_Cost,Genre) VALUES ('game night', '2019',5,'Action, Sci-Fi');


INSERT INTO RentedMovies (MovieIDFK, CustIDFK, DateRented) VALUES (3, 1, '2019-09-01T21:15:38.793');
INSERT INTO RentedMovies (MovieIDFK, CustIDFK, DateRented) VALUES (4, 2, '2019-08-31T21:12:39.793');
INSERT INTO RentedMovies (MovieIDFK, CustIDFK, DateRented, DateReturned) VALUES (1, 3, '2018-04-09T22:11:15.232', '2019-01-02T10:20:10.211');
INSERT INTO RentedMovies (MovieIDFK, CustIDFK, DateRented, DateReturned) VALUES (2, 3, '2017-03-10T9:22:30.793', '2018-04-09T15:30:03.447');
