# para executar esse programa, rodar no diretório onde ele está: ruby gsub.rb

# A partir de um objeto String podemos aplicar uma regex para procurar caracteres e substituir por outra string.
cpfLimpo = "111.222.333-96".gsub(/[.-]/,"")
puts cpfLimpo

# Existe um irmão desse método, o método gsub!, que possui os mesmos parâmetros mas manipula a mesma string.
cpf = "111.222.333-96"
cpf.gsub!(/[.-]/,"")
puts cpf

# Caso queira aplicar a regex apenas uma vez na string alvo existe o método sub.
cpfQuaseLimpo = "111.222.333-96".sub(/[.-]/,"")
puts cpfQuaseLimpo

# E sub!
cpf = "111.222.333-96"
cpf.sub!(/[.-]/,"")
puts cpf