-- sql code file
-- cheat sheet all things SQL https://www.w3schools.com/sql/default.asp
/* multi line comments are identical to C++
See? */

--People tend to use ALL CAPS for sql commands. For example;
CREATE DATABASE testDB;
-- Databases tend to use camelCase for naming.
-- statements are finished with a semi colon, again the same as C++

/*Data bases are containers for TABLES. These themselves contain data, 
which can be of a variety of types. The most common (and most like other
languages) are; INT, FLOAT, BOOL(considered numeric), CHAR, VARCHAR and TEXT.
DATETIME is also very common. with DATE and DATETIME, TIME, TIMESTAMP and YEAR. 

There are many more data types avaliable, but keeping things simple for now, these
are the most common. Most of these can or need to have a size variable defined on creation.
The behaviour of size is dependant on the data type. 
Some data types require additional parameters.*/

--Creating new tables is easy. Typically tables use snake case. 
-- Columns typically use PascalCase.
CREATE TABLE Personal_Info (
    PersonID INT,
    FullName VARCHAR(50),
    DateOfBirth DATE,
    HomeOwner BOOL,
    CurrentAddress VARCHAR(255)
); 
-- You will likely need to SELECT the previously created DATABASE to create this table within it.
-- You can ALTER TABLE (s) after creation; 
ALTER TABLE Personal_Info
ADD Email VARCHAR(50),
ADD MartialStatus BOOL;
ALTER TABLE Personal_Info
DROP COLUMN MartialStatus;

/* There are commands to alter names; ALTER TABLE table_name
                                      ALTER COLUMN column_name datatype
These are slightly different for MySQL, replacing ALTER with MODIFY for columns.*/

/* Constraints are often / usually added to complex tables. These allow
default values to be set, prevent NULL values, make sure entries are unique, allow for 
indexing and more. */
CREATE TABLE testDB2 (
    PersonID INT NOT NULL UNIQUE, -- in SQL server or other base SQL you would put PRIAMRY KEY here 
    FullName VARCHAR(50) NOT NULL,
    DateOfBirth DATE NOT NULL,
    HomeOwner BOOL DEFAULT 0,
    CurrentAddress VARCHAR(255),
    PRIMARY KEY (PersonID) -- This is MySQL syntax
);

-- Indexes are used to speed up operations, but slow down updating tables.
CREATE INDEX idx_fullname
ON Personal_Info(FullName); 
-- the syntax varies a lot, so worth checking before doing. Can also be done on multiple columns,
-- and can be UNIQUE (CREATE UNIQUE INDEX index_name ON Table_Name(Column)).

-- AUTO_INCREMENT constraint can be used for PRIMARY KEY columns to auto increment them. default is to increment
-- by one starting at one, but this can be changed. 