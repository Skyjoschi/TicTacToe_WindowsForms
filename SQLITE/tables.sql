-- Tabelle löschen
--DROP TABLE users;
-- DROP TABLE category;

--Tabelle anlegen

-- diese Tabelle wird über Fremdschlüssel am Ende mit users verknüpft sein. 1:n Beziehung
CREATE TABLE category (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    name TEXT NOT NULL,
    description TEXT NULL
);


CREATE TABLE users(
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    username TEXT NOT NULL,
    password TEXT,
    email TEXT,
    -- Fremdschlüssel wird vorbereitet, indem entsprechende Variable initialisiert wird
    category_id INTEGER,
    -- Fremdschlüssel wird gesetzt
    FOREIGN KEY (category_id)
    -- und mit entsprechender Spalte  verbunden
        REFERENCES category (id)
);

--Datensatz speichern/anlegen
INSERT INTO
    category (name, description)
VALUES
    ("admin", "Admins dürfen alles"),
    ("manager", "sind verantwortlich für Projekte"),
    ("developer", "Programmierer ")


INSERT INTO
    users (username, password, email, category_id)
VALUES
    ("Mario","geheim","mario@gmail.com", 1),
    ("Josia", "12345", "alt@gmail.com", 3),
    ("Marla", "geheim2", "alt2@gmail.com", 3)


-- Daten auslesen/selektieren
SELECT username as name FROM users;

SELECT * FROM users ORDER BY username DESC;

--Daten aktualisieren
UPDATE users SET password = "5377", email = "neueemail@gmail.com" WHERE id=2;

UPDATE users SET category_id = 1 WHERE id = 1;

-- Datensätze aus mehreren TAbellen selektieren, mit JOINTs andere Tabellen heranziehen und dazustellen, 
-- gibt dabei unterschiedliche JOINTs
SELECT 
-- spezifiziert die Auswahl
 users.id as userid,
 users.username,
 category.name,
 category.description
FROM users
-- jetzt wird der Fremdschlüssel als Verknüpfung zur anderen Tabelle genutzt
LEFT JOIN category on users.category_id = category.id
ORDER BY category.description DESC;


-- Datensätze löschen
DELETE FROM users WHERE id = 2;

