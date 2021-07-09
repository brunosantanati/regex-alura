# para executar esse programa, rodar no diretório onde ele está: ruby regex.rb

regex = /(\d\d)(\w)/
alvo = "11a22b33c"

resultado = regex.match(alvo)

print 'match inteiro: '
puts resultado[0]
print 'begin: '
puts resultado.begin 0
print 'end: '
puts resultado.end 0
puts

print 'primeiro grupo: '
puts resultado[1]
print 'begin: '
puts resultado.begin 1
print 'end: '
puts resultado.end 1
puts

print 'segundo grupo: '
puts resultado[2]
print 'begin: '
puts resultado.begin 2
print 'end: '
puts resultado.end 2
puts

print 'varios matches:'
puts
resultados = alvo.scan regex
puts resultados [0][0]
puts resultados [0][1]
puts resultados [1][0]
puts resultados [1][1]
puts resultados [2][0]
puts resultados [2][1]