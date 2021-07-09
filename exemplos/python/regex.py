# Para executar esse programa, no diretório onde ele se encontra rodar:
# "C:\Users\myuser\Documents\apps\python-3.9.5-embed-amd64\python" regex.py

import re

regexp = r'(\d\d)(\w)'
alvo = '11a22b33c'

print("Unico match:")
print()

resultado = re.search(regexp, alvo)
print(resultado.group())
print(resultado.group(0))
print(resultado.group(1))
print(resultado.group(2))
print(resultado.start())
print(resultado.end())

print()
print("Varios matches:")
print()

resultados = re.finditer(regexp, alvo)
for resultado in resultados:
    print("%s | %s | %s [%s,%s]" % (resultado.group(), resultado.group(1), resultado.group(2), resultado.start(), resultado.end()))