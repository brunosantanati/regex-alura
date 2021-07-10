# Para executar esse programa, no diretório onde ele se encontra rodar:
# "C:\Users\myuser\Documents\apps\python-3.9.5-embed-amd64\python" findall.py

import re

regex = re.compile(r'(\d\d)(\w)')
alvo = '11a22b33c'
resultado = re.findall(regex, alvo)
print(resultado)
print(resultado[0])
print(resultado[1])
print(resultado[2])

print()

print("Iterando")
for grupo in resultado:
    print(grupo)
    
print()

print("Iterando")
for grupo in resultado:
    print(grupo[0] + grupo[1])
