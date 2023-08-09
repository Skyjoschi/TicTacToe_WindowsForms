-- DROP TABLE tblTime
-- DROP TABLE tblUser


CREATE TABLE tblUser (
    userID INTEGER PRIMARY KEY AUTOINCREMENT,
    userName TEXT NOT NULL,
    userPassword TEXT NOT NULL,
    userWins NULL,
    userGamesCount NULL,
    userOverallTime NULL
)

CREATE Table tblTime(
    timePlayed INTEGER NULL,
    timeDate INTEGER NULL,
    timeFirstMatch Null,
    id_user_name TEXT,
     FOREIGN KEY (id_user_name) REFERENCES tblUser (userName)
)

CREATE Table tblRanking(
    status TEXT,
    userWins INTEGER,
     FOREIGN KEY (userWins) REFERENCES tblUser (userWins)
)



INSERT INTO 
    tblUser (userName, userPassword, userWins, userGamesCount)
VALUES
    ("Josia", "2345", 3, 10),
    ("Samuel", "geheim", 5, 10),
    ("Jan", "Passwort!", 2, 10)


INSERT INTO 
    tblTime (id_user_name, timeDate, timePlayed)
VALUES
    ("Josia", 20230704, 15),
    ("Samuel", 20210510, 50),
    ("Jan", 20230817, 3)


INSERT INTO
    tblRanking(status, userWins)
Values
    ("Diamond", 30),
    ("Gold", 20),
    ("Silver", 15),
    ("Bronze", 10),
    ("Clay", 5)


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