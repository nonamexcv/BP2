﻿ALTER TABLE [dbo].[Match]
	ADD CONSTRAINT [Match_FK2]
	FOREIGN KEY (TeamB_ID)
	REFERENCES [Team] (TeamID)