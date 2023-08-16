-- DROP TABLE tblTime;
DROP TABLE tblUser;
-- DROP TABLE tblScore;


CREATE TABLE tblUser (
    userID INTEGER PRIMARY KEY NOT NULL,
    userName TEXT NOT NULL,
    userPassword TEXT NOT NULL,
    userOverallTime DATE NULL, 
    userExtra INT NULL
);
CREATE TABLE tblScore(
    userID INTEGER PRIMARY KEY NOT NULL,
    userWins INT,
    userGamesCount INT,
    userNameFor TEXT,
        FOREIGN KEY (userNameFor) REFERENCES tblUser (userName)
);

CREATE Table tblTime(
    timePlayed INTEGER NULL,
    timeDate INTEGER NULL,
    timeFirstMatch DATE Null,
    userNameFor TEXT,
        FOREIGN KEY (userNameFor) REFERENCES tblUser (userName)
);

CREATE Table tblRanking(
    status TEXT,
    userWinsFor INT,
     FOREIGN KEY (userWinsFor) REFERENCES tblScore (userWins)
);
CREATE TABLE test(
    Other_ID INT PRIMARY Key NOT NULL,
    com_version TEXT,
    other_time INT REFERENCES tblTime (timeFirstMatch) ON UPDATE CASCADE ON DELETE SET NULL
);



INSERT INTO 
    tblUser (userName, userPassword)
VALUES
    ("Josia", "2345"),
    ("Samuel", "geheim"),
    ("Jan", "Passwort!")


INSERT INTO 
    tblTime (userNameFor, timeDate, timePlayed)
VALUES
    ("Josia", 20230704, 15),
    ("Samuel", 20210510, 50),
    ("Jan", 20230817, 3)

INSERT INTO
    tblRanking(status, userWinsFor)
Values
    ("Diamond", 30),
    ("Gold", 20),
    ("Silver", 15),
    ("Bronze", 10),
    ("Clay", 5)

INSERT INTO
    tblScore(userWins, userGamesCount, userNameFor)
Values
    (2, 5, "Josia"),
    (3, 5, "Samuel")


-- Updaten
UPDATE tblUser SET userWins = 2;
UPDATE tblUser SET userWins = 10 WHERE userName = "Josia";


-- Daten auswerten 
SELECT 
 userID,
 userName,
 tblTime.timePlayed as Spielzeit,
 tblTime.timeDate as Datum
FROM tblUser 
LEFT JOIN tblTime on tblTime.id_user_name = tblUser.userName


SELECT 
 userID,
 userName,
 tblRanking.status
FROM tblUser
INNER JOIN tblRanking on tblUser.userWins = tblRanking.userWins