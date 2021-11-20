Create database savassigames;
use savassigames;

CREATE TABLE savassigames (
  `id` varchar(45) NOT NULL,
  `produto` varchar(45) NOT NULL,
  `preco` varchar(45) NOT NULL,
  primary key(id)
) ENGINE=InnoDB;


INSERT INTO savassigames (`id`, `produto`, `preco`) VALUES
('4', '4', '7');
COMMIT;
