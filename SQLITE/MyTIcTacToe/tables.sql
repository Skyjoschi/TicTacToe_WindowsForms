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

-- Daten auswerten 
SELECT 
 userID,
 userName,
 tblTime.timePlayed as Spielzeit,
 tblTime.timeDate as Datum
FROM tblUser 
LEFT JOIN tblTime on tblTime.id_user_name = tblUser.userName
