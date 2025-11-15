CREATE TABLE `hosty` 
	(
		`id` INT UNSIGNED NOT NULL AUTO_INCREMENT , 
		`host` VARCHAR(100) NOT NULL COMMENT 'nazwa pingowanego hosta' , 
		`interv` INT NOT NULL DEFAULT '10' COMMENT 'czas w sek.' , 
		`active` TINYINT(1) NULL DEFAULT '1' , 
		`startstop` TINYINT(1) NULL DEFAULT '1' , 
		`pingSend` INT NULL DEFAULT '0' , 
		`pingFail` INT NULL DEFAULT '0' , 
		`lastping` TIMESTAMP on update CURRENT_TIMESTAMP NULL , 
		PRIMARY KEY (`id`)
    ) ENGINE = InnoDB;

	SELECT * FROM `hosty`