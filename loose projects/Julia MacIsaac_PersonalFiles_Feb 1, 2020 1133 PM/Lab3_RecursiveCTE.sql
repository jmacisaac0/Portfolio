
USE CTELAB
GO

WITH cteReports(AreaID, AreaName, ParentAreaID, AreaTypeID, AreaTypeName)
AS (
	SELECT a.AreaID, a.AreaName, a.ParentAreaID, a.AreaTypeID, at.AreaTypeName
	FROM Area a INNER JOIN AreaType at
	ON a.AreaTypeID = at.AreaTypeID
	WHERE ParentAreaID = 1 
	UNION ALL
	SELECT e.AreaID, e.AreaName, e.ParentAreaID, e.AreaTypeID, r.AreaTypeName
	FROM Area e INNER JOIN cteReports r
	ON e.ParentAreaID = r.AreaID
)
SELECT 
	CONCAT(AreaName, ' - ', (
		SELECT AreaTypeName
		FROM AreaType
		WHERE AreaTypeID = cteReports.AreaTypeID) 
	) AS Area, 
	CONCAT (
		(SELECT AreaName
		FROM Area
		WHERE AreaID = cteReports.ParentAreaID), 
		' - ',
		(SELECT AreaTypeName
		FROM Area a INNER JOIN AreaType at
		ON a.
		WHERE AreaTypeID = a.ParentAreaID)
	) AS Parent
FROM cteReports
ORDER BY ParentAreaID;

--,
	--cteReports.AreaTypeID as areasomething,
	--cteReports.ParentAreaID AS something



