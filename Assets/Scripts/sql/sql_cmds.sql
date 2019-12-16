-- Create table:
CREATE TABLE `furnitureshowcase`.`furniture` (
  `id` INT NOT NULL,
  `name` VARCHAR(45) NULL,
  `description` VARCHAR(45) NULL,
  `rating` INT NULL,
  `original_price` DOUBLE NULL,
  `discount_price` DOUBLE NULL,
  `contact_name` VARCHAR(45) NULL,
  `contact_email` VARCHAR(45) NULL,
  `contact_phone` VARCHAR(45) NULL,
  `contact_address` VARCHAR(45) NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC) VISIBLE)
ENGINE = InnoDB;

-- Insert rows:
INSERT INTO `furnitureshowcase`.`furniture` (`id`, `name`, `description`, `rating`, `original_price`, `discount_price`, `contact_name`, `contact_email`, `contact_phone`, `contact_address`) VALUES ('0', 'Basket', 'A nylon-made basket for laundry purposes.', '4', '9.99', '4.99', 'Donald J Anthony', 'dzjoocrkc8i@fakemailgenerator.net', '519-730-4226', '1657 Lauzon Parkway, Amherstburg, Ontario, N9V 2V1');
INSERT INTO `furnitureshowcase`.`furniture` (`id`, `name`, `description`, `rating`, `original_price`, `discount_price`, `contact_name`, `contact_email`, `contact_phone`, `contact_address`) VALUES ('1', 'Bathroom Sink', 'Wash your hands in this marble-made bathroom sink.', '3', '29.99', '19.99', 'James D Valdez', 'dyxy5j9219h@groupbuff.com', '416-250-1150', '3393 Dundas St, Toronto, Ontario, M2N 2G8');
INSERT INTO `furnitureshowcase`.`furniture` (`id`, `name`, `description`, `rating`, `original_price`, `discount_price`, `contact_name`, `contact_email`, `contact_phone`, `contact_address`) VALUES ('2', 'Bed', 'A fluffy bouncy twin-sized bed, comfortability-maximized', '5', '250.00', '199.99', 'Martin J Hodgdon', 'gqhq3cpduyq@groupbuff.com', '418-396-1100', '4022 avenue de Port-Royal, Bonaventure, Quebec, G0C 1E0');
INSERT INTO `furnitureshowcase`.`furniture` (`id`, `name`, `description`, `rating`, `original_price`, `discount_price`, `contact_name`, `contact_email`, `contact_phone`, `contact_address`) VALUES ('3', 'Bedroom Sofa', 'Sofa to sit next to the bed', '2', '35.00', '30.00', 'Duane S Vito', 'm11sn26tc2@meantinc.com', '705-965-4409', '910 Dry Pine Bay Rd, Cartier, Ontario, P0M 1J0');
INSERT INTO `furnitureshowcase`.`furniture` (`id`, `name`, `description`, `rating`, `original_price`, `discount_price`, `contact_name`, `contact_email`, `contact_phone`, `contact_address`) VALUES ('4', 'Bedside Table', 'Next to the bed to put down your watch and phone', '4', '20.00', '12.50', 'Dorothy R Hayes', '10rrju2tvvd@classesmail.com', '905-344-4820', '4348 Reserve St, Castleton, Ontario, K0K 1M0');
INSERT INTO `furnitureshowcase`.`furniture` (`id`, `name`, `description`, `rating`, `original_price`, `discount_price`, `contact_name`, `contact_email`, `contact_phone`, `contact_address`) VALUES ('5', 'Carpet', 'Makes the bedroom floor more comfy', '3', '9.99', '4.49', 'Rodney I Carlisle', 'gp7sxgpg6wm@powerencry.com', '250-658-8680', '3904 Burdett Avenue, Victoria, British Columbia, V8Y 1Y7');
INSERT INTO `furnitureshowcase`.`furniture` (`id`, `name`, `description`, `rating`, `original_price`, `discount_price`, `contact_name`, `contact_email`, `contact_phone`, `contact_address`) VALUES ('6', 'Chest of Drawers', 'A bunch of drawers with table for accessories', '2', '50.00', '45.67', 'Tommy G Snyder', '6uu5jnvp7g3@classesmail.com', '613-531-1557', '2908 Princess St, Kingston, Ontario, K7L 1C2');
INSERT INTO `furnitureshowcase`.`furniture` (`id`, `name`, `description`, `rating`, `original_price`, `discount_price`, `contact_name`, `contact_email`, `contact_phone`, `contact_address`) VALUES ('7', 'Coffee Table', 'A table for your cup of cuppuccino', '1', '89.99', '49.99', 'Leon A Ellis', 'm0jnk8f9t6r@classesmail.com', '705-796-8299', '1979 Bayfield St, Barrie, Ontario, L4M 4S8');
INSERT INTO `furnitureshowcase`.`furniture` (`id`, `name`, `description`, `rating`, `original_price`, `discount_price`, `contact_name`, `contact_email`, `contact_phone`, `contact_address`) VALUES ('8', 'Dining Chair', 'A chair you sit on to enjoy your bowl of pasta', '4', '5.99', '3.59', 'Matthew M Johnson', 'xh4xk920i4e@powerencry.com', '905-391-0972', '2234 Toy Avenue, Ajax Pickering, Ontario, L1W 3N9');
INSERT INTO `furnitureshowcase`.`furniture` (`id`, `name`, `description`, `rating`, `original_price`, `discount_price`, `contact_name`, `contact_email`, `contact_phone`, `contact_address`) VALUES ('9', 'Dining Table', 'A table you put your huge bowl of pasta on', '3', '20.59', '15.99', 'Matthew M Johnson', 'xh4xk920i4e@powerencry.com', '905-391-0972', '2234 Toy Avenue, Ajax Pickering, Ontario, L1W 3N9');
INSERT INTO `furnitureshowcase`.`furniture` (`id`, `name`, `description`, `rating`, `original_price`, `discount_price`, `contact_name`, `contact_email`, `contact_phone`, `contact_address`) VALUES ('10', 'Fireplace', 'Place some branches in it, and warm yourself up', '3', '80.00', '75.75', 'Clifton D Carney', '51a2fomoxf6@meantinc.com', '819-283-4225', '2677 St Jean Baptiste St, Ste Marie De Blandford, Quebec, G0X 2W0');
INSERT INTO `furnitureshowcase`.`furniture` (`id`, `name`, `description`, `rating`, `original_price`, `discount_price`, `contact_name`, `contact_email`, `contact_phone`, `contact_address`) VALUES ('11', 'Freestand Mirror', 'For some face-checking before you head out for work', '2', '40.05', '29.99', 'Terry G Atkinson', '3r023zkeke8@meantinc.com', '306-573-5471', '2903 St. John Street, Birsay, Saskatchewan, S4P 3Y2');
INSERT INTO `furnitureshowcase`.`furniture` (`id`, `name`, `description`, `rating`, `original_price`, `discount_price`, `contact_name`, `contact_email`, `contact_phone`, `contact_address`) VALUES ('12', 'Fridge', 'Keeping your meat product fresh for a good period of time', '5', '100.00', '75.00', 'Monica G Carignan', '01zjd49au1xo@groupbuff.com', '416-440-2464', '4065 Eglinton Avenue, Toronto, Ontario, M4P 1A6');
INSERT INTO `furnitureshowcase`.`furniture` (`id`, `name`, `description`, `rating`, `original_price`, `discount_price`, `contact_name`, `contact_email`, `contact_phone`, `contact_address`) VALUES ('13', 'Kitchen Bench', 'Gravite-made sink for washing vegetables and spaces to prepare your food ingredients.', '5', '150.00', '135.00', 'Michael V Sackett', 'bhwavp5evlo@fakemailgenerator.net', '519-326-3713', '3224 Lauzon Parkway, Leamington, Ontario, N8H 3B1');
INSERT INTO `furnitureshowcase`.`furniture` (`id`, `name`, `description`, `rating`, `original_price`, `discount_price`, `contact_name`, `contact_email`, `contact_phone`, `contact_address`) VALUES ('14', 'Lamp', 'Time to light up your room with this bright lamp.', '1', '39.99', '9.00', 'Larry I Bender', '50p6mmc8k08@classesmail.com', '613-577-0223', '473 Pitt St, Cornwall, Ontario, K6J 3R2');
INSERT INTO `furnitureshowcase`.`furniture` (`id`, `name`, `description`, `rating`, `original_price`, `discount_price`, `contact_name`, `contact_email`, `contact_phone`, `contact_address`) VALUES ('15', 'Oven Exhaust', 'Clear up all that greasy air in the kitchen', '5 ', '67.70', '57.70', 'Krystal W Young', '9icrzboxlln@groupbuff.com', '250-765-7190', '1400 Kinchant St, Rutland, British Columbia, V2X 2A2');
INSERT INTO `furnitureshowcase`.`furniture` (`id`, `name`, `description`, `rating`, `original_price`, `discount_price`, `contact_name`, `contact_email`, `contact_phone`, `contact_address`) VALUES ('16', 'Pantry', 'Corner cabinet for your extra clothes that cannot fit in the closet', '4', '75.50', '55.50', 'Bernice D Hendricks', 'ljt37xt4rp@powerencry.com', '905-667-1307', '1181 Barton Street, Hamilton, Ontario, L8R 1H8');
INSERT INTO `furnitureshowcase`.`furniture` (`id`, `name`, `description`, `rating`, `original_price`, `discount_price`, `contact_name`, `contact_email`, `contact_phone`, `contact_address`) VALUES ('17', 'Sofa (Large)', 'Large cosy fluffy cotton sofa for the whole family, prepare netflix, some popcorn, some pop.', '5', '250.00', '225.25', 'Colby M Parrish', 'ap8a56n61v@powerencry.com', '416-294-9629', '3510 Front Street, Toronto, Ontario, M5J 2N1');
INSERT INTO `furnitureshowcase`.`furniture` (`id`, `name`, `description`, `rating`, `original_price`, `discount_price`, `contact_name`, `contact_email`, `contact_phone`, `contact_address`) VALUES ('18', 'Sofa (Small)', 'Small cosy sofa for couples to enjoy their movie, with popcorn and cola', '5', '159.99', '125.00', 'Colby M Parrish', 'ap8a56n61v@powerencry.com', '416-294-9629', '3510 Front Street, Toronto, Ontario, M5J 2N1');
INSERT INTO `furnitureshowcase`.`furniture` (`id`, `name`, `description`, `rating`, `original_price`, `discount_price`, `contact_name`, `contact_email`, `contact_phone`, `contact_address`) VALUES ('19', 'Stove', 'Electric stove, sufficient heat for home chefs to prepare their best food.', '4', '400.00', '345.75', 'Corey L Carpenter', 't2jmp7qf3v@classesmail.com', '416-458-2158', '311 Merton Street, Toronto, Ontario, M1L 3K7');
INSERT INTO `furnitureshowcase`.`furniture` (`id`, `name`, `description`, `rating`, `original_price`, `discount_price`, `contact_name`, `contact_email`, `contact_phone`, `contact_address`) VALUES ('20', 'Toilet', 'Regular toiltet accessories', '1', '125.56', '74.56', 'Jason S Cain', '3dltz1fquxx@classesmail.com', '604-666-9469', '1781 Robson St, Vancouver, British Columbia, V6B 3K9');
INSERT INTO `furnitureshowcase`.`furniture` (`id`, `name`, `description`, `rating`, `original_price`, `discount_price`, `contact_name`, `contact_email`, `contact_phone`, `contact_address`) VALUES ('21', 'Towel', 'A 100% cotton towel to dry your hair.', '4', '5.00', '2.99', 'William E Samons', '8y566vd074p@classesmail.com', '418-696-0178', '1995 rue des Champs, Chicoutimi, Quebec, G7H 4N3');
INSERT INTO `furnitureshowcase`.`furniture` (`id`, `name`, `description`, `rating`, `original_price`, `discount_price`, `contact_name`, `contact_email`, `contact_phone`, `contact_address`) VALUES ('22', 'TV', 'A 50*50 television with glass made of crystal-clear resolution', '5', '600.00', '575.90', 'Patricia J Hinojosa', 'd07v73rsdo@fakemailgenerator.net', '514-712-9887', '2978 rue Levy, Montreal, Quebec, H3C 5K4');
INSERT INTO `furnitureshowcase`.`furniture` (`id`, `name`, `description`, `rating`, `original_price`, `discount_price`, `contact_name`, `contact_email`, `contact_phone`, `contact_address`) VALUES ('23', 'TV Stand', 'For putting the TV on, along with 4 wooden cabinets to store accessories', '3', '350.65', '320.54', 'Janice J Engles', 'om4uw3tu2f@meantinc.com', '416-906-1182', '366 Tycos Dr, Toronto, Ontario, M5T 1T4');
INSERT INTO `furnitureshowcase`.`furniture` (`id`, `name`, `description`, `rating`, `original_price`, `discount_price`, `contact_name`, `contact_email`, `contact_phone`, `contact_address`) VALUES ('24', 'Closet', 'For hanging your clothes, made of palm wood', '4', '80.00', '69.69', 'Sammy S Wellman', '0nfjjnlpx46a@fakemailgenerator.net', '905-805-5834', '2439 Bridgeport Rd, Milton, Ontario, L9T 1P4');
