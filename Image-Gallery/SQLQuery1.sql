CREATE DATABASE ImageGallery;

USE ImageGallery;

CREATE Table Images (ID INT Identity(1,1) PRIMARY KEY, Name VARCHAR(100), ImageData VARCHAR(100), ContentType VARCHAR(100));


SELECT * FROM Images;