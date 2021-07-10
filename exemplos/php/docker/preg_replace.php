<?php

/*	
	Passos para rodar esse arquivo no Apache:
	Vide: https://github.com/romeOz/docker-apache-php
	1-docker run --name app -d -p 8080:80 romeoz/docker-apache-php
	2-Acessar http://localhost:8080/ e ver a página com o "Hello world!"
	3-No diretório que está esse arquivo rodar(para copia-lo para o container): docker cp preg_replace.php app:/var/www/app
	4-Acessar http://localhost:8080/preg_replace.php
	5-Quando terminar: docker stop app
*/

$string = 'Setembro 21';
$regex = '~(\w+)\s(\d+)~';
$novoTexto = '$2 de $1';
$resultado = preg_replace($regex, $novoTexto, $string);
echo $resultado; // 21 de Setembro
echo "\r\n";

$string = '2007-12-31';
$regex = '~(\d{4})-(\d{2})-(\d{2})~';
$novoTexto = '$3-$2-$1';
$resultado =  preg_replace($regex, $novoTexto, $string);
echo $resultado;
echo "\r\n";

$string = '31-12-2007';
$regex = '~-~';
$novoTexto = '/';
$resultado =  preg_replace($regex, $novoTexto, $string);
echo $resultado; // 31/12/2007

?>