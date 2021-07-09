<?php

/*	
	Passos para rodar esse arquivo no Apache:
	Vide: https://github.com/romeOz/docker-apache-php
	1-docker run --name app -d -p 8080:80 romeoz/docker-apache-php
	2-Acessar http://localhost:8080/ e ver a página com o "Hello world!"
	3-No diretório que está esse arquivo rodar(para copia-lo para o container): docker cp regex.php app:/var/www/app
	4-Acessar http://localhost:8080/regex.php
	5-Quando terminar: docker stop app
*/

$regexp = '~(\d\d)(\w)~';
$alvo = '11a22b33c';

$achou = preg_match($regexp, $alvo, $match);
echo $achou;
echo "<br>";
print_r($match);
echo "<br>";
echo "<br>";

$achou = preg_match_all($regexp, $alvo, $match);
echo $achou;
echo "<br>";
print_r($match);
echo "<br>";
echo "<br>";

$achou = preg_match_all($regexp, $alvo, $match, PREG_OFFSET_CAPTURE);
echo $achou;
echo "<br>";
print_r($match);

?>