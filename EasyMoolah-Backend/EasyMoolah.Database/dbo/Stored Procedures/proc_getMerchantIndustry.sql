
-- =============================================
-- Author:		Jarrod Ramsaroop
-- Create date: 20181003
-- Description:
-- Changelog:	
-- Test: proc_getMerchantIndustry null, 0
-- =============================================
CREATE PROCEDURE proc_getMerchantIndustry
@Key AS INT = NULL,
@parentKey AS INT = NULL,
@level AS INT = 0
AS
BEGIN
	IF (@level = 0)
	BEGIN
		SELECT
			 [merindKey]
			,[merindName]
			,[merindDescription]
			,[merindParentKey]
		FROM [EM-Live].[dbo].[lkp_MerchantIndustry]
		WHERE 
			[merindIsActive] = 1 AND
			([merindKey] = @Key OR @Key is NULL) AND
			[merindParentKey] IS NULL
		END
		ELSE
		BEGIN
			SELECT
				 [merindKey]
				,[merindName]
				,[merindDescription]
				,[merindParentKey]
			FROM [EM-Live].[dbo].[lkp_MerchantIndustry]
			WHERE 
				[merindIsActive] = 1 AND
				([merindKey] = @Key OR @Key is NULL) AND
				[merindParentKey] = @parentKey
		END
END
