Create Procedure WorkRequestsPerTimePeriod
@Start_date Date,
@End_date Date

AS

SELECT DATEPART(Year, Date_work_received) Year, DATEPART(Month, Date_work_received) Month, COUNT(Work_request_ID)
FROM WORK_REQUEST
WHERE Date_work_received >= @Start_date AND Date_work_received <= @End_date
GROUP BY DATEPART(Year, Date_work_received), DATEPART (Month, Date_work_received)
ORDER BY Year, Month