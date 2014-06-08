




-- -----------------------------------------------------------
-- Entity Designer DDL Script for MySQL Server 4.1 and higher
-- -----------------------------------------------------------
-- Date Created: 06/08/2014 15:25:39
-- Generated from EDMX file: F:\Gebruikers\Nick\Documenten 2\Hoge School\C#\retry\Shuppet\StoreService\StoreModel.edmx
-- Target version: 3.0.0.0
-- --------------------------------------------------

DROP DATABASE IF EXISTS `shuppet`;
CREATE DATABASE `shuppet`;
USE `shuppet`;

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- NOTE: if the constraint does not exist, an ignorable error will be reported.
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------
SET foreign_key_checks = 0;
SET foreign_key_checks = 1;

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

CREATE TABLE `UserSet`(
	`Id` int NOT NULL AUTO_INCREMENT UNIQUE, 
	`username` longtext NOT NULL, 
	`password` longtext NOT NULL, 
	`cashAmount` longtext NOT NULL);

ALTER TABLE `UserSet` ADD PRIMARY KEY (Id);




CREATE TABLE `OrderSet`(
	`Id` int NOT NULL AUTO_INCREMENT UNIQUE, 
	`OrderDate` longtext NOT NULL, 
	`User_Id` int NOT NULL);

ALTER TABLE `OrderSet` ADD PRIMARY KEY (Id);




CREATE TABLE `OderProductSet`(
	`Id` int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Amount` longtext NOT NULL, 
	`Order_Id` int NOT NULL, 
	`Product_Id` int NOT NULL);

ALTER TABLE `OderProductSet` ADD PRIMARY KEY (Id);




CREATE TABLE `ProductSet`(
	`Id` int NOT NULL AUTO_INCREMENT UNIQUE);

ALTER TABLE `ProductSet` ADD PRIMARY KEY (Id);






-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on `User_Id` in table 'OrderSet'

ALTER TABLE `OrderSet`
ADD CONSTRAINT `FK_UserOrder`
    FOREIGN KEY (`User_Id`)
    REFERENCES `UserSet`
        (`Id`)
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserOrder'

CREATE INDEX `IX_FK_UserOrder` 
    ON `OrderSet`
    (`User_Id`);

-- Creating foreign key on `Order_Id` in table 'OderProductSet'

ALTER TABLE `OderProductSet`
ADD CONSTRAINT `FK_OrderOderProduct`
    FOREIGN KEY (`Order_Id`)
    REFERENCES `OrderSet`
        (`Id`)
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_OrderOderProduct'

CREATE INDEX `IX_FK_OrderOderProduct` 
    ON `OderProductSet`
    (`Order_Id`);

-- Creating foreign key on `Product_Id` in table 'OderProductSet'

ALTER TABLE `OderProductSet`
ADD CONSTRAINT `FK_ProductOderProduct`
    FOREIGN KEY (`Product_Id`)
    REFERENCES `ProductSet`
        (`Id`)
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductOderProduct'

CREATE INDEX `IX_FK_ProductOderProduct` 
    ON `OderProductSet`
    (`Product_Id`);

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
