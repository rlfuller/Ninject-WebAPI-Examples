USE BaseballLibrary
GO

INSERT INTO Leagues (LeagueName)
VALUES ('Shake N'' Bake');

INSERT INTO Teams (TeamName, ManagerName)
VALUES ('Sweet Baby Jesus', 'Ricky Bobby'), 
	   ('Tuxedo T Shirts', 'Cal Naughton Jr.'),
	   ('Death By Spider Monkey', 'Walker & Texas Ranger'),
	   ('I Love Crepes', 'Jean Girard');

INSERT INTO LeagueTeamDetails 
VALUES (1, 1), (1, 2), (1, 3), (1, 4);

INSERT INTO Positions (PositionName)
VALUES ('P'), ('C'), ('1B'), ('2B'), ('3B'), ('SS'), ('LF'), ('CF'), ('RF');

INSERT INTO Players (PlayerName, JerseyNumber, PositionID, PreviousYrsBattingAvg, NumYrsPlayed, TeamID)
VALUES ('Ricky Bobby', 26, 1, 0.750, 15, 1),
	   ('Cal Naughton Jr.', 2, 1, 0.600, 15, 2),
	   ('Walker', 7, 1, 0.150, 3, 3),
	   ('Texas Ranger', 8, 2, 0.250, 5, 3),
	   ('Jean Girard', 1, 1, 0.800, 14, 4),
	   ('Chip', 98, 4, 0.020, 35, 1),
	   ('Carley', 13, 8, null, null, 2),
	   ('Lucius Washington', 25, 3, 0.900, 12, 3),
	   ('Reese Bobby', 32, 6, null, null, 4),
	   ('Susan', 17, 9, 0.225, 7, 1);
