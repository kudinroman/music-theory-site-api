SET XACT_ABORT ON;

BEGIN TRAN;

INSERT INTO dbo.Game
(
    player_name
   ,level
   ,score
)
VALUES
(
    @player_name
   ,@level
   ,@score
);

COMMIT;

--INSERT INTO dbo.Game
--(
--    player_name
--   ,level
--   ,score
--)
--VALUES
--(
--    'name'
--   ,6
--   ,4
--);